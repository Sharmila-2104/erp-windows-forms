using ERP.ControlMaster.Alert;
using ERP.ControlMaster.Theme;
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

namespace ERP.Purchase.Tax.Master
{
    public partial class WithHoldTaxAssignAdd : Form
    {
        WithHoldTaxAssign_DAO WTA_DAO = new WithHoldTaxAssign_DAO();
        WithHoldTaxAssign_DTO WTA_DTO = new WithHoldTaxAssign_DTO();

        Alerts Alert = new Alerts();
        ThemeColor Theme = new ThemeColor();
        Events Eve = new Events();
        Validation V = new Validation();

        WithHoldTaxAssign List = new WithHoldTaxAssign();

        DataSet DS = new DataSet();
        Int64 Code = 0;

        public WithHoldTaxAssignAdd()
        {
            InitializeComponent();
        }
        public WithHoldTaxAssignAdd(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
        }

        private void WithHoldTaxAssignAdd_Load(object sender, EventArgs e)
        {
            if (Code == 0)
            {
                WTA_DTO.Id = 6;
                DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);

                Ddl_AssesseNumber.DataSource = DS.Tables[0];
                Ddl_AssesseNumber.ValueMember = "Number";
                Ddl_AssesseNumber.DisplayMember = "Nature";

                Ddl_TaxNumber.DataSource = DS.Tables[1];
                Ddl_TaxNumber.ValueMember = "Number";
                Ddl_TaxNumber.DisplayMember = "Include";

                Ddl_LedgerNumber.DataSource = DS.Tables[2];
                Ddl_LedgerNumber.ValueMember = "Number";
                Ddl_LedgerNumber.DisplayMember = "Ledger";

                GV_WithHoldTaxAssign_D.Columns["DeleteColumn"].Visible = false;
                Btn_Save.Visible = true;
                Btn_Update.Visible = false;
                Btn_Clear.Visible = true;
            }
            else
            {
                Btn_Save.Visible = false;
                Btn_Update.Visible = true;
                Btn_Clear.Visible = false;
                GetData(Code);
            }
        }

