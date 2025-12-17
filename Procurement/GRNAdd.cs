using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Tax.Master;
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
using System.Xml.Linq;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;
using Telerik.WinControls.VirtualKeyboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP.Procurement
{
    public partial class GRNAdd : Form
    {
        GRN_DTO GRN_DTO = new GRN_DTO();
        GRN_DAO GRN_DAO = new GRN_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        Validation Va = new Validation();
        DataSet DS = new DataSet();

        public GRNAdd()
        {
            InitializeComponent();
            Eve.FormController(this);

            GRN_Date_Cal.Visible = false;
            CalenderPic.Click += new EventHandler(CalenderPic_Click);
            GRN_Date_Cal.DateSelected += new DateRangeEventHandler(GRN_Date_Cal_DateSelected);
            GRN_Date_dt.Enter += new EventHandler(GRN_Date_dt_Enter);

            PurchaseInvoiceDate_Cal.Visible = false;
            CalPic.Click += new EventHandler(CalPic_Click);
            PurchaseInvoiceDate_Cal.DateSelected += new DateRangeEventHandler(PurchaseInvoiceDate_Cal_DateSelected);
            PurchaseInvoiceDate_dt.Enter += new EventHandler(PurchaseInvoiceDate_dt_Enter);

            PurchaseInvoiceDate_Cal.Visible = false;

            VendorName_Cmbx.SelectionChangeCommitted += new EventHandler(VendorName_Cmbx_SelectionChangeCommitted);
            GST_TaxCluster_Cmbx.SelectionChangeCommitted += new EventHandler(GST_TaxCluster_Cmbx_SelectionChangeCommitted);
            WH_TaxCode_Cmbx.SelectionChangeCommitted += new EventHandler(WH_TaxCode_Cmbx_SelectionChangeCommitted);

            PurchaseOrder.Click += new EventHandler(PurchaseOrder_Click);
            POPull.Click += new EventHandler(POPull_Click);
            ItemPull.Click += new EventHandler(ItemPull_Click);
            ItemPoPull.Click += new EventHandler(ItemPoPull_Click);
            ItemPOClose.Click += new EventHandler(ItemPOClose_Click);
            Btn_Save.Click += new EventHandler(Btn_Save_Click);
            Btn_Clear.Click += new EventHandler(Btn_Clear_Click);


            GRNDirect.CheckedChanged += new EventHandler(GRNDirect_CheckedChanged);
            GRNPOItem.CheckedChanged += new EventHandler(GRNPOItem_CheckedChanged);
            GRNItemPO.CheckedChanged += new EventHandler(GRNItemPO_CheckedChanged);

            RGV_Item.CellClick += new GridViewCellEventHandler(RGV_Item_CellClick);
            RGV_Item.CellEditorInitialized += new GridViewCellEventHandler(RGV_Item_CellEditorInitialized);
            RGV_Item.ViewCellFormatting += new CellFormattingEventHandler(RGV_Item_ViewCellFormatting);

            RGV_POItem.CellEditorInitialized += new GridViewCellEventHandler(RGV_POItem_CellEditorInitialized);
            RGV_POItem.UserDeletingRow += new GridViewRowCancelEventHandler(RGV_POItem_UserDeletingRow);
            RGV_POItem.UserDeletedRow += new GridViewRowEventHandler(RGV_POItem_UserDeletedRow);
            
            RGV_ItemPO.ValueChanged += new EventHandler(RGV_ItemPO_ValueChanged);
            
            GV_ItemToPo.ValueChanged += new EventHandler(GV_ItemToPo_ValueChanged);

        }
        private void GRNAdd_Load(object sender, EventArgs e)
        {
            GRN_Number_Txt.Focus();

            Btn_Save.Visible = true;
            Btn_Clear.Visible = true;

            GRN_DTO.Id = 1;
            DS = GRN_DAO.GRNDB(GRN_DTO);

            VendorName_Cmbx.DataSource = DS.Tables[0];
            VendorName_Cmbx.DisplayMember = "VendorName";
            VendorName_Cmbx.ValueMember = "VendorNumber";

            MaterialSegregation_Cmbx.DataSource = DS.Tables[1];
            MaterialSegregation_Cmbx.DisplayMember = "Segregation";
            MaterialSegregation_Cmbx.ValueMember = "Number";

            //RGV Iteam
            GridViewComboBoxColumn GV_ItemCode = (GridViewComboBoxColumn)RGV_Item.Columns["GV_ItemCode_Cmbx"];
            GV_ItemCode.DataSource = DS.Tables[2];
            GV_ItemCode.DisplayMember = "ItemCode";
            GV_ItemCode.ValueMember = "ItemNumber";

            radDropDownList1.DataSource = DS.Tables[0];
            radDropDownList1.DisplayMember = "VendorName";
            radDropDownList1.ValueMember = "VendorNumber";
            radDropDownList1.AutoCompleteMode = AutoCompleteMode.Suggest;

            GridViewComboBoxColumn GV_UoM_Cmbx = (GridViewComboBoxColumn)RGV_Item.Columns["GV_UoM_Cmbx"];
            GV_UoM_Cmbx.DataSource = DS.Tables[3];
            GV_UoM_Cmbx.DisplayMember = "UnitCode";
            GV_UoM_Cmbx.ValueMember = "UnitNumber";
            RGV_Item.CellEditorInitialized += new GridViewCellEventHandler(RGV_Item_CellEditorInitialized);
            RGV_Item.Rows.AddNew();

            GridViewSummaryItem Item = new GridViewSummaryItem("GV_ItemCode_Txt", " Total ", GridAggregateFunction.Sum);
            GridViewSummaryItem Qty = new GridViewSummaryItem("GV_Qty_Txt", " {0} ", GridAggregateFunction.Sum);
            GridViewSummaryItem Amount = new GridViewSummaryItem("GV_Amount_Txt", " {0} ", GridAggregateFunction.Sum);
            GridViewSummaryItem Expense = new GridViewSummaryItem("GV_ExpenseValue_Txt", " {0} ", GridAggregateFunction.Sum);
            GridViewSummaryItem Tax = new GridViewSummaryItem("GV_GST_TaxAmount_Txt", " {0} ", GridAggregateFunction.Sum);
            GridViewSummaryItem WH = new GridViewSummaryItem("GV_WH_TaxAmount_Txt", " {0} ", GridAggregateFunction.Sum);
            RGV_Item.MasterTemplate.SummaryRowsBottom.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { Item, Qty, Amount, Expense, Tax, WH }));
            RGV_Item.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
            RGV_Item.MasterView.SummaryRows[0].IsPinned = true;
            RGV_Item.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;

            RGV_Item.Visible = false;
            RGV_POItem.Visible = false;
            RGV_ItemPO.Visible = false;

            RGV_POItem.MasterTemplate.SummaryRowsBottom.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { Item, Qty, Amount, Expense, Tax, WH }));
            RGV_POItem.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
            RGV_POItem.MasterView.SummaryRows[0].IsPinned = true;
            RGV_POItem.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;

            RGV_ItemPO.MasterTemplate.SummaryRowsBottom.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { Item, Qty, Amount, Expense, Tax, WH }));
            RGV_ItemPO.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
            RGV_ItemPO.MasterView.SummaryRows[0].IsPinned = true;
            RGV_ItemPO.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;

            RGV_ItemPO.Rows.AddNew();

            Clear();
            CalculatesTotal();
            OnGRNNumber(0);
        }
        void OnGRNNumber(Int32 PDate)
        {
            if (PDate == 0)
            {
                GRN_DTO.Id = 0;
            }
            else
            {
                GRN_DTO.GRN_Date = PDate;
                GRN_DTO.Id = 14;
            }
            DS = GRN_DAO.GRNDB(GRN_DTO);
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[1].Rows.Count > 0)
            {
                Int32 Number = 0;
                Int32 Order = 0;
                String Prefix = "";
                String Surfix = "";
                String Prefil = "";
                String OrderNum = "";

                if (DS.Tables[0].Rows.Count > 0)
                {
                    Order = Convert.ToInt32(DS.Tables[0].Rows[0]["GRNMethod"].ToString());
                }
                if (Order == 2)
                {
                    if (DS.Tables[2].Rows.Count > 0)
                    {
                        Prefix = DS.Tables[2].Rows[0]["Frequency"].ToString();
                    }
                    if (DS.Tables[3].Rows.Count > 0)
                    {
                        Surfix = DS.Tables[3].Rows[0]["Frequency"].ToString();
                    }

                    if (DS.Tables[4].Rows.Count > 0)
                    {
                        Int32 OrNum = Convert.ToInt32(DS.Tables[4].Rows[0]["StartingNumber"].ToString());
                        Int32 RNumber = Convert.ToInt32(DS.Tables[4].Rows[0]["Number"].ToString());
                        if (DS.Tables[1].Rows.Count > 0)
                        {
                            DateTime RDate = Convert.ToDateTime(DS.Tables[1].Rows[0]["Date"]);
                            Int32 GNumber = Convert.ToInt32(DS.Tables[1].Rows[0]["Number"].ToString());
                            Int32 RZero = Convert.ToInt32(DS.Tables[1].Rows[0]["PrefilZero"].ToString());
                            Int32 RDigit = Convert.ToInt32(DS.Tables[1].Rows[0]["NumberofDigits"].ToString());
                            Int32 RFre = Convert.ToInt32(DS.Tables[1].Rows[0]["Frequency"].ToString());

                            if (RFre == 4)
                            {
                                Number = OrNum + 1;
                                if (RZero == 2)
                                {
                                    Prefil = "D" + RDigit;
                                }
                            }
                            else if (RFre == 5)
                            {
                                Number = OrNum + 1;
                                if (RZero == 2)
                                {
                                    Prefil = "D" + RDigit;
                                }
                            }

                            GRNGNumber.Text = GNumber.ToString();
                            GRNRNumber.Text = RNumber.ToString();
                        }
                    }
                    else
                    {
                        if (DS.Tables[1].Rows.Count > 0)
                        {
                            DateTime RDate = Convert.ToDateTime(DS.Tables[1].Rows[0]["Date"]);
                            Int32 GNumber = Convert.ToInt32(DS.Tables[1].Rows[0]["Number"].ToString());
                            Int32 RNumber = Convert.ToInt32(DS.Tables[1].Rows[0]["StartingNumber"].ToString());
                            Int32 RZero = Convert.ToInt32(DS.Tables[1].Rows[0]["PrefilZero"].ToString());
                            Int32 RDigit = Convert.ToInt32(DS.Tables[1].Rows[0]["NumberofDigits"].ToString());
                            Int32 RFre = Convert.ToInt32(DS.Tables[1].Rows[0]["Frequency"].ToString());
                            Int32 Res = 0;


                            if (RFre == 4)
                            {
                                Number = RNumber;
                                if (RZero == 2)
                                {
                                    Prefil = "D" + RDigit;
                                }
                            }
                            else if (RFre == 5)
                            {
                                Number = RNumber;
                                if (RZero == 2)
                                {
                                    Prefil = "D" + RDigit;
                                }
                            }

                            GRNGNumber.Text = GNumber.ToString();
                        }
                    }
                    OrderNum = Prefix + "" + Number.ToString(Prefil) + "" + Surfix;

                    GRN_Number_Txt.Text = OrderNum;
                    GRN_Number_Txt.Enabled = false;
                }
                if (PDate == 0)
                {
                    GRN_Date_dt.Text = DateTime.Now.ToString("dd-MM-yyyy");
                }
            }
            else
            {
                if (PDate == 0)
                {
                    MessageBox.Show("GRN number not assigned");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("GRN number not assigned for given date");
                    GRN_Date_dt.Focus();
                    GRN_Number_Txt.Clear();
                }
            }
        }

        private void CalenderPic_Click(object sender, EventArgs e)
        {
            GRN_Date_Cal.Visible = true;
            CalPic.Visible = false;
            GRN_Date_Cal.BringToFront();
        }
        private void GRN_Date_Cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            GRN_Date_dt.Text = GRN_Date_Cal.SelectionStart.ToShortDateString();
            GRN_Date_Cal.Visible = false;
            CalPic.Visible = true;
            OnGRNNumber(Convert.ToInt32(Convert.ToDateTime(GRN_Date_dt.Text).ToString("yyyyMMdd")));
        }
        private void GRN_Date_dt_Enter(object sender, EventArgs e)
        {
            try
            {
                GRN_Date_dt.Text = Convert.ToDateTime(GRN_Date_dt.Text.ToString()).ToString("dd-MM-yyyy");
                OnGRNNumber(Convert.ToInt32(Convert.ToDateTime(GRN_Date_dt.Text).ToString("yyyyMMdd")));
            }
            catch
            {
                WH_TaxCode_Cmbx.SelectedValue = -1;
            }
        }
       

        private void CalPic_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDate_Cal.Visible = true;
        }
        private void PurchaseInvoiceDate_Cal_Leave(object sender, EventArgs e)
        {
            PurchaseInvoiceDate_Cal.Visible = false;
        }
        private void PurchaseInvoiceDate_Cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            PurchaseInvoiceDate_dt.Text = PurchaseInvoiceDate_Cal.SelectionStart.ToShortDateString();
            PurchaseInvoiceDate_Cal.Visible = false;
            VendorName_Cmbx.Focus();
        }
        private void PurchaseInvoiceDate_dt_Enter(object sender, EventArgs e)
        {
            try
            {
                PurchaseInvoiceDate_dt.Text = Convert.ToDateTime(PurchaseInvoiceDate_dt.Text.ToString()).ToString("dd-MM-yyyy");
            }
            catch
            {
            }
        }


        private void VendorName_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (VendorName_Cmbx.SelectedValue != null)
            {
                GRN_DTO.VendorName = Convert.ToInt64(VendorName_Cmbx.SelectedValue);
                GRN_DTO.Id = 2;
                DS = GRN_DAO.GRNDB(GRN_DTO);
                Currency_Txt.Text = DS.Tables[0].Rows[0]["Currency"].ToString();

                GST_TaxCluster_Cmbx.DataSource = DS.Tables[1];
                GST_TaxCluster_Cmbx.DisplayMember = "TaxCluster";
                GST_TaxCluster_Cmbx.ValueMember = "TaxClusterNumber";
                GST_TaxCluster_Cmbx.SelectedIndex = -1;

                WH_TaxCode_Cmbx.DataSource = DS.Tables[2];
                WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";
                WH_TaxCode_Cmbx.ValueMember = "WithholdTaxNumber";
                WH_TaxCode_Cmbx.SelectedIndex = -1;
            }
        }
        private void WH_TaxCode_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(GRN_Date_dt.Text) == "")
            {
                MessageBox.Show("Please choose Grn Date.");
                GRN_Date_dt.Focus();
                WH_TaxCode_Cmbx.SelectedIndex = -1;

            }
            else if (Convert.ToString(GRN_Date_dt.Text) != "")
            {
                try
                {
                    GRN_Date_dt.Text = Convert.ToDateTime(GRN_Date_dt.Text.ToString()).ToString("dd-MM-yyyy");
                }
                catch
                {
                    MessageBox.Show("GRN Date is not in correct format");
                    GRN_Date_dt.Clear();
                    GRN_Date_dt.Focus();
                    WH_TaxCode_Cmbx.SelectedIndex = -1;
                }
            }
            else if (Convert.ToString(PurchaseInvoiceDate_dt.Text) == "")
            {
                MessageBox.Show("Please choose Purchase Invoice Date.");
                PurchaseInvoiceDate_dt.Focus();
                WH_TaxCode_Cmbx.SelectedIndex = -1;
            }
            else if (Convert.ToString(VendorName_Cmbx.Text) == "")
            {
                MessageBox.Show("Please choose vendor.");
                VendorName_Cmbx.Focus();
                WH_TaxCode_Cmbx.SelectedIndex = -1;
            }
            else if (Convert.ToString(GST_TaxCluster_Cmbx.Text) == "")
            {
                MessageBox.Show("Please choose Tax Cluster.");
                GST_TaxCluster_Cmbx.Focus();
                WH_TaxCode_Cmbx.SelectedIndex = -1;
            }
            else if (Convert.ToString(WH_TaxCode_Cmbx.Text) == "")
            {
                MessageBox.Show("Please choose Withhold Tax.");
                WH_TaxCode_Cmbx.Focus();
                WH_TaxCode_Cmbx.SelectedIndex = -1;
            }
        }
        private void GST_TaxCluster_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(PurchaseInvoiceDate_dt.Text) != "")
            {
                try
                {
                    PurchaseInvoiceDate_dt.Text = Convert.ToDateTime(PurchaseInvoiceDate_dt.Text.ToString()).ToString("dd-MM-yyyy");
                }
                catch
                {
                    MessageBox.Show("Purchase Invoice Date is not in correct format");
                    PurchaseInvoiceDate_dt.Clear();
                    PurchaseInvoiceDate_dt.Focus();
                    GST_TaxCluster_Cmbx.SelectedIndex = -1;
                }
            }
        }


        private void RGV_Item_CellClick(object sender, GridViewCellEventArgs e)
        {
            String Itemcode = Convert.ToString(RGV_Item.CurrentRow.Cells["GV_ItemCode_Cmbx"].Value);
            String UnitPrice = Convert.ToString(RGV_Item.CurrentRow.Cells["GV_UnitPrice_Txt"].Value);
            String Qty = Convert.ToString(RGV_Item.CurrentRow.Cells["GV_Qty_Txt"].Value);
            String ExpenseCode = Convert.ToString(RGV_Item.CurrentRow.Cells["GV_ExpenseCode_Cmbx"].Value);
            String ExpenseValue = Convert.ToString(RGV_Item.CurrentRow.Cells["GV_ExpenseValue_Txt"].Value);
            if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_ItemCode_Cmbx")
            {
                if (Convert.ToString(GRN_Date_dt.Text) == "")
                {
                    MessageBox.Show("Please choose Grn Date.");
                    GRN_Date_dt.Focus();
                }
                else if (Convert.ToString(PurchaseInvoiceDate_dt.Text) == "")
                {
                    MessageBox.Show("Please choose Purchase Invoice Date.");
                    PurchaseInvoiceDate_dt.Focus();
                }
                else if (Convert.ToString(VendorName_Cmbx.Text) == "")
                {
                    MessageBox.Show("Please choose vendor.");
                    VendorName_Cmbx.Focus();
                }
                else if (Convert.ToString(GST_TaxCluster_Cmbx.Text) == "")
                {
                    MessageBox.Show("Please choose Tax Cluster.");
                    GST_TaxCluster_Cmbx.Focus();
                }
                else if (Convert.ToString(WH_TaxCode_Cmbx.Text) == "")
                {
                    MessageBox.Show("Please choose Withhold Tax.");
                    WH_TaxCode_Cmbx.Focus();
                }
            }
            else if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_UoM_Cmbx")
            {
                if (Itemcode == "")
                {
                    MessageBox.Show("Please fill the ItemCode.");
                }
            }
            else if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_Qty_Txt")
            {
                if (Itemcode == "")
                {
                    MessageBox.Show("Please fill the ItemCode.");
                }
            }
            else if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_UnitPrice_Txt")
            {
                if (Itemcode == "")
                {
                    MessageBox.Show("Please fill the ItemCode.");
                }
                else if (Qty == "")
                {
                    MessageBox.Show("Please fill the Qty.");
                }
            }
            else if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_ExpenseCode_Cmbx")
            {
                if (Itemcode == "")
                {
                    MessageBox.Show("Please fill the ItemCode.");
                }
                else if (Qty == "")
                {
                    MessageBox.Show("Please fill the Qty.");
                }
                else if (UnitPrice == "")
                {
                    MessageBox.Show("Please fill the Unit price.");
                }
            }
            else if (RGV_Item.Columns[e.ColumnIndex].Name == "GV_ExpenseValue_Txt")
            {
                if (Itemcode == "")
                {
                    MessageBox.Show("Please fill the ItemCode.");
                }
                else if (Qty == "")
                {
                    MessageBox.Show("Please fill the Qty.");
                }
                else if (UnitPrice == "")
                {
                    MessageBox.Show("Please fill the Unit price.");
                }
                else if (ExpenseCode == "")
                {
                    MessageBox.Show("Please choose expense code.");
                }
            }
        }
        private void RGV_Item_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column is GridViewComboBoxColumn ComboBoxColumn)
            {
                RadDropDownListEditor ComboEditor = this.RGV_Item.ActiveEditor as RadDropDownListEditor;
                if (ComboEditor != null)
                {
                    RadDropDownListEditorElement ComboElement = (RadDropDownListEditorElement)ComboEditor.EditorElement;
                    ComboElement.Name = ComboBoxColumn.Name;
                    ComboElement.SelectedIndexChanged += ComboBoxEditor_SelectedIndexChanged;
                }
            }
            if (e.Column is GridViewTextBoxColumn TextColumn)
            {
                RadTextBoxEditor TextEditor = this.RGV_Item.ActiveEditor as RadTextBoxEditor;
                if (TextEditor != null)
                {
                    RadTextBoxEditorElement TextElement = (RadTextBoxEditorElement)TextEditor.EditorElement;
                    TextElement.Name = TextColumn.Name;
                    TextElement.TextChanged += new EventHandler(RGV_Txt_TextChanged);
                }
            }
        }
        private void RGV_Item_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo.Group == null && e.CellElement is GridSummaryCellElement)
            {
                Font totalRowsFont = new Font("Verdana", 10.0f, FontStyle.Bold);

                e.CellElement.TextAlignment = ContentAlignment.BottomRight;
                e.CellElement.Font = totalRowsFont;
            }
        }
        private void ComboBoxEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadDropDownListEditorElement DLE = ((RadDropDownListEditorElement)sender);
            if (DLE.Name == "GV_ItemCode_Cmbx")
            {
                if (DLE.SelectedIndex != -1)
                {
                    GridViewRowInfo currentRow = RGV_Item.CurrentRow;

                    GRN_DTO.ItemCode = Convert.ToInt64(DLE.SelectedValue);
                    GRN_DTO.WH_TaxCode = Convert.ToInt64(WH_TaxCode_Cmbx.SelectedValue);
                    GRN_DTO.VendorName = Convert.ToInt64(VendorName_Cmbx.SelectedValue);
                    GRN_DTO.GRN_Date = Convert.ToInt32(Convert.ToDateTime(GRN_Date_dt.Text).ToString("yyyyMMdd"));
                    GRN_DTO.Id = 4;
                    DS = GRN_DAO.GRNDB(GRN_DTO);

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        currentRow.Cells["GV_ItemDescription_Txt"].Value = DS.Tables[0].Rows[0]["ItemDescription"].ToString();
                        currentRow.Cells["GV_ItemGroup_Txt"].Value = DS.Tables[0].Rows[0]["ItemGroup"].ToString();

                        if (DS.Tables[1].Rows[0]["UnitCode"].ToString() != "")
                        {
                            //currentRow.Cells["GV_UoM_Cmbx"].Value = DS.Tables[1].Rows[0]["UnitCode"].ToString();
                        }

                        ((GridViewComboBoxColumn)currentRow.Cells["GV_ExpenseCode_Cmbx"].ColumnInfo).DataSource = DS.Tables[2]; 
                        ((GridViewComboBoxColumn)currentRow.Cells["GV_ExpenseCode_Cmbx"].ColumnInfo).DisplayMember = "ExpenseCode";
                        ((GridViewComboBoxColumn)currentRow.Cells["GV_ExpenseCode_Cmbx"].ColumnInfo).ValueMember = "ExpenseCodeNumber";

                        ((GridViewComboBoxColumn)currentRow.Cells["GV_HSN_Cmbx"].ColumnInfo).DataSource = DS.Tables[3];
                        ((GridViewComboBoxColumn)currentRow.Cells["GV_HSN_Cmbx"].ColumnInfo).DisplayMember = "HSN_Code";
                        ((GridViewComboBoxColumn)currentRow.Cells["GV_HSN_Cmbx"].ColumnInfo).ValueMember = "HSN_Number";
                    }

                    if (DS.Tables[5].Rows.Count > 0 && DS.Tables[6].Rows.Count > 0)
                    {
                        String Pan = Convert.ToString(DS.Tables[6].Rows[0]["Pan"]);
                        if (Pan.Trim() == "")
                        {
                            currentRow.Cells["GV_Percent_Txt"].Value = DS.Tables[5].Rows[0]["NON_PAN_TaxPercent"].ToString();
                        }
                        else
                        {
                            currentRow.Cells["GV_Percent_Txt"].Value = DS.Tables[5].Rows[0]["PAN_TaxPercent"].ToString();
                        }
                        currentRow.Cells["GV_WH_TaxCode_Txt"].Value = WH_TaxCode_Cmbx.Text;
                        currentRow.Cells["GV_WH_TaxNumber_Txt"].Value = WH_TaxCode_Cmbx.SelectedValue;
                    }
                    else
                    {
                        currentRow.Cells["GV_WH_TaxCode_Txt"].Value = WH_TaxCode_Cmbx.Text;
                        currentRow.Cells["GV_WH_TaxNumber_Txt"].Value = WH_TaxCode_Cmbx.SelectedValue;
                        currentRow.Cells["GV_Percent_Txt"].Value = 0;
                    }

                    CalculatesTotal();
                }
            }
            if (DLE.Name == "GV_HSN_Cmbx")
            {
                if (DLE.SelectedIndex != -1)
                {
                    GridViewRowInfo currentRow = RGV_Item.CurrentRow;

                    Double Percent = 0;
                    Double PanPercent = 0;
                    Double Amount = Convert.ToDouble(currentRow.Cells["GV_Amount_Txt"].Value);
                    Double Expense = Convert.ToDouble(currentRow.Cells["GV_ExpenseValue_Txt"].Value);

                    GRN_DTO.TaxCluster = Convert.ToInt64(GST_TaxCluster_Cmbx.SelectedValue);
                    GRN_DTO.HSN = Convert.ToInt64(DLE.SelectedValue);
                    GRN_DTO.PurchaseInvoiceDate = Convert.ToInt32(Convert.ToDateTime(PurchaseInvoiceDate_dt.Text).ToString("yyyyMMdd"));
                    GRN_DTO.Id = 5;
                    DS = GRN_DAO.GRNDB(GRN_DTO);

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        Percent = Convert.ToDouble(DS.Tables[0].Rows[0]["HSN_Percent"]);
                        PanPercent = Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value);

                        Double Total = (Amount + Expense) * Percent / 100;
                        Double PanAmount = (Amount + Expense) * PanPercent / 100;

                        currentRow.Cells["GV_HSN_Percent_Txt"].Value = Percent;
                        currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = Total;
                        currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = PanAmount;

                        CalculatesTotal();
                    }
                    else
                    {
                        PanPercent = Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value);

                        Double Total = (Amount + Expense) * Percent / 100;
                        Double PanAmount = (Amount + Expense) * PanPercent / 100;

                        currentRow.Cells["GV_HSN_Percent_Txt"].Value = Percent;
                        currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = Total;
                        currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = PanAmount;

                        CalculatesTotal();
                    }
                }
            }
        }
        public void RGV_Txt_TextChanged(object sender, EventArgs e)
        {
            Double Qty = 0;
            Double Unit = 0;
            Double Expense = 0;
            RadTextBoxEditorElement TTB = ((RadTextBoxEditorElement)sender);
            if(TTB.Name == "GV_Qty_Txt")
            {
                GridViewRowInfo currentRow = RGV_Item.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Qty = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);

                    Unit = Convert.ToDouble(currentRow.Cells["GV_UnitPrice_Txt"].Value);

                    Double Amount = Qty * Unit;
                    Expense = Convert.ToDouble(currentRow.Cells["GV_ExpenseValue_Txt"].Value);

                    Double TaxAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_HSN_Percent_Txt"].Value) / 100;
                    Double WhAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value) / 100;

                    currentRow.Cells["GV_Amount_Txt"].Value = Amount;
                    currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = TaxAmount;
                    currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = WhAmount;

                    CalculatesTotal();
                }
            }
            else if (TTB.Name == "GV_UnitPrice_Txt")
            {
                GridViewRowInfo currentRow = RGV_Item.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Unit = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);
                    Qty = Convert.ToDouble(currentRow.Cells["GV_Qty_Txt"].Value);

                    Double Amount = Qty * Unit;
                    Expense = Convert.ToDouble(currentRow.Cells["GV_ExpenseValue_Txt"].Value);

                    Double TaxAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_HSN_Percent_Txt"].Value) / 100;
                    Double WhAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value) / 100;

                    currentRow.Cells["GV_Amount_Txt"].Value = Amount;
                    currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = TaxAmount;
                    currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = WhAmount;

                    CalculatesTotal();
                }
            }
            else if (TTB.Name == "GV_ExpenseValue_Txt")
            {
                GridViewRowInfo currentRow = RGV_Item.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Unit = Convert.ToDouble(currentRow.Cells["GV_UnitPrice_Txt"].Value);
                    Qty = Convert.ToDouble(currentRow.Cells["GV_Qty_Txt"].Value);

                    Double Amount = Qty * Unit;
                    Expense = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);

                    Double TaxAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_HSN_Percent_Txt"].Value) / 100;
                    Double WhAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value) / 100;

                    currentRow.Cells["GV_Amount_Txt"].Value = Amount;
                    currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = TaxAmount;
                    currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = WhAmount;

                    CalculatesTotal();
                }
            }
        }

        void CalculatesTotal()
        {
            
                Double SumAmount = Convert.ToDouble(RGV_Item.MasterView.SummaryRows[0].Cells["GV_Amount_Txt"].Value.ToString());
                Double SumExpense = Convert.ToDouble(RGV_Item.MasterView.SummaryRows[0].Cells["GV_ExpenseValue_Txt"].Value.ToString());
                Double SumTax = Convert.ToDouble(RGV_Item.MasterView.SummaryRows[0].Cells["GV_GST_TaxAmount_Txt"].Value.ToString());
                Double SumWH = Convert.ToDouble(RGV_Item.MasterView.SummaryRows[0].Cells["GV_WH_TaxAmount_Txt"].Value.ToString());
                Double SumTotal = SumAmount + SumExpense + SumTax;
                Double Total = SumTotal - SumWH;
                Double Round = Math.Round(Total);
                InvoiceAmount_Txt.Text = SumTotal.ToString("0.00");
                WithHoldTax_Txt.Text = SumWH.ToString("0.00");
                Total_Txt.Text = Total.ToString("0.00");
                RoundOff_Txt.Text = (Round - Total).ToString("0.00");
                VendorPayable_Txt.Text = Round.ToString("0.00");
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (RGV_Item.Rows.Count > 0)
                {
                    for (int i = 0; i < RGV_Item.Rows.Count; i++)
                    {
                        String ItemCode = Convert.ToString(RGV_Item.Rows[i].Cells["GV_ItemCode_Cmbx"].Value);
                        String UoM = Convert.ToString(RGV_Item.Rows[i].Cells["GV_UoM_Cmbx"].Value);
                        String Qty = Convert.ToString(RGV_Item.Rows[i].Cells["GV_Qty_Txt"].Value);
                        String UnitPrice = Convert.ToString(RGV_Item.Rows[i].Cells["GV_UnitPrice_Txt"].Value);
                        String Amount = Convert.ToString(RGV_Item.Rows[i].Cells["GV_Amount_Txt"].Value);
                        if (ItemCode.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ItemCode is required");
                            break;
                        }
                        else if (UoM.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("UoM is required");
                            break;
                        }
                        else if (Qty.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Qty is required");
                            break;
                        }
                        else if (UnitPrice.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("UnitPrice is required");
                            break;
                        }
                        else if (Amount.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Amount is required");
                            break;
                        }
                    }
                }
                else
                {
                    Acc = 0;
                    MessageBox.Show("Enter required fields");
                }
                if (Acc == 1)
                {
                    GRN_DTO.GRN_Number = GRN_Number_Txt.Text;
                    GRN_DTO.GRN_Date = Convert.ToInt32(Convert.ToDateTime(GRN_Date_dt.Text).ToString("yyyyMMdd"));
                    GRN_DTO.PurchaseInvoiceNo = PurchaseInvoiceNo_Txt.Text;
                    GRN_DTO.PurchaseInvoiceDate = Convert.ToInt32(Convert.ToDateTime(PurchaseInvoiceDate_dt.Text).ToString("yyyyMMdd"));
                    GRN_DTO.VendorName = Convert.ToInt64(VendorName_Cmbx.SelectedValue);
                    GRN_DTO.TaxCluster = Convert.ToInt64(GST_TaxCluster_Cmbx.SelectedValue);
                    GRN_DTO.WH_TaxCode = Convert.ToInt64(WH_TaxCode_Cmbx.SelectedValue);
                    GRN_DTO.MaterialSegregation = Convert.ToInt64(MaterialSegregation_Cmbx.SelectedValue == null ? 1 : MaterialSegregation_Cmbx.SelectedValue);

                    GRN_DTO.InvoiceAmount = Convert.ToDouble(InvoiceAmount_Txt.Text);
                    GRN_DTO.WithHoldTax = Convert.ToDouble(WithHoldTax_Txt.Text);
                    GRN_DTO.Total = Convert.ToDouble(Total_Txt.Text);
                    GRN_DTO.RoundOff = Convert.ToDouble(RoundOff_Txt.Text);
                    GRN_DTO.VendorPayable = Convert.ToDouble(VendorPayable_Txt.Text);

                    GRN_DTO.CreatorCode = 1;
                    GRN_DTO.Id = 3;
                    DS = GRN_DAO.GRNDB(GRN_DTO);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < RGV_Item.Rows.Count; i++)
                        {
                            GRN_DTO.Number = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                            GRN_DTO.ItemCode = Convert.ToInt64(RGV_Item.Rows[i].Cells["GV_ItemCode_Cmbx"].Value.ToString());

                            try
                            {
                                GRN_DTO.UoM = Convert.ToInt64(RGV_Item.Rows[i].Cells["GV_UoM_Cmbx"].Value.ToString());
                            }
                            catch
                            {
                                DataSet DS1 = new DataSet();

                                GRN_DTO.GRN_Number = Convert.ToString(RGV_Item.Rows[i].Cells["GV_UoM_Cmbx"].Value.ToString());
                                GRN_DTO.Id = 4;
                                DS1 = GRN_DAO.GRNDB(GRN_DTO);

                                GRN_DTO.UoM = Convert.ToInt64(DS1.Tables[4].Rows[0]["UnitNumber"].ToString());
                            }
                            GRN_DTO.Qty = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_Qty_Txt"].Value.ToString());
                            GRN_DTO.UnitPrice = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_UnitPrice_Txt"].Value.ToString());
                            GRN_DTO.Amount = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_Amount_Txt"].Value.ToString());
                            GRN_DTO.ExpenseCode = Convert.ToInt64(RGV_Item.Rows[i].Cells["GV_ExpenseCode_Cmbx"].Value.ToString());
                            GRN_DTO.ExpenseValue = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_ExpenseValue_Txt"].Value.ToString());
                            GRN_DTO.HSN = Convert.ToInt64(RGV_Item.Rows[i].Cells["GV_HSN_Cmbx"].Value.ToString());
                            GRN_DTO.GST_TaxAmount = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_GST_TaxAmount_Txt"].Value.ToString());
                            GRN_DTO.WH_TaxCode = Convert.ToInt64(RGV_Item.Rows[i].Cells["GV_WH_TaxNumber_Txt"].Value.ToString());
                            GRN_DTO.Percent = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_Percent_Txt"].Value.ToString());
                            GRN_DTO.WH_TaxAmount = Convert.ToDouble(RGV_Item.Rows[i].Cells["GV_WH_TaxAmount_Txt"].Value.ToString());
                            GRN_DTO.Id = 7;
                            GRN_DAO.GRNDB(GRN_DTO);
                        }
                    }
                    MessageBox.Show(Alert.Save());
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

            RGV_Item.Rows.Clear();
            RGV_Item.CellEditorInitialized += new GridViewCellEventHandler(RGV_Item_CellEditorInitialized);
            RGV_Item.Rows.AddNew();
            OnGRNNumber(0);
        }


        //GRN Check
        private void GRNDirect_CheckedChanged(object sender, EventArgs e)
        {
            RGV_Item.Visible = true;
            RGV_Item.BringToFront();
            RGV_POItem.Visible = false;
            RGV_ItemPO.Visible = false;
        }
        private void GRNPOItem_CheckedChanged(object sender, EventArgs e)
        {
            RGV_Item.Visible = false;
            RGV_POItem.Visible = true;
            RGV_ItemPO.Visible = false;
            RGV_POItem.BringToFront();
            PoSelect();
        }
        private void GRNItemPO_CheckedChanged(object sender, EventArgs e)
        {
            RGV_Item.Visible = false;
            RGV_POItem.Visible = false;
            RGV_ItemPO.Visible = true;
            RGV_ItemPO.BringToFront();
            ItemSelect();
        }
        void PoSelect()
        {
            if (VendorName_Cmbx.SelectedValue != null)
            {
                GRN_DTO.VendorName = Convert.ToInt32(VendorName_Cmbx.SelectedValue);
                GRN_DTO.CreatorCode = 1;
                GRN_DTO.Id = 21;
                DS = GRN_DAO.GRNDB(GRN_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    RGV_Po.DataSource = DS.Tables[0];
                }
            }
        }
        void ItemSelect()
        {
            if (VendorName_Cmbx.SelectedValue != null)
            {
                GRN_DTO.VendorName = Convert.ToInt32(VendorName_Cmbx.SelectedValue);
                GRN_DTO.CreatorCode = 1;
                GRN_DTO.Id = 32;
                DS = GRN_DAO.GRNDB(GRN_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    GV_ItemToPo.DataSource = DS.Tables[0];


                    GridViewComboBoxColumn GV_ItemPOCode = (GridViewComboBoxColumn)RGV_ItemPO.Columns["GV_ItemCode_Cmbx"];
                    GV_ItemPOCode.DataSource = DS.Tables[1];
                    GV_ItemPOCode.DisplayMember = "ItemCode";
                    GV_ItemPOCode.ValueMember = "ItemNumber";
                }
            }
        }


        private void PurchaseOrder_Click(object sender, EventArgs e)
        {
            RPC_PoPanel.Width = this.ClientSize.Width - 30;
            RPC_PoPanel.Height = this.ClientSize.Height - 30;
            RPC_PoPanel.Left = 0;
            RPC_PoPanel.Top = 0;
            RPC_PoPanel.BackColor = System.Drawing.Color.Transparent;

            RPC_PoPanelInner.Width = this.ClientSize.Width / 2;
            RPC_PoPanelInner.Height = this.ClientSize.Height / 2;
            RPC_PoPanelInner.Left = (this.ClientSize.Width - RPC_PoPanelInner.Width) / 2;
            RPC_PoPanelInner.Top = (this.ClientSize.Height - RPC_PoPanelInner.Height) / 2;
            RPC_PoPanelInner.BringToFront();

            RPC_PoPanel.Visible = true;
            RPC_PoPanel.BringToFront();
        }
        private void POPull_Click(object sender, EventArgs e)
        {
            String OrdeNumer = "";
            for (int i = 0; i < RGV_Po.Rows.Count; i++)
            {
                String Pull = Convert.ToString(RGV_Po.Rows[i].Cells["RGV_Pull_CB"].Value);

                if (Pull=="True")
                {
                    OrdeNumer += Convert.ToString(RGV_Po.Rows[i].Cells["RGV_Number"].Value) + ",";
                }
            }

            GRN_DTO.Search = OrdeNumer;
            GRN_DTO.CreatorCode = 1;
            GRN_DTO.Id = 22;
            DS = GRN_DAO.GRNDB(GRN_DTO);
            String Purchase="";
            if (DS.Tables[0].Rows.Count > 0)
            {
                for(int i = 0;i < DS.Tables[0].Rows.Count; i++)
                {
                    String a = DS.Tables[0].Rows[i]["Number"].ToString();
                    Purchase += DS.Tables[0].Rows[i]["PurchaseNumber"].ToString()+",";

                    var filteredRows = RGV_PoItemSub.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["GV_GRNItemNumber_Txt"].Value.ToString() == a).ToList();

                    if (filteredRows.Count == 0)
                    {
                        GridViewDataRowInfo newRow = (GridViewDataRowInfo)RGV_POItem.Rows.AddNew();
                        newRow.Cells["GV_GRNItemNumber_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["Number"]);
                        newRow.Cells["GV_PONumber_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PurchaseNumber"]);
                        newRow.Cells["GV_POOrder_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PurchaseOrder"]);
                        newRow.Cells["GV_ItemCode_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemCode"]);
                        newRow.Cells["GV_ItemDescription_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemDescription"]);
                        newRow.Cells["GV_ItemGroup_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemGroup"]);
                        newRow.Cells["GV_UoM_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["UoM"]);
                        newRow.Cells["GV_Qtys_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PO_Qtys"]);
                        newRow.Cells["GV_Qty_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PO_Qty"]);
                        newRow.Cells["GV_UnitPrice_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["UnitPrice"]);
                        newRow.Cells["GV_Amount_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["Amount"]);

                        GridViewDataRowInfo newRow1 = (GridViewDataRowInfo)RGV_PoItemSub.Rows.AddNew();
                        newRow1.Cells["GV_GRNItemNumber_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["Number"]);
                        newRow1.Cells["GV_PONumber_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PurchaseNumber"]);
                        newRow1.Cells["GV_POOrder_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PurchaseOrder"]);
                        newRow1.Cells["GV_ItemCode_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemCode"]);
                        newRow1.Cells["GV_ItemDescription_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemDescription"]);
                        newRow1.Cells["GV_ItemGroup_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["ItemGroup"]);
                        newRow.Cells["GV_UoM_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["UoM"]);
                        newRow1.Cells["ItemCheck"].Value = true;
                        newRow1.Cells["GV_Qty_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PO_Qty"]);
                        newRow1.Cells["GV_Qtys_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["PO_Qtys"]);
                        newRow1.Cells["GV_UnitPrice_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["UnitPrice"]);
                        newRow1.Cells["GV_Amount_Txt"].Value = Convert.ToString(DS.Tables[0].Rows[i]["Amount"]);
                    }
                }

                String[] Pur = Purchase.Split(',');
                var GetItem = RGV_PoItemSub.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["GV_PONumber_Txt"].Value.ToString()!="").ToList();

                for (int i = 0; i < GetItem.Count; i++)
                {
                    String ele = Convert.ToString(GetItem[i].Cells["GV_PONumber_Txt"].Value);
                    string value = Array.Find(Pur, element => element.Equals(ele));

                    if (value == null)
                    {
                        String a = GetItem[i].Cells["GV_PONumber_Txt"].Value.ToString();
                        var Remove = RGV_PoItemSub.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["GV_PONumber_Txt"].Value.ToString() == a).ToList();

                        foreach (var row in Remove)
                        {
                            RGV_PoItemSub.Rows.Remove(row);
                        }

                        var Removes = RGV_POItem.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["GV_PONumber_Txt"].Value.ToString() == a).ToList();

                        foreach (var row in Removes)
                        {
                            RGV_POItem.Rows.Remove(row);
                        }
                    }
                }

                RPC_PoPanel.Visible = false;
                RGV_POItemCalculatesTotal();
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            RPC_PoPanel.Visible = false;
        }


        private void ItemGrid_Click(object sender, EventArgs e)
        {
            RPC_ItemPanel.Width = this.ClientSize.Width - 30;
            RPC_ItemPanel.Height = this.ClientSize.Height - 30;
            RPC_ItemPanel.Left = 0;
            RPC_ItemPanel.Top = 0;
            RPC_ItemPanel.BackColor = System.Drawing.Color.Transparent;

            RPC_ItemInnerPanel.Width = this.ClientSize.Width / 2;
            RPC_ItemInnerPanel.Height = this.ClientSize.Height / 2;
            RPC_ItemInnerPanel.Left = (this.ClientSize.Width - RPC_PoPanelInner.Width) / 2;
            RPC_ItemInnerPanel.Top = (this.ClientSize.Height - RPC_PoPanelInner.Height) / 2;
            RPC_ItemInnerPanel.BringToFront();

            RPC_ItemPanel.Visible = true;
            RPC_ItemPanel.BringToFront();
        }
        private void ItemPull_Click(object sender, EventArgs e)
        {
            var GetItem = RGV_PoItemSub.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["ItemCheck"].Value.ToString() == "True").ToList();

            for (int i = 0; i < GetItem.Count; i++)
            {
                String a = Convert.ToString(GetItem[i].Cells["GV_GRNItemNumber_Txt"].Value);

                var filteredRows = RGV_POItem.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["GV_GRNItemNumber_Txt"].Value.ToString() == a).ToList();
                if (filteredRows.Count == 0)
                {
                    GridViewDataRowInfo newRow = (GridViewDataRowInfo)RGV_POItem.Rows.AddNew();
                    newRow.Cells["GV_GRNItemNumber_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_GRNItemNumber_Txt"].Value);
                    newRow.Cells["GV_PONumber_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_PONumber_Txt"].Value);
                    newRow.Cells["GV_POOrder_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_POOrder_Txt"].Value);
                    newRow.Cells["GV_ItemCode_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_ItemCode_Txt"].Value);
                    newRow.Cells["GV_ItemDescription_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_ItemDescription_Txt"].Value);
                    newRow.Cells["GV_ItemGroup_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_ItemGroup_Txt"].Value);
                    newRow.Cells["GV_UoM_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_UoM_Txt"].Value);
                    newRow.Cells["GV_Qtys_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_Qtys_Txt"].Value);
                    newRow.Cells["GV_Qty_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_Qty_Txt"].Value);
                    newRow.Cells["GV_UnitPrice_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_UnitPrice_Txt"].Value);
                    newRow.Cells["GV_Amount_Txt"].Value = Convert.ToString(GetItem[i].Cells["GV_Amount_Txt"].Value);
                }
            }

            var GetItemRemove = RGV_PoItemSub.Rows.Cast<GridViewDataRowInfo>().Where(row => row.Cells["ItemCheck"].Value.ToString() == "False").ToList();

            for (int i = 0; i < GetItemRemove.Count; i++)
            {
                String a = Convert.ToString(GetItemRemove[i].Cells["GV_GRNItemNumber_Txt"].Value);
                var Remove = RGV_POItem.Rows.Cast<GridViewDataRowInfo>().Where(row => Convert.ToString(row.Cells["GV_GRNItemNumber_Txt"].Value) == a).ToList();

                foreach (var row in Remove)
                {
                    RGV_POItem.Rows.Remove(row);
                }
            }
            RPC_ItemPanel.Visible = false;
            RGV_POItemCalculatesTotal();
        }
        private void ItemPoPull_Click(object sender, EventArgs e)
        {
            Int64 GRNItemNumber=0;
            Int64 PONumber = 0;
            String POOrder = "";
            Int64 ItemCode = 0;
            String ItemDescription = "";
            String ItemGroup="";
            String UoM = "";
            Double Qty = 0;
            Double UnitPrice = 0;
            Double Amount = 0;

            var GetItem = GV_ItemToPo.Rows.Cast<GridViewDataRowInfo>().Where(row => Convert.ToString(row.Cells["ItemCheck"].Value) == "True" && Convert.ToString(row.Cells["GV_ItemNumber_Txt"].Value) == CurrentRow_Txt.Text).ToList();

            for (int i = 0; i < GetItem.Count; i++)
            {
                GRNItemNumber = Convert.ToInt64(GetItem[i].Cells["GV_GRNItemNumber_Txt"].Value);
                PONumber = Convert.ToInt64(GetItem[i].Cells["GV_PONumber_Txt"].Value);
                POOrder = Convert.ToString(GetItem[i].Cells["GV_POOrder_Txt"].Value);
                ItemCode = Convert.ToInt64(GetItem[i].Cells["GV_ItemNumber_Txt"].Value);
                ItemDescription = Convert.ToString(GetItem[i].Cells["GV_ItemDescription_Txt"].Value);
                ItemGroup = Convert.ToString(GetItem[i].Cells["GV_ItemGroup_Txt"].Value);
                UoM = Convert.ToString(GetItem[i].Cells["GV_UoM_Txt"].Value);
                Qty += Convert.ToDouble(GetItem[i].Cells["GV_Qty_Txt"].Value);
                UnitPrice += Convert.ToDouble(GetItem[i].Cells["GV_UnitPrice_Txt"].Value);
                Amount += Convert.ToDouble(GetItem[i].Cells["GV_Amount_Txt"].Value);
            }
            try
            {
                GridViewRowInfo currentRow = GVRRows;
                currentRow.Delete();
            }
            catch { }


            for (int i = 0; i < RGV_ItemPO.Rows.Count; i++)
            {
                if (Convert.ToString(RGV_ItemPO.Rows[i].Cells["GV_ItemCode_Cmbx"].Value) == CurrentRow_Txt.Text)
                {
                    RGV_ItemPO.Rows[i].Delete();
                }
                else
                {
                    if (Convert.ToString(RGV_ItemPO.Rows[i].Cells["GV_GRNItemNumber_Txt"].Value) == "")
                    {
                        RGV_ItemPO.Rows[i].Delete();
                    }
                }
            }

            GridViewDataRowInfo newRow = (GridViewDataRowInfo)RGV_ItemPO.Rows.AddNew();
            newRow.Cells["GV_GRNItemNumber_Txt"].Value = Convert.ToString(GRNItemNumber);
            newRow.Cells["GV_PONumber_Txt"].Value = Convert.ToString(PONumber);
            newRow.Cells["GV_POOrder_Txt"].Value = Convert.ToString(POOrder);
            newRow.Cells["GV_ItemCode_Cmbx"].Value = Convert.ToString(ItemCode);
            newRow.Cells["GV_ItemDescription_Txt"].Value = Convert.ToString(ItemDescription);
            newRow.Cells["GV_ItemGroup_Txt"].Value = Convert.ToString(ItemGroup);
            newRow.Cells["GV_UoM_Txt"].Value = Convert.ToString(UoM);
            newRow.Cells["GV_Qty_Txt"].Value = Convert.ToString(Qty);
            newRow.Cells["GV_UnitPrice_Txt"].Value = Convert.ToString(UnitPrice);
            newRow.Cells["GV_Amount_Txt"].Value = Convert.ToString(Amount);

            for (int i = 0; i < RGV_ItemPO.Rows.Count; i++)
            {
                if (Convert.ToString(RGV_ItemPO.Rows[i].Cells["GV_GRNItemNumber_Txt"].Value) == "")
                {
                    RGV_ItemPO.Rows[i].Delete();
                }
            }
            RGV_ItemPO.Rows.AddNew();

            RPC_ItemPoPanel.Visible = false;
            RGV_ItemPOCalculatesTotal();
        }
        private void ItemClose_Click(object sender, EventArgs e)
        {
            RPC_ItemPanel.Visible = false;
        }
        private void ItemPOClose_Click(object sender, EventArgs e)
        {
            RPC_ItemPoPanel.Visible = false;
        }


        private void RGV_POItem_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column is GridViewTextBoxColumn TextColumn)
            {
                RadTextBoxEditor TextEditor = this.RGV_POItem.ActiveEditor as RadTextBoxEditor;
                if (TextEditor != null)
                {
                    RadTextBoxEditorElement TextElement = (RadTextBoxEditorElement)TextEditor.EditorElement;
                    TextElement.Name = TextColumn.Name;
                    TextElement.TextChanged += new EventHandler(RGV_POItem_Txt_TextChanged);
                }
            }
        }
        private void RGV_POItem_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            String DeleteNumer = "";
            foreach (GridViewRowInfo rowInfo in e.Rows)
            {
                DeleteNumer = rowInfo.Cells["GV_GRNItemNumber_Txt"].Value.ToString();
            }

            for (int i = 0; i < RGV_PoItemSub.Rows.Count; i++)
            {
                String Number = Convert.ToString(RGV_PoItemSub.Rows[i].Cells["GV_GRNItemNumber_Txt"].Value);

                if (Number == DeleteNumer)
                {
                    RGV_PoItemSub.Rows[i].Cells["ItemCheck"].Value = false;
                }
            }
            RGV_POItemCalculatesTotal();
        }
        private void RGV_POItem_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            RGV_POItemCalculatesTotal();
        }
        private void RGV_POItem_ComboBoxEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadDropDownListEditorElement DLE = ((RadDropDownListEditorElement)sender);
            if (DLE.Name == "GV_ItemCode_Cmbx")
            {
                
            }
            if (DLE.Name == "GV_HSN_Cmbx")
            {
            }
        }
        public void RGV_POItem_Txt_TextChanged(object sender, EventArgs e)
        {
            Double Qty = 0;
            Double Qtys = 0;
            Double Unit = 0;
            Double Expense = 0;
            RadTextBoxEditorElement TTB = ((RadTextBoxEditorElement)sender);
            if (TTB.Name == "GV_Qty_Txt")
            {
                GridViewRowInfo currentRow = RGV_POItem.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Qty = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);

                    Qtys = Convert.ToDouble(currentRow.Cells["GV_Qtys_Txt"].Value);

                    if (Qty <= Qtys)
                    {
                        Unit = Convert.ToDouble(currentRow.Cells["GV_UnitPrice_Txt"].Value);

                        Double Amount = Qty * Unit;
                        Expense = Convert.ToDouble(currentRow.Cells["GV_ExpenseValue_Txt"].Value);

                        Double TaxAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_HSN_Percent_Txt"].Value) / 100;
                        Double WhAmount = (Amount + Expense) * Convert.ToDouble(currentRow.Cells["GV_Percent_Txt"].Value) / 100;

                        currentRow.Cells["GV_Amount_Txt"].Value = Amount;
                        currentRow.Cells["GV_GST_TaxAmount_Txt"].Value = TaxAmount;
                        currentRow.Cells["GV_WH_TaxAmount_Txt"].Value = WhAmount;
                    }
                }
                RGV_POItemCalculatesTotal();
            }
        }
        void RGV_POItemCalculatesTotal()
        {
            try
            {
                Double SumAmount = Convert.ToDouble(RGV_POItem.MasterView.SummaryRows[0].Cells["GV_Amount_Txt"].Value.ToString());
                Double SumExpense = Convert.ToDouble(RGV_POItem.MasterView.SummaryRows[0].Cells["GV_ExpenseValue_Txt"].Value.ToString());
                Double SumTax = Convert.ToDouble(RGV_POItem.MasterView.SummaryRows[0].Cells["GV_GST_TaxAmount_Txt"].Value.ToString());
                Double SumWH = Convert.ToDouble(RGV_POItem.MasterView.SummaryRows[0].Cells["GV_WH_TaxAmount_Txt"].Value.ToString());
                Double SumTotal = SumAmount + SumExpense + SumTax;
                Double Total = SumTotal - SumWH;
                Double Round = Math.Round(Total);
                InvoiceAmount_Txt.Text = SumTotal.ToString("0.00");
                WithHoldTax_Txt.Text = SumWH.ToString("0.00");
                Total_Txt.Text = Total.ToString("0.00");
                RoundOff_Txt.Text = (Round - Total).ToString("0.00");
                VendorPayable_Txt.Text = Round.ToString("0.00");
            }
            catch { }
        }
        void RGV_ItemPOCalculatesTotal()
        {
            try
            {
                Double SumAmount = Convert.ToDouble(RGV_ItemPO.MasterView.SummaryRows[0].Cells["GV_Amount_Txt"].Value.ToString());
                Double SumExpense = Convert.ToDouble(RGV_ItemPO.MasterView.SummaryRows[0].Cells["GV_ExpenseValue_Txt"].Value.ToString());
                Double SumTax = Convert.ToDouble(RGV_ItemPO.MasterView.SummaryRows[0].Cells["GV_GST_TaxAmount_Txt"].Value.ToString());
                Double SumWH = Convert.ToDouble(RGV_ItemPO.MasterView.SummaryRows[0].Cells["GV_WH_TaxAmount_Txt"].Value.ToString());
                Double SumTotal = SumAmount + SumExpense + SumTax;
                Double Total = SumTotal - SumWH;
                Double Round = Math.Round(Total);
                InvoiceAmount_Txt.Text = SumTotal.ToString("0.00");
                WithHoldTax_Txt.Text = SumWH.ToString("0.00");
                Total_Txt.Text = Total.ToString("0.00");
                RoundOff_Txt.Text = (Round - Total).ToString("0.00");
                VendorPayable_Txt.Text = Round.ToString("0.00");
            }
            catch { }
        }


        GridViewRowInfo GVRRows;
        private void RGV_ItemPO_ValueChanged(object sender, EventArgs e)
        {
            if (this.RGV_ItemPO.ActiveEditor is RadDropDownListEditor dropDownListEditor)
            {
                RadDropDownListEditorElement RRR = (RadDropDownListEditorElement)dropDownListEditor.EditorElement;
                GridComboBoxCellElement RRE = (GridComboBoxCellElement)RRR.Parent;
                GridViewComboBoxColumn GCB = (GridViewComboBoxColumn)RRE.Data;

                if (Convert.ToString(this.RGV_ItemPO.ActiveEditor.Value) != "" && GCB.Name== "GV_ItemCode_Cmbx")
                {
                    String ICode = Convert.ToString(this.RGV_ItemPO.ActiveEditor.Value);
                    CurrentRow_Txt.Text = ICode;

                    foreach (GridViewDataRowInfo row in GV_ItemToPo.Rows)
                    {
                        if (Convert.ToString(row.Cells["GV_ItemNumber_Txt"].Value) == ICode)
                        {
                            row.IsVisible = true;
                        }
                        else
                        {

                            row.IsVisible = false;
                        }
                    }

                    GVRRows = RGV_ItemPO.CurrentRow;

                    RPC_ItemPoPanel.Width = this.ClientSize.Width - 30;
                    RPC_ItemPoPanel.Height = this.ClientSize.Height - 30;
                    RPC_ItemPoPanel.Left = 0;
                    RPC_ItemPoPanel.Top = 0;
                    RPC_ItemPoPanel.BackColor = System.Drawing.Color.Transparent;

                    RPC_ItemPoPanelInner.Width = this.ClientSize.Width / 2;
                    RPC_ItemPoPanelInner.Height = this.ClientSize.Height / 2;
                    RPC_ItemPoPanelInner.Left = (this.ClientSize.Width - RPC_ItemPoPanelInner.Width) / 2;
                    RPC_ItemPoPanelInner.Top = (this.ClientSize.Height - RPC_ItemPoPanelInner.Height) / 2;
                    RPC_ItemPoPanelInner.BringToFront();

                    RPC_ItemPoPanel.Visible = true;
                    RPC_ItemPoPanel.BringToFront();
                }
            }
        }

        private void GV_ItemToPo_ValueChanged(object sender, EventArgs e)
        {
            if (this.GV_ItemToPo.ActiveEditor is RadCheckBoxEditor CheckBoxEditor)
            {
                RadCheckBoxEditorElement RRR = (RadCheckBoxEditorElement)CheckBoxEditor.EditorElement;
                GridCheckBoxCellElement RRE = (GridCheckBoxCellElement)RRR.Parent;
                GridViewCheckBoxColumn GCE = (GridViewCheckBoxColumn)RRE.Data;

                if (GCE.Name == "ItemCheck")
                {
                    Double Qty = 0;
                    Double UnitPrice = 0;
                    Double Amount = 0;

                    var GetItem = GV_ItemToPo.Rows.Cast<GridViewDataRowInfo>().Where(row => Convert.ToString(row.Cells["ItemCheck"].Value) == "True" && Convert.ToString(row.Cells["GV_ItemNumber_Txt"].Value) == CurrentRow_Txt.Text).ToList();
                    for (Int32 i = 0; i < GV_ItemToPo.Rows.Count; i++)
                    {
                        if (Convert.ToString(GV_ItemToPo.Rows[i].Cells["ItemCheck"].Value) == "True")
                        {
                            if (GV_ItemToPo.Rows[i].Cells["GV_Qty_Txt"].Value.ToString() != "")
                            {
                                Qty += Convert.ToInt32(GV_ItemToPo.Rows[i].Cells["GV_Qty_Txt"].Value);
                            }
                            UnitPrice += Convert.ToDouble(GV_ItemToPo.Rows[i].Cells["GV_UnitPrice_Txt"].Value);
                            Amount += Convert.ToDouble(GV_ItemToPo.Rows[i].Cells["GV_Amount_Txt"].Value);
                        }
                    }

                    GridViewRowInfo currentRow = GV_ItemToPo.CurrentRow;
                    if (Convert.ToString(GV_ItemToPo.ActiveEditor.Value) == "On")
                    {
                        if (currentRow.Cells["GV_Qty_Txt"].Value.ToString() != "")
                        {
                            Qty += Convert.ToDouble(currentRow.Cells["GV_Qty_Txt"].Value);
                        }
                        UnitPrice += Convert.ToDouble(currentRow.Cells["GV_UnitPrice_Txt"].Value);
                        Amount += Convert.ToDouble(currentRow.Cells["GV_Amount_Txt"].Value);
                    }

                    if (GetItem.Count == 0 & Convert.ToString(GV_ItemToPo.ActiveEditor.Value) == "Off")
                    {
                        Qty = 0;
                        UnitPrice = 0;
                        Amount = 0;
                    }

                    this.GV_ItemToPo.SummaryRowsBottom.Clear();
                    GridViewSummaryItem DQty = new GridViewSummaryItem("GV_Qty_Txt", Qty.ToString(), GridAggregateFunction.Sum);
                    GridViewSummaryItem DPrise = new GridViewSummaryItem("GV_UnitPrice_Txt", UnitPrice.ToString(), GridAggregateFunction.Sum);
                    GridViewSummaryItem DAmount = new GridViewSummaryItem("GV_Amount_Txt", Amount.ToString(), GridAggregateFunction.Sum);
                    GV_ItemToPo.MasterTemplate.SummaryRowsBottom.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { DQty, DPrise, DAmount }));
                    GV_ItemToPo.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
                    GV_ItemToPo.MasterView.SummaryRows[0].IsPinned = true;
                    GV_ItemToPo.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
                }
            }

            if (this.GV_ItemToPo.ActiveEditor is RadTextBoxEditor TextBoxEditor)
            {
                RadTextBoxEditorElement RRR = (RadTextBoxEditorElement)TextBoxEditor.EditorElement;
                GridDataCellElement RDE = (GridDataCellElement)RRR.Parent;
                GridViewTextBoxColumn GTB = (GridViewTextBoxColumn)RDE.Data;

                if (GTB.Name == "GV_Qty_Txt")
                {
                    Double Qty = 0;
                    Double UnitPrice = 0;
                    Double Amount = 0;

                    GridViewRowInfo currentRow = GV_ItemToPo.CurrentRow;

                    if(Convert.ToDouble(this.GV_ItemToPo.ActiveEditor.Value) > Convert.ToDouble(currentRow.Cells["GV_Qtys_Txt"].Value))
                    {
                        Qty = Convert.ToDouble(currentRow.Cells["GV_Qtys_Txt"].Value);
                        currentRow.Cells["GV_Qty_Txt"].Value = Qty;
                        this.GV_ItemToPo.ActiveEditor.Value = Qty;
                    }
                    try
                    {
                        if (this.GV_ItemToPo.ActiveEditor.Value.ToString() != "")
                        {
                            Qty = Convert.ToDouble(this.GV_ItemToPo.ActiveEditor.Value);
                        }
                    }
                    catch { }

                    UnitPrice = Convert.ToDouble(currentRow.Cells["GV_UnitPrice_Txt"].Value);
                    Amount = Qty * UnitPrice;

                    currentRow.Cells["GV_Amount_Txt"].Value = Amount;

                    Qty = 0;
                    UnitPrice = 0;
                    Amount = 0;

                    var GetItem = GV_ItemToPo.Rows.Cast<GridViewDataRowInfo>().Where(row => Convert.ToString(row.Cells["ItemCheck"].Value) == "True" && Convert.ToString(row.Cells["GV_ItemNumber_Txt"].Value) == CurrentRow_Txt.Text).ToList();
                    for (Int32 i = 0; i < GV_ItemToPo.Rows.Count; i++)
                    {
                        if (Convert.ToString(GV_ItemToPo.Rows[i].Cells["ItemCheck"].Value) == "True")
                        {
                            if (GV_ItemToPo.Rows[i].Cells["GV_Qty_Txt"].Value.ToString() != "")
                            {
                                Qty += Convert.ToDouble(GV_ItemToPo.Rows[i].Cells["GV_Qty_Txt"].Value);
                            }
                            UnitPrice += Convert.ToDouble(GV_ItemToPo.Rows[i].Cells["GV_UnitPrice_Txt"].Value);
                            Amount += Convert.ToDouble(GV_ItemToPo.Rows[i].Cells["GV_Amount_Txt"].Value);
                        }
                    }
                    if (GetItem.Count == 0)
                    {
                        Qty = 0;
                        UnitPrice = 0;
                        Amount = 0;
                    }

                    this.GV_ItemToPo.SummaryRowsBottom.Clear();
                    GridViewSummaryItem DQty = new GridViewSummaryItem("GV_Qty_Txt", Qty.ToString(), GridAggregateFunction.Sum);
                    GridViewSummaryItem DPrise = new GridViewSummaryItem("GV_UnitPrice_Txt", UnitPrice.ToString(), GridAggregateFunction.Sum);
                    GridViewSummaryItem DAmount = new GridViewSummaryItem("GV_Amount_Txt", Amount.ToString(), GridAggregateFunction.Sum);
                    GV_ItemToPo.MasterTemplate.SummaryRowsBottom.Add(new GridViewSummaryRowItem(new GridViewSummaryItem[] { DQty, DPrise, DAmount }));
                    GV_ItemToPo.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed;
                    GV_ItemToPo.MasterView.SummaryRows[0].IsPinned = true;
                    GV_ItemToPo.MasterView.SummaryRows[0].PinPosition = PinnedRowPosition.Bottom;
                }
            }
        }
    }
}
