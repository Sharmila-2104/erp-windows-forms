using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Item.Master;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchase.COA.Master
{
    public partial class COA_Ledger : Form
    {

        COA_Ledger_DAO CL_DAO = new COA_Ledger_DAO();
        COA_Ledger_DTO CL_DTO = new COA_Ledger_DTO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public COA_Ledger()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void COALedger_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }

        void GetData()
        {
            CL_DTO.Id = 2;
            DS = CL_DAO.COA_LedgerDB(CL_DTO);
            GV_List.DataSource =DS.Tables[0];

            LedgerGroup_Cmbx.DataSource = DS.Tables[1];
            LedgerGroup_Cmbx.ValueMember = "LedgerGroupNumber";
            LedgerGroup_Cmbx.DisplayMember = "LedgerGroup";
        }

        private void DDL_LedgerGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (LedgerGroup_Cmbx.SelectedValue.ToString() != "")
            {
                CL_DTO.LedgerGroup = Convert.ToInt64(LedgerGroup_Cmbx.SelectedValue);
                CL_DTO.Id = 8;
                DS = CL_DAO.COA_LedgerDB(CL_DTO);
                GroupNature_Txt.Text = DS.Tables[0].Rows[0]["GroupNature"].ToString();
            }
        }

        private void GV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        CL_DTO.LedgerNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_LedgerNumber"].Value);
                        CL_DTO.Id = 3;
                        DS = CL_DAO.COA_LedgerDB(CL_DTO);
                        MessageBox.Show(Alert.Delete());
                        GetData();
                        Clear();
                    }
                    catch
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
            }

            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                CL_DTO.LedgerNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_LedgerNumber"].Value);
                CL_DTO.Id = 4;
                DS = CL_DAO.COA_LedgerDB(CL_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    LedgerGroup_Cmbx.DataSource = DS.Tables[1];
                    LedgerGroup_Cmbx.ValueMember = "LedgerGroupNumber";
                    LedgerGroup_Cmbx.DisplayMember = "LedgerGroup";

                    LedgerNumber_Txt.Text = DS.Tables[0].Rows[0]["LedgerNumber"].ToString();
                    LedgerAccount_Txt_Special.Text = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                    LedgerName_Txt_Special.Text = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                    LedgerGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["LedgerGroup"].ToString();
                    GroupNature_Txt.Text = DS.Tables[0].Rows[0]["GroupNature"].ToString();

                    LedgerAccount_Txt_Special.Focus();

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;
                    Btn_Clear.Text = "Cancel";
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    GetData();
                    Clear();
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (Duplicate(""))
                {
                    CL_DTO.LedgerAccount = LedgerAccount_Txt_Special.Text;
                    CL_DTO.LedgerName = LedgerName_Txt_Special.Text;
                    CL_DTO.LedgerGroup = Convert.ToInt64(LedgerGroup_Cmbx.SelectedValue);
                    CL_DTO.CreatorCode = 1;
                    CL_DTO.Rights = 1;
                    CL_DTO.Id = 1;
                    DS = CL_DAO.COA_LedgerDB(CL_DTO);
                    MessageBox.Show(Alert.Save());
                    GetData();
                    Clear();                  
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Va.AllClear(this);

            LedgerAccount_Txt_Special.Focus();

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
            Btn_Clear.Visible = true;
            Btn_Clear.Text = Btn_Clear.Tag.ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (Duplicate(LedgerNumber_Txt.Text))
                {
                    CL_DTO.LedgerNumber = Convert.ToInt64(LedgerNumber_Txt.Text);
                    CL_DTO.LedgerAccount = LedgerAccount_Txt_Special.Text;
                    CL_DTO.LedgerName = LedgerName_Txt_Special.Text;
                    CL_DTO.LedgerGroup = Convert.ToInt64(LedgerGroup_Cmbx.SelectedValue);
                    CL_DTO.CreatorCode = 5;
                    CL_DTO.Rights = 1;
                    CL_DTO.Id = 5;
                    DS = CL_DAO.COA_LedgerDB(CL_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }
        private void LedgerAccount_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(LedgerNumber_Txt.Text));
        }        
        Boolean Duplicate(String LedgerNumber)
        {
            if (LedgerNumber.Trim().Length > 0)
            {
                CL_DTO.LedgerNumber = Convert.ToInt64(LedgerNumber_Txt.Text);
                CL_DTO.LedgerAccount = LedgerAccount_Txt_Special.Text;
                CL_DTO.Id = 7;
                DS = CL_DAO.COA_LedgerDB(CL_DTO);
            }
            else
            {
                CL_DTO.LedgerAccount = LedgerAccount_Txt_Special.Text;
                CL_DTO.Id = 6;
                DS = CL_DAO.COA_LedgerDB(CL_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                LedgerAccount_Txt_Special.Focus();
                return false;
            }
            return true;
        }

        
    }
}