        void GetData(Int64 Number)
        {
            WTA_DTO.Number = Number;
            WTA_DTO.Id = 2;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
            if (DS.Tables[0].Rows.Count > 0)
            {
                Txt_Code.Text = DS.Tables[0].Rows[0]["Code"].ToString();
                Txt_Description.Text = DS.Tables[0].Rows[0]["Description"].ToString();
            }

            WTA_DTO.AssignNumber = Number;
            WTA_DTO.Id = 7;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
            if (DS.Tables[0].Rows.Count > 0)
            {
                Ddl_AssesseNumber.DataSource = DS.Tables[1];
                Ddl_AssesseNumber.ValueMember = "Number";
                Ddl_AssesseNumber.DisplayMember = "Nature";

                Ddl_TaxNumber.DataSource = DS.Tables[2];
                Ddl_TaxNumber.ValueMember = "Number";
                Ddl_TaxNumber.DisplayMember = "Include";

                Ddl_LedgerNumber.DataSource = DS.Tables[3];
                Ddl_LedgerNumber.ValueMember = "Number";
                Ddl_LedgerNumber.DisplayMember = "Ledger";

                GV_WithHoldTaxAssign_D.DataSource = DS.Tables[0];
            }

            for (int i = 0; i < GV_WithHoldTaxAssign_D.Rows.Count; i++)
            {

                if (GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Number"].Value == null)
                {
                    WTA_DTO.Id = 6;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);

                    Ddl_AssesseNumber.DataSource = DS.Tables[0];
                    Ddl_AssesseNumber.ValueMember = "Number";
                    Ddl_AssesseNumber.DisplayMember = "Nature";

                    Ddl_TaxNumber.DataSource = DS.Tables[1];
                    Ddl_TaxNumber.ValueMember = "Number";
                    Ddl_TaxNumber.DisplayMember = "Include";

                    Ddl_LedgerNumber.DataSource = DS.Tables[2];
                    Ddl_LedgerNumber.ValueMember = "Number";
                    Ddl_LedgerNumber.DisplayMember = "Ledger";
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(Txt_Code.Text))
            //{
            //    Txt_Code.Focus();
            //    MessageBox.Show("Tax Code is Required");
            //}
            //else if (String.IsNullOrEmpty(Txt_Description.Text))
            //{
            //    Txt_Description.Focus();
            //    MessageBox.Show("Description is Required");
            //}

            TextBox[] Textbox = { Txt_Code, Txt_Description };
            if (V.ValidTexBox(Textbox))
            {
            }

            else
            {
                WTA_DTO.Code = Txt_Code.Text;
                WTA_DTO.Description = Txt_Description.Text;
                WTA_DTO.CreatorCode = 1;
                WTA_DTO.Id = 1;
                DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);

                for (int i = 0; i < GV_WithHoldTaxAssign_D.Rows.Count - 1; i++)
                {
                    WTA_DTO.AssesseNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Ddl_AssesseNumber"].Value.ToString());
                    WTA_DTO.FromDate = Convert.ToInt32(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_FromDate"].Value.ToString());
                    WTA_DTO.ToDate = Convert.ToInt32(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_ToDate"].Value.ToString());
                    WTA_DTO.Single = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Single"].Value.ToString());
                    WTA_DTO.Aggregate = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Aggregate"].Value.ToString());
                    WTA_DTO.TaxNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["DDL_TaxNumber"].Value.ToString());
                    WTA_DTO.Percentage = Convert.ToDouble(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Percentage"].Value.ToString());
                    WTA_DTO.Pan = Convert.ToDouble(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Pan"].Value.ToString());
                    WTA_DTO.LedgerNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["DDL_LedgerNumber"].Value.ToString());
                    WTA_DTO.Id = 5;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                }
                Clear();
                MessageBox.Show(Alert.Save());
            }

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            List.Show();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            TextBox[] Textbox = { Txt_Code, Txt_Description };
            if (V.ValidTexBox(Textbox))
            {
            }
            else
            {
                WTA_DTO.Code = Txt_Code.Text;
                WTA_DTO.Description = Txt_Description.Text;
                WTA_DTO.Id = 3;
                DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
               
                //Clear();
                //Hide();
                //List.Show();

                String Code = "";
                for (int i = 0; i < GV_WithHoldTaxAssign_D.Rows.Count - 1; i++)
                {
                    if (GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Number"].Value != null)
                    {
                        Code = Convert.ToString(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Number"].Value.ToString());
                    }
                    WTA_DTO.AssesseNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Ddl_AssesseNumber"].Value.ToString());
                    WTA_DTO.FromDate = Convert.ToInt32(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_FromDate"].Value.ToString());
                    WTA_DTO.ToDate = Convert.ToInt32(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_ToDate"].Value.ToString());
                    WTA_DTO.Single = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Single"].Value.ToString());
                    WTA_DTO.Aggregate = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Aggregate"].Value.ToString());
                    WTA_DTO.TaxNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["DDL_TaxNumber"].Value.ToString());
                    WTA_DTO.Percentage = Convert.ToDouble(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Percentage"].Value.ToString());
                    WTA_DTO.Pan = Convert.ToDouble(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Pan"].Value.ToString());
                    WTA_DTO.LedgerNumber = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["DDL_LedgerNumber"].Value.ToString());

                    if (Code == null || Code == "")
                    {
                        WTA_DTO.Id = 5;
                    }
                    else
                    {
                        WTA_DTO.Number = Convert.ToInt64(GV_WithHoldTaxAssign_D.Rows[i].Cells["Txt_Number"].Value.ToString());
                        WTA_DTO.Id = 8;
                    }
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                }
                MessageBox.Show("Updated Successfully");
            }
        }

        void Clear()
        {
            Txt_Code.Clear();
            Txt_Description.Clear();
            GV_WithHoldTaxAssign_D.Rows.Clear();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GV_WithHoldTaxAssign_D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_WithHoldTaxAssign_D.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    WTA_DTO.Number = Convert.ToInt32(GV_WithHoldTaxAssign_D.Rows[e.RowIndex].Cells["Txt_Number"].Value);
                    WTA_DTO.Id = 9;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                    GetData(Code);
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
    }
}
