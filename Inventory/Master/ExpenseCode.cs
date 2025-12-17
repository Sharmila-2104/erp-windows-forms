using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP.Purchase.Item.Master
{
    public partial class ExpenseCode : Form
    {
        ExpenseCode_DAO E_DAO = new ExpenseCode_DAO();
        ExpenseCode_DTO E_DTO = new ExpenseCode_DTO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        public ExpenseCode()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void ExpenseCode_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            E_DTO.Id = 2;
            DS = E_DAO.ExpenseCodeDB(E_DTO);
            GV_List.DataSource = DS.Tables[0];

            LedgerAccount_Cmbx.DataSource = DS.Tables[1];
            LedgerAccount_Cmbx.ValueMember = "LedgerNumber";
            LedgerAccount_Cmbx.DisplayMember = "LedgerAccount";
        }
        
        private void DDL_AccountNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (LedgerAccount_Cmbx.SelectedValue.ToString() != "")
            {
                E_DTO.LedgerAccount = Convert.ToInt64(LedgerAccount_Cmbx.SelectedValue);
                E_DTO.Id = 3;
                DS = E_DAO.ExpenseCodeDB(E_DTO);
                LedgerName_Txt.Text = DS.Tables[0].Rows[0]["LedgerName"].ToString();
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
                        E_DTO.ExpenseCodeNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ExpenseCodeNumber"].Value);
                        E_DTO.Id = 4;
                        DS = E_DAO.ExpenseCodeDB(E_DTO);
                        MessageBox.Show(Alert.Delete());
                        Clear();
                        GetData();
                    }
                    catch
                    {
                        MessageBox.Show("This record aleady linked same table or another table aso cannot possible to delete");
                    }
                }
            }

            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                E_DTO.ExpenseCodeNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_ExpenseCodeNumber"].Value);
                E_DTO.Id = 5;
                DS = E_DAO.ExpenseCodeDB(E_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    LedgerAccount_Cmbx.DataSource = DS.Tables[1];
                    LedgerAccount_Cmbx.ValueMember = "LedgerNumber";
                    LedgerAccount_Cmbx.DisplayMember = "LedgerAccount";

                    ExpenseCodeNumber_Txt.Text = DS.Tables[0].Rows[0]["ExpenseCodeNumber"].ToString();
                    ExpenseCode_Txt_Special.Text = DS.Tables[0].Rows[0]["ExpenseCode"].ToString();
                    EC_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["EC_Description"].ToString();
                    LedgerAccount_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                    LedgerName_Txt.Text = DS.Tables[0].Rows[0]["LedgerName"].ToString();

                    ExpenseCode_Txt_Special.Focus();

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
                    E_DTO.ExpenseCode = ExpenseCode_Txt_Special.Text;
                    E_DTO.EC_Description = EC_Description_Txt_Special.Text;
                    E_DTO.LedgerAccount = Convert.ToInt64(LedgerAccount_Cmbx.SelectedValue);
                    E_DTO.CreatorCode = 1;
                    E_DTO.Rights = 1;
                    E_DTO.Id = 1;
                    DS = E_DAO.ExpenseCodeDB(E_DTO);
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

            ExpenseCode_Txt_Special.Focus();

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
                if (Duplicate(ExpenseCodeNumber_Txt.Text))
                {
                    E_DTO.ExpenseCodeNumber = Convert.ToInt64(ExpenseCodeNumber_Txt.Text);
                    E_DTO.ExpenseCode = ExpenseCode_Txt_Special.Text;
                    E_DTO.EC_Description = EC_Description_Txt_Special.Text;
                    E_DTO.LedgerAccount = Convert.ToInt64(LedgerAccount_Cmbx.SelectedValue);
                    E_DTO.CreatorCode =1;
                    E_DTO.Rights =1;
                    E_DTO.Id = 6;
                    DS = E_DAO.ExpenseCodeDB(E_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();                   
                }
            }
        }

        private void ExpenseCode_Txt_Leave(object sender, EventArgs e)
        {
            Duplicate(ExpenseCodeNumber_Txt.Text);
        }
        Boolean Duplicate(String ExpenseCodeNumber)
        {
            if (ExpenseCodeNumber.Trim().Length > 0)
            {
                E_DTO.ExpenseCodeNumber = Convert.ToInt32(ExpenseCodeNumber);
                E_DTO.ExpenseCode = ExpenseCode_Txt_Special.Text;
                E_DTO.Id = 8;
                DS = E_DAO.ExpenseCodeDB(E_DTO);
            }
            else
            {
                E_DTO.ExpenseCode = ExpenseCode_Txt_Special.Text;
                E_DTO.Id = 7;
                DS = E_DAO.ExpenseCodeDB(E_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                ExpenseCode_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
