using ERP.ControlMaster.CommonFeatures;
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
using Telerik.WinControls.UI;

namespace ERP.Purchase.Tax.Master
{
    public partial class WithholdTax : Form
    {
        WithholdTax_DTO WHT_DTO = new WithholdTax_DTO();
        WithholdTax_DAO WHT_DAO = new WithholdTax_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public WithholdTax()
        {
            InitializeComponent();
            Eve.FormController(this);

            RGV_List.CommandCellClick += RGV_List_CommandCellClick;
            RGV_List.CellFormatting += RGV_List_CellFormatting;

            WH_TaxCode_Txt_Special.Leave += WH_TaxCode_Txt_Special_Leave;

            Btn_Save.Click += Btn_Save_Click;
            Btn_Clear.Click += Btn_Clear_Click;
            Btn_Update.Click += Btn_Update_Click;
        }

        private void WithHoldTax_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            WHT_DTO.Id = 2;
            DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
            RGV_List.DataSource = DS.Tables[0];

            WH_TaxCategory_Cmbx.DataSource = DS.Tables[1];
            WH_TaxCategory_Cmbx.ValueMember = "Number";
            WH_TaxCategory_Cmbx.DisplayMember = "Category";

            WH_TaxType_Cmbx.DataSource = DS.Tables[2];
            WH_TaxType_Cmbx.ValueMember = "Number";
            WH_TaxType_Cmbx.DisplayMember = "Type";

            WH_TaxImpact_Cmbx.DataSource = DS.Tables[3];
            WH_TaxImpact_Cmbx.ValueMember = "Number";
            WH_TaxImpact_Cmbx.DisplayMember = "Impact";
        }
        
        private void RGV_List_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            GridViewRowInfo currentRow = RGV_List.CurrentRow;

            if (RGV_List.Columns[e.ColumnIndex].Name == "Delete_Cmd")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        WHT_DTO.WithholdtaxNumber = Convert.ToInt64(currentRow.Cells["GV_WithholdtaxNumber"].Value);
                        WHT_DTO.Id = 3;
                        DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
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
            else if (RGV_List.Columns[e.ColumnIndex].Name == "Edit_Cmd")
            {
                WHT_DTO.WithholdtaxNumber = Convert.ToInt64(currentRow.Cells["GV_WithholdtaxNumber"].Value);
                WHT_DTO.Id = 4;
                DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    WithholdtaxNumber_Txt.Text = DS.Tables[0].Rows[0]["WithholdtaxNumber"].ToString();
                    WH_TaxCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxCategory"].ToString();
                    WH_TaxType_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxType"].ToString();
                    WH_TaxCode_Txt_Special.Text = DS.Tables[0].Rows[0]["WH_TaxCode"].ToString();
                    WH_TaxDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["WH_TaxDescription"].ToString();
                    WH_TaxImpact_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["WH_TaxImpact"].ToString();

                    WH_TaxCode_Txt_Special.Focus();

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
        private void RGV_List_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;
            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
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
                    WHT_DTO.TaxCategory = Convert.ToInt64(WH_TaxCategory_Cmbx.SelectedValue);
                    WHT_DTO.TaxType = Convert.ToInt64(WH_TaxType_Cmbx.SelectedValue);
                    WHT_DTO.WH_TaxCode = WH_TaxCode_Txt_Special.Text;
                    WHT_DTO.WH_TaxDescription = WH_TaxDescription_Txt_Special.Text;
                    WHT_DTO.WH_TaxImpact = Convert.ToInt64(WH_TaxImpact_Cmbx.SelectedValue);
                    WHT_DTO.CreatorCode = 1;
                    WHT_DTO.Rights = 1;
                    WHT_DTO.Id = 1;
                    DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
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

            WH_TaxCode_Txt_Special.Focus();

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
                if (Duplicate(WithholdtaxNumber_Txt.Text))
                {
                    WHT_DTO.WithholdtaxNumber = Convert.ToInt64(WithholdtaxNumber_Txt.Text);
                    WHT_DTO.TaxCategory = Convert.ToInt64(WH_TaxCategory_Cmbx.SelectedValue);
                    WHT_DTO.TaxType = Convert.ToInt64(WH_TaxType_Cmbx.SelectedValue);
                    WHT_DTO.WH_TaxCode = WH_TaxCode_Txt_Special.Text;
                    WHT_DTO.WH_TaxDescription = WH_TaxDescription_Txt_Special.Text;
                    WHT_DTO.WH_TaxImpact = Convert.ToInt64(WH_TaxImpact_Cmbx.SelectedValue);
                    WHT_DTO.CreatorCode = 1;
                    WHT_DTO.Rights = 1;
                    WHT_DTO.Id = 5;
                    DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }
        private void WH_TaxCode_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(WithholdtaxNumber_Txt.Text));
        }        
        Boolean Duplicate(String WithholdtaxNumber)
        {
            if (WithholdtaxNumber.Length > 0)
            {
                WHT_DTO.WithholdtaxNumber = Convert.ToInt64(WithholdtaxNumber);
                WHT_DTO.WH_TaxCode = WH_TaxCode_Txt_Special.Text;
                WHT_DTO.Id = 7;
                DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
            }
            else
            {
                WHT_DTO.WH_TaxCode = WH_TaxCode_Txt_Special.Text;
                WHT_DTO.Id = 6;
                DS = WHT_DAO.WithholdTaxDB(WHT_DTO);
            }   

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                WH_TaxCode_Txt_Special.Clear();
                WH_TaxCode_Txt_Special.Focus();
                return false;
            }
            return true;           
        }
    }
}
