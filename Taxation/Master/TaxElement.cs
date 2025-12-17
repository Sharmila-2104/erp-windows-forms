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
    public partial class TaxElement : Form
    {
        TaxElement_DTO TE_DTO = new TaxElement_DTO();
        TaxElement_DAO TE_DAO = new TaxElement_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        
        public TaxElement()
        {
            InitializeComponent();
            Eve.FormController(this);

            COA_Cmbx.SelectionChangeCommitted += COA_Cmbx_Cmbx_SelectionChangeCommitted;
            RGV_List.CellFormatting += RGV_List_CellFormatting;
            RGV_List.CommandCellClick += RGV_List_CommandCellClick;

            Btn_Save.Click += Btn_Save_Click;
            Btn_Clear.Click += Btn_Clear_Click;
            Btn_Update.Click += Btn_Update_Click;

            TaxElement_Txt_Special.Leave += TaxElement_Txt_Special_Leave;
        }

        void GetData()
        {
            TE_DTO.Id = 2;
            DS = TE_DAO.TaxElementDB(TE_DTO);
            RGV_List.DataSource = DS.Tables[0];

            TaxCategory_Cmbx.DataSource = DS.Tables[1];
            TaxCategory_Cmbx.ValueMember = "Number";
            TaxCategory_Cmbx.DisplayMember = "Category";

            TaxType_Cmbx.DataSource = DS.Tables[2];
            TaxType_Cmbx.ValueMember = "Number";
            TaxType_Cmbx.DisplayMember = "Type";

            COA_Cmbx.DataSource = DS.Tables[3];
            COA_Cmbx.ValueMember = "LedgerNumber";
            COA_Cmbx.DisplayMember = "LedgerAccount";
        }
        private void TaxElement_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }

        private void COA_Cmbx_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (COA_Cmbx.SelectedValue.ToString() != "")
            {
                TE_DTO.COA = Convert.ToInt64(COA_Cmbx.SelectedValue);
                TE_DTO.Id = 8;
                DS = TE_DAO.TaxElementDB(TE_DTO);
                LedgerName_Txt.Text = DS.Tables[0].Rows[0]["LedgerName"].ToString();
            }
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
                        TE_DTO.TaxElementNumber = Convert.ToInt64(currentRow.Cells["GV_TaxElementNumber"].Value);
                        TE_DTO.Id = 3;
                        DS = TE_DAO.TaxElementDB(TE_DTO);
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
                TE_DTO.TaxElementNumber = Convert.ToInt64(currentRow.Cells["GV_TaxElementNumber"].Value);
                TE_DTO.Id = 4;
                DS = TE_DAO.TaxElementDB(TE_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    TaxCategory_Cmbx.DataSource = DS.Tables[1];
                    TaxCategory_Cmbx.ValueMember = "Number";
                    TaxCategory_Cmbx.DisplayMember = "Category";

                    TaxType_Cmbx.DataSource = DS.Tables[2];
                    TaxType_Cmbx.ValueMember = "Number";
                    TaxType_Cmbx.DisplayMember = "Type";

                    COA_Cmbx.DataSource = DS.Tables[3];
                    COA_Cmbx.ValueMember = "LedgerNumber";
                    COA_Cmbx.DisplayMember = "LedgerAccount";

                    TaxElementNumber_Txt.Text = DS.Tables[0].Rows[0]["TaxElementNumber"].ToString();
                    TaxCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxCategory"].ToString();
                    TaxType_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxType"].ToString();
                    TaxElement_Txt_Special.Text = DS.Tables[0].Rows[0]["TaxElement"].ToString();
                    ElementDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["ElementDescription"].ToString();
                    COA_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["COA"].ToString();
                    LedgerName_Txt.Text = DS.Tables[0].Rows[0]["LedgerName"].ToString();

                    TaxElement_Txt_Special.Focus();

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
                    TE_DTO.TaxCategory = Convert.ToInt64(TaxCategory_Cmbx.SelectedValue);
                    TE_DTO.TaxType = Convert.ToInt64(TaxType_Cmbx.SelectedValue);
                    TE_DTO.TaxElement = TaxElement_Txt_Special.Text;
                    TE_DTO.ElementDescription = ElementDescription_Txt_Special.Text;
                    TE_DTO.COA = Convert.ToInt64(COA_Cmbx.SelectedValue);
                    TE_DTO.CreatorCode = 1;
                    TE_DTO.Rights = 1;
                    TE_DTO.Id = 1;
                    DS = TE_DAO.TaxElementDB(TE_DTO);
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

            TaxElement_Txt_Special.Focus();

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
                if (Duplicate(TaxElementNumber_Txt.Text))
                {
                    TE_DTO.TaxElementNumber = Convert.ToInt64(TaxElementNumber_Txt.Text);
                    TE_DTO.TaxCategory = Convert.ToInt64(TaxCategory_Cmbx.SelectedValue);
                    TE_DTO.TaxType = Convert.ToInt64(TaxType_Cmbx.SelectedValue);
                    TE_DTO.TaxElement = TaxElement_Txt_Special.Text;
                    TE_DTO.ElementDescription = ElementDescription_Txt_Special.Text;
                    TE_DTO.COA = Convert.ToInt64(COA_Cmbx.SelectedValue);
                    TE_DTO.CreatorCode = 1;
                    TE_DTO.Rights = 1;
                    TE_DTO.Id = 5;
                    DS = TE_DAO.TaxElementDB(TE_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void TaxElement_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(TaxElementNumber_Txt.Text));
        }
        Boolean Duplicate(String TaxElementNumber)
        {
            if (TaxElementNumber.Length > 0)
            {
                TE_DTO.TaxElementNumber = Convert.ToInt64(TaxElementNumber);
                TE_DTO.TaxElement = TaxElement_Txt_Special.Text;
                TE_DTO.Id = 7;
                DS = TE_DAO.TaxElementDB(TE_DTO);
            }
            else
            {
                TE_DTO.TaxElement = TaxElement_Txt_Special.Text;
                TE_DTO.Id = 6;
                DS = TE_DAO.TaxElementDB(TE_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                TaxElement_Txt_Special.Clear();
                TaxElement_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
