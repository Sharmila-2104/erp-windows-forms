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
    public partial class COA_LedgerGroup : Form
    {
        COA_LedgerGroup_DAO CO_DAO = new COA_LedgerGroup_DAO();
        COA_LedgerGroup_DTO CO_DTO = new COA_LedgerGroup_DTO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public COA_LedgerGroup()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void COAGroup_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            CO_DTO.Id = 2;
            DS = CO_DAO.COALedgerGroupDB(CO_DTO);
            GV_List.DataSource = DS.Tables[0];

            UnderLGroup_Cmbx.DataSource = DS.Tables[1];
            UnderLGroup_Cmbx.ValueMember = "LedgerGroupNumber";
            UnderLGroup_Cmbx.DisplayMember = "LedgerGroup";

            GroupNature_Cmbx.DataSource = DS.Tables[2];
            GroupNature_Cmbx.ValueMember = "Number";
            GroupNature_Cmbx.DisplayMember = "Nature";
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
                        CO_DTO.LedgerGroupNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_LedgerGroupNumber"].Value);
                        CO_DTO.Id = 3;
                        DS = CO_DAO.COALedgerGroupDB(CO_DTO);
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
                CO_DTO.LedgerGroupNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_LedgerGroupNumber"].Value);
                CO_DTO.Id = 4;
                DS = CO_DAO.COALedgerGroupDB(CO_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderLGroup_Cmbx.DataSource = DS.Tables[1];
                    UnderLGroup_Cmbx.ValueMember = "LedgerGroupNumber";
                    UnderLGroup_Cmbx.DisplayMember = "LedgerGroup";

                    GroupNature_Cmbx.DataSource = DS.Tables[2];
                    GroupNature_Cmbx.ValueMember = "Number";
                    GroupNature_Cmbx.DisplayMember = "Nature";

                    LedgerGroupNumber_Txt.Text = DS.Tables[0].Rows[0]["LedgerGroupNumber"].ToString();
                    LedgerGroup_Txt_Special.Text = DS.Tables[0].Rows[0]["LedgerGroup"].ToString();
                    UnderLGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderLGroup"].ToString();
                    GroupNature_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["GroupNature"].ToString();

                    LedgerGroup_Txt_Special.Focus();

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
                    CO_DTO.LedgerGroup = LedgerGroup_Txt_Special.Text;
                    CO_DTO.UnderLGroup = Convert.ToInt64(UnderLGroup_Cmbx.SelectedValue);
                    CO_DTO.GroupNature = Convert.ToInt64(GroupNature_Cmbx.SelectedValue);
                    CO_DTO.CreatorCode = 1;
                    CO_DTO.Rights = 1;
                    CO_DTO.Id = 1;
                    DS = CO_DAO.COALedgerGroupDB(CO_DTO);
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

            LedgerGroup_Txt_Special.Focus();

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
                if (Duplicate(LedgerGroupNumber_Txt.Text))
                {
                    CO_DTO.LedgerGroupNumber = Convert.ToInt32(LedgerGroupNumber_Txt.Text);
                    CO_DTO.LedgerGroup = LedgerGroup_Txt_Special.Text;
                    CO_DTO.UnderLGroup = Convert.ToInt64(UnderLGroup_Cmbx.SelectedValue);
                    CO_DTO.GroupNature = Convert.ToInt64(GroupNature_Cmbx.SelectedValue);
                    CO_DTO.CreatorCode = 1;
                    CO_DTO.Rights = 1;
                    CO_DTO.Id =5;
                    DS = CO_DAO.COALedgerGroupDB(CO_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();                  
                }
            }
        }
        private void LedgerGroup_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(LedgerGroupNumber_Txt.Text));
        }        
        Boolean Duplicate(String LedgerGroupNumber)
        {
            if (LedgerGroupNumber.Length > 0)
            {
                CO_DTO.LedgerGroupNumber = Convert.ToInt32(LedgerGroupNumber);
                CO_DTO.LedgerGroup = LedgerGroup_Txt_Special.Text;
                CO_DTO.Id = 7;
                DS = CO_DAO.COALedgerGroupDB(CO_DTO);
            }
            else
            {
                CO_DTO.LedgerGroup = LedgerGroup_Txt_Special.Text;
                CO_DTO.Id = 6;
                DS = CO_DAO.COALedgerGroupDB(CO_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                LedgerGroup_Txt_Special.Focus();
                return false;
            }
            return true;
        }

        
    }
}

