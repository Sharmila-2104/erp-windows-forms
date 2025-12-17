using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ERP.Procurement
{
    public partial class PurchaseEdit : Form
    {
        Purchase_DTO P_DTO = new Purchase_DTO();
        Purchase_DAO P_DAO = new Purchase_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        Validation Va = new Validation();
        DataSet DS = new DataSet();

        MonthCalendar myCal = new MonthCalendar();
        PictureBox PBox = new PictureBox();

        MonthCalendar P_myCal = new MonthCalendar();
        PictureBox P_PBox = new PictureBox();

        Rectangle Rect = new Rectangle();

        Int64 Code = 0;
        public PurchaseEdit(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
            GV_Item.Controls.Add(PBox);
            GV_Item.Controls.Add(myCal);

            myCal.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);
            myCal.Leave += new EventHandler(MonthCalendar_Leave);

            PBox.Click += new EventHandler(PBox_Click);

            PBox.Visible = false;
            myCal.Visible = false;
            ExpenseItemPopUp.Visible = false;
            ExpensePopUp.Visible = false;
            Po_Date_Cal.Visible = false;

            RGV_Item.CellEditorInitialized += new GridViewCellEventHandler(RGV_Item_CellEditorInitialized);
            RGV_Item.ValueChanged += new EventHandler(RGV_Item_ValueChanged);

            RGV_ExpenseHead.ValueChanged += new EventHandler(RGV_ExpenseHead_ValueChanged);

            RGV_ExpenseItem.ValueChanged += new EventHandler(RGV_ExpenseItem_ValueChanged);
        }

        private void PurchaseEdit_Load(object sender, EventArgs e)
        {
            GetData(Code);
            RGV_Item.Rows.AddNew();
            RGV_ExpenseHead.Rows.AddNew();
            Btn_Cancel.Text = "Cancel";
        }
        void GetData(Int64 Number)
        {
            P_DTO.PurchaseNumber = Number;
            P_DTO.Id = 201;
            DS = P_DAO.PurchaseDB(P_DTO);
            if (DS.Tables[0].Rows.Count > 0)
            {
                Currency_Cmbx.DataSource = DS.Tables[1];
                Currency_Cmbx.DisplayMember = "CurrencyCode";
                Currency_Cmbx.ValueMember = "CurrencyNumber";

                MaterialSegragation_Cmbx.DataSource = DS.Tables[2];
                MaterialSegragation_Cmbx.DisplayMember = "Segregation";
                MaterialSegragation_Cmbx.ValueMember = "Number";

                VendorCode_Cmbx.DataSource = DS.Tables[3];
                VendorCode_Cmbx.DisplayMember = "VendorCode";
                VendorCode_Cmbx.ValueMember = "VendorNumber";

                PurchaseNumber_Txt.Text = DS.Tables[0].Rows[0]["PurchaseNumber"].ToString();
                PurchaseOrderNo_Txt.Text = DS.Tables[0].Rows[0]["PurchaseOrderNo"].ToString();
                PoDate_dt.Text = DS.Tables[0].Rows[0]["PoDate"].ToString();
                VendorCode_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["VendorCode"].ToString();
                VendorCode_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["VendorCode"].ToString();
                Currency_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["Currency"].ToString();
                MaterialSegragation_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["MaterialSegregation"].ToString();
                PaymentTerms_Txt.Text = DS.Tables[0].Rows[0]["PaymentTerms"].ToString();
                PaymentMethod_Txt.Text = DS.Tables[0].Rows[0]["PaymentMethod"].ToString();
                DeliveryTerms_Txt.Text = DS.Tables[0].Rows[0]["DeliveryTerms"].ToString();
                DeliveryMode_Txt.Text = DS.Tables[0].Rows[0]["DeliveryMode"].ToString();
                Tax_rtxt.Text = DS.Tables[0].Rows[0]["Tax"].ToString();
                Inspection_rtxt.Text = DS.Tables[0].Rows[0]["Inspection"].ToString();
                TechnicalDeliveryConditions_rtxt.Text = DS.Tables[0].Rows[0]["TechnicalDeliveryConditions"].ToString();
                Remarks_rtxt.Text = DS.Tables[0].Rows[0]["Remarks"].ToString();
                String L = DS.Tables[0].Rows[0]["IsImportOrder"].ToString();
                if (L == "1")
                {
                    IsImportOrder_ckbx.Checked = true;
                }
                else if (L == "2")
                {
                    IsImportOrder_ckbx.Checked = true;
                }
                VendorName_Txt.Text = DS.Tables[4].Rows[0]["VendorName"].ToString();
                Address_rtxt.Text = DS.Tables[4].Rows[0]["Address"].ToString();
                City_Txt.Text = DS.Tables[4].Rows[0]["City"].ToString();
                State_Txt.Text = DS.Tables[4].Rows[0]["State"].ToString();
                Country_Txt.Text = DS.Tables[4].Rows[0]["Country"].ToString();
                Pincode_Txt.Text = DS.Tables[4].Rows[0]["PIN"].ToString();
                GST_Txt.Text = DS.Tables[4].Rows[0]["GSTIN"].ToString();
                PAN_Txt.Text = DS.Tables[4].Rows[0]["PAN"].ToString();

                DataGridViewComboBoxColumn ItemCode_Cmbx = GV_Item.Columns["ItemCode_Cmbx"] as DataGridViewComboBoxColumn;
                ItemCode_Cmbx.DataSource = DS.Tables[5];
                ItemCode_Cmbx.DisplayMember = "ItemCode";
                ItemCode_Cmbx.ValueMember = "ItemNumber";

                //RGV Item
                GridViewComboBoxColumn GV_ItemCode = (GridViewComboBoxColumn)RGV_Item.Columns["ItemCode_Cmbx"];
                GV_ItemCode.DataSource = DS.Tables[5];
                GV_ItemCode.DisplayMember = "ItemCode";
                GV_ItemCode.ValueMember = "ItemNumber";

                UoM_Cmbx.DataSource = DS.Tables[6];
                UoM_Cmbx.DisplayMember = "UnitCode";
                UoM_Cmbx.ValueMember = "UnitNumber";

                GridViewComboBoxColumn GV_UoM_Cmbx = (GridViewComboBoxColumn)RGV_Item.Columns["UoM_Cmbx"];
                GV_UoM_Cmbx.DataSource = DS.Tables[6];
                GV_UoM_Cmbx.DisplayMember = "UnitCode";
                GV_UoM_Cmbx.ValueMember = "UnitNumber";

                //GV_Item.DataSource = DS.Tables[7];
                RGV_Item.DataSource = DS.Tables[7];

                //RGV Expense Head
                DataGridViewComboBoxColumn H_ExpenseCode_Cmbx = GV_ExpenseHead.Columns["H_ExpenseCode_Cmbx"] as DataGridViewComboBoxColumn;
                H_ExpenseCode_Cmbx.DataSource = DS.Tables[8];
                H_ExpenseCode_Cmbx.DisplayMember = "ExpenseCode";
                H_ExpenseCode_Cmbx.ValueMember = "ExpenseCodeNumber";

                GridViewComboBoxColumn GV_H_ExpenseCode_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseHead.Columns["H_ExpenseCode_Cmbx"];
                GV_H_ExpenseCode_Cmbx.DataSource = DS.Tables[8];
                GV_H_ExpenseCode_Cmbx.DisplayMember = "ExpenseCode";
                GV_H_ExpenseCode_Cmbx.ValueMember = "ExpenseCodeNumber";

                H_Occurrence_Cmbx.DataSource = DS.Tables[9];
                H_Occurrence_Cmbx.DisplayMember = "Occurrence";
                H_Occurrence_Cmbx.ValueMember = "Number";
                
                GridViewComboBoxColumn GV_H_Occurrence_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseHead.Columns["H_Occurrence_Cmbx"];
                GV_H_Occurrence_Cmbx.DataSource = DS.Tables[9];
                GV_H_Occurrence_Cmbx.DisplayMember = "Occurrence";
                GV_H_Occurrence_Cmbx.ValueMember = "Number";

                H_ChargeableMethod_Cmbx.DataSource = DS.Tables[10];
                H_ChargeableMethod_Cmbx.DisplayMember = "Chargeable";
                H_ChargeableMethod_Cmbx.ValueMember = "Number";

                GridViewComboBoxColumn GV_H_ChargeableMethod_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseHead.Columns["H_ChargeableMethod_Cmbx"];
                GV_H_ChargeableMethod_Cmbx.DataSource = DS.Tables[10];
                GV_H_ChargeableMethod_Cmbx.DisplayMember = "Chargeable";
                GV_H_ChargeableMethod_Cmbx.ValueMember = "Number";

                H_Allocate_Cmbx.DataSource = DS.Tables[11];
                H_Allocate_Cmbx.DisplayMember = "Allocate";
                H_Allocate_Cmbx.ValueMember = "Number";

                GridViewComboBoxColumn GV_H_Allocate_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseHead.Columns["H_Allocate_Cmbx"];
                GV_H_Allocate_Cmbx.DataSource = DS.Tables[11];
                GV_H_Allocate_Cmbx.DisplayMember = "Allocate";
                GV_H_Allocate_Cmbx.ValueMember = "Number";

                //GV_ExpenseHead.DataSource = DS.Tables[12];
                RGV_ExpenseHead.DataSource = DS.Tables[12];

                //RGV Expense Item
                DataGridViewComboBoxColumn I_ExpenseCode_Cmbx = GV_ExpenseItem.Columns["I_ExpenseCode_Cmbx"] as DataGridViewComboBoxColumn;
                I_ExpenseCode_Cmbx.DataSource = DS.Tables[13];
                I_ExpenseCode_Cmbx.DisplayMember = "ExpenseCode";
                I_ExpenseCode_Cmbx.ValueMember = "ExpenseCodeNumber";

                GridViewComboBoxColumn GV_I_ExpenseCode_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseItem.Columns["I_ExpenseCode_Cmbx"];
                GV_I_ExpenseCode_Cmbx.DataSource = DS.Tables[13];
                GV_I_ExpenseCode_Cmbx.DisplayMember = "ExpenseCode";
                GV_I_ExpenseCode_Cmbx.ValueMember = "ExpenseCodeNumber";

                I_Occurrence_Cmbx.DataSource = DS.Tables[14];
                I_Occurrence_Cmbx.DisplayMember = "Occurrence";
                I_Occurrence_Cmbx.ValueMember = "Number";

                GridViewComboBoxColumn GV_I_Occurrence_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseItem.Columns["I_Occurrence_Cmbx"];
                GV_I_Occurrence_Cmbx.DataSource = DS.Tables[14];
                GV_I_Occurrence_Cmbx.DisplayMember = "Occurrence";
                GV_I_Occurrence_Cmbx.ValueMember = "Number";

                I_ChargeableMethod_Cmbx.DataSource = DS.Tables[15];
                I_ChargeableMethod_Cmbx.DisplayMember = "Chargeable";
                I_ChargeableMethod_Cmbx.ValueMember = "Number";

                GridViewComboBoxColumn GV_I_ChargeableMethod_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseItem.Columns["I_ChargeableMethod_Cmbx"];
                GV_I_ChargeableMethod_Cmbx.DataSource = DS.Tables[15];
                GV_I_ChargeableMethod_Cmbx.DisplayMember = "Chargeable";
                GV_I_ChargeableMethod_Cmbx.ValueMember = "Number";

                I_Allocate_Cmbx.DataSource = DS.Tables[16];
                I_Allocate_Cmbx.DisplayMember = "Allocate";
                I_Allocate_Cmbx.ValueMember = "Number";

                GridViewComboBoxColumn GV_I_Allocate_Cmbx = (GridViewComboBoxColumn)RGV_ExpenseItem.Columns["I_Allocate_Cmbx"];
                GV_I_Allocate_Cmbx.DataSource = DS.Tables[16];
                GV_I_Allocate_Cmbx.DisplayMember = "Allocate";
                GV_I_Allocate_Cmbx.ValueMember = "Number";

                //GV_ExpenseItem.DataSource = DS.Tables[17];
                RGV_ExpenseItem.DataSource = DS.Tables[17];
            }
        }

        private void VendorCode_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (VendorCode_Cmbx.SelectedValue.ToString() != "")
            {
                P_DTO.VendorCode = Convert.ToInt64(VendorCode_Cmbx.SelectedValue);
                P_DTO.Id = 202;
                DS = P_DAO.PurchaseDB(P_DTO);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    VendorName_Txt.Text = DS.Tables[0].Rows[0]["VendorName"].ToString();
                    Address_rtxt.Text = DS.Tables[0].Rows[0]["Address"].ToString();
                    City_Txt.Text = DS.Tables[0].Rows[0]["City"].ToString();
                    State_Txt.Text = DS.Tables[0].Rows[0]["State"].ToString();
                    Country_Txt.Text = DS.Tables[0].Rows[0]["Country"].ToString();
                    Pincode_Txt.Text = DS.Tables[0].Rows[0]["PIN"].ToString();
                    GST_Txt.Text = DS.Tables[0].Rows[0]["GSTIN"].ToString();
                    PAN_Txt.Text = DS.Tables[0].Rows[0]["PAN"].ToString();
                    Currency_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["Currency"].ToString();
                }
            }
        }

        private void CalenderPic_Click(object sender, EventArgs e)
        {
            Po_Date_Cal.Visible = true;
        }
        private void Po_Date_Cal_Leave(object sender, EventArgs e)
        {
            Po_Date_Cal.Visible = false;
        }
        private void PoDate_dt_Leave(object sender, EventArgs e)
        {
            try
            {
                PoDate_dt.Text = Convert.ToDateTime(PoDate_dt.Text.ToString()).ToString("dd-MM-yyyy");
                Po_Date_Cal.Visible = false;
            }
            catch
            {
            }
        }
        private void Po_Date_Cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            PoDate_dt.Text = Po_Date_Cal.SelectionStart.ToShortDateString();
            Po_Date_Cal.Visible = false;
        }

        //GV_Item
        private void GV_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                try
                {
                    switch (GV_Item.Columns[e.ColumnIndex].Name)
                    {
                        case "DeliveryDate_dt":
                            Rect = GV_Item.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                            myCal.Left = Rect.Left;
                            myCal.Top = Rect.Bottom + 5;

                            PBox.Image = Properties.Resources.calender;
                            PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                            PBox.Size = new Size(25, Rect.Height);
                            PBox.Visible = true;
                            break;
                    }
                }
                catch { }

                if (GV_Item.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        GV_Item.Rows.RemoveAt(e.RowIndex);
                    }
                    catch { }
                }
            }
        }
        private void GV_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_Item.Columns[e.ColumnIndex].Name == "Expense_Btn")
            {
                if (Va.RequiredFields(this) == 1)
                {
                }
                else
                {
                    ExpenseItemPopUp.Dock = DockStyle.Fill;
                    ExpenseItemPopUp.Visible = true;
                    Btn_Expense.Visible = false;
                    Po_Date_Cal.Visible = false;
                    CalenderPic.Visible = false;
                    Btn_Update.Visible = false;
                    Btn_Cancel.Visible = false;

                    string searchValue = Convert.ToString(GV_Item.Rows[e.RowIndex].Cells["ItemCode_Cmbx"].Value);
                    PO_ItemNo.Text = searchValue;

                    GV_ExpenseItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        for (int i = 0; i < GV_ExpenseItem.Rows.Count; i++)
                        {
                            if (GV_ExpenseItem.Rows[i].Cells["PO_ItemLineNo_Txt"].Value != null && GV_ExpenseItem.Rows[i].Cells["PO_ItemLineNo_Txt"].Value.ToString().Equals(searchValue))
                            {
                                GV_ExpenseItem.Rows[i].Visible = true;
                            }
                            else
                            {
                                //CurrencyManager currencyManager = (CurrencyManager)BindingContext[GV_ExpenseItem.DataSource];
                                //currencyManager.SuspendBinding();
                                GV_ExpenseItem.Rows[i].Visible = false;
                                //currencyManager.ResumeBinding();
                            }
                        }
                    }
                    catch
                    {
                    }
                    ////try
                    ////{
                    //foreach (DataGridViewRow row in GV_ExpenseItem.Rows)
                    //    {
                    //        if (row.Cells["PO_ItemLineNo_Txt"].Value != null && row.Cells["PO_ItemLineNo_Txt"].Value.ToString().Equals(searchValue))
                    //        {
                    //            row.Visible = true;
                    //        }
                    //        else
                    //        {
                    //            row.Visible = false;
                    //        }
                    //    }
                    ////}
                    ////catch (Exception ex)
                    ////{
                    ////}
                }
            }
        }
        private void GV_Item_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_Item.Columns[e.ColumnIndex].Name.Equals("ItemCode_Cmbx"))
            {
                if (e.RowIndex >= 0)
                {
                    object selectedValue = GV_Item.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (selectedValue != null)
                    {
                        P_DTO.ItemCode = Convert.ToInt64(selectedValue);
                        P_DTO.Id = 3;
                        DS = P_DAO.PurchaseDB(P_DTO);
                        if (DS.Tables[0].Rows.Count > 0)
                        { 
                            GV_Item.Rows[e.RowIndex].Cells["ItemDescription_Txt"].Value = DS.Tables[0].Rows[0]["ItemDescription"].ToString();
                            GV_Item.Rows[e.RowIndex].Cells["ItemGroup_Txt"].Value = DS.Tables[0].Rows[0]["ItemGroup"].ToString();
                            if (DS.Tables[0].Rows[0]["UoM"].ToString() != "")
                            {
                                GV_Item.Rows[e.RowIndex].Cells["UoM_Cmbx"].Value = DS.Tables[0].Rows[0]["UoM"].ToString();
                            }
                        }
                    }
                }
            }

            if (GV_Item.Columns[e.ColumnIndex].Name.Equals("UnitPrice_Txt"))
            {
                object Unit = GV_Item.Rows[e.RowIndex].Cells["UnitPrice_Txt"].Value;
                if (Unit == DBNull.Value)
                {
                }
                else if (GV_Item.Columns[e.ColumnIndex].Name.Equals("Qty_Txt"))
                {
                    object Qty = GV_Item.Rows[e.RowIndex].Cells["Qty_Txt"].Value;
                    if (Qty == DBNull.Value)
                    {
                    } 
                }
                else
                {
                    foreach (DataGridViewRow row in GV_Item.Rows)
                    {
                        row.Cells[GV_Item.Columns["Amount_Txt"].Index].Value = Convert.ToDouble(row.Cells["Qty_Txt"].Value) * Convert.ToDouble(row.Cells[GV_Item.Columns["UnitPrice_Txt"].Index].Value);
                    }
                }
            }

            switch (GV_Item.Columns[e.ColumnIndex].Name)
            {
                case "DeliveryDate_dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GV_Item.Rows[e.RowIndex].Cells["DeliveryDate_dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GV_Item.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GV_Item.CurrentCell.Value = "";
                        MessageBox.Show("DeliveryDate Correct Format");
                    }
                    break;
            }
        }
        private void GV_Item_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void PBox_Click(object sender, EventArgs e)
        {
            myCal.Visible = !myCal.Visible;
            myCal.Focus();
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            GV_Item.CurrentCell.Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            myCal.Visible = false;
        }
        private void MonthCalendar_Leave(object sender, EventArgs e)
        {
            myCal.Visible = false;
        }
        private void GV_Item_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in GV_Item.Rows)
            {
                if (Convert.ToString(row.Cells["ItemCode_Cmbx"].Value) != "")
                {
                    var selectedValue = row.Cells["ItemCode_Cmbx"].Value.ToString();

                    DataSet Ds1 = new DataSet();
                    P_DTO.ItemCode = Convert.ToInt64(selectedValue);
                    P_DTO.Id = 203;
                    Ds1 = P_DAO.PurchaseDB(P_DTO);

                    row.Cells["ItemDescription_Txt"].Value = Ds1.Tables[0].Rows[0]["ItemDescription"].ToString();
                    row.Cells["ItemGroup_Txt"].Value = Ds1.Tables[0].Rows[0]["ItemGroup"].ToString();
                }
            }
        }

        //RGV_Item
        private void RGV_Item_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column is GridViewTextBoxColumn TextColumn)
            {
                RadTextBoxEditor TextEditor = this.RGV_Item.ActiveEditor as RadTextBoxEditor;
                if (TextEditor != null)
                {
                    RadTextBoxEditorElement TextElement = (RadTextBoxEditorElement)TextEditor.EditorElement;
                    TextElement.Name = TextColumn.Name;
                    TextElement.TextChanged += new EventHandler(RGV_Item_Txt_TextChanged);
                }
            }
        }
        private void RGV_Item_ValueChanged(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RGV_Item.CurrentRow;

            if (this.RGV_Item.ActiveEditor is RadDropDownListEditor dropDownListEditor)
            {
                RadDropDownListEditorElement RRR = (RadDropDownListEditorElement)dropDownListEditor.EditorElement;
                GridComboBoxCellElement RRE = (GridComboBoxCellElement)RRR.Parent;
                GridViewComboBoxColumn GCB = (GridViewComboBoxColumn)RRE.Data;

                if (Convert.ToString(this.RGV_Item.ActiveEditor.Value) != "" && GCB.Name == "ItemCode_Cmbx")
                {
                    String ICode = Convert.ToString(this.RGV_Item.ActiveEditor.Value);
                    if (ICode != null)
                    {
                        P_DTO.ItemCode = Convert.ToInt64(ICode);
                        P_DTO.Id = 3;
                        DS = P_DAO.PurchaseDB(P_DTO);
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            currentRow.Cells["ItemDescription_Txt"].Value = DS.Tables[0].Rows[0]["ItemDescription"].ToString();
                            currentRow.Cells["ItemGroup_Txt"].Value = DS.Tables[0].Rows[0]["ItemGroup"].ToString();
                            if (DS.Tables[0].Rows[0]["UoM"].ToString() != "")
                            {
                                //currentRow.Cells["UoM_Cmbx"].Value = DS.Tables[0].Rows[0]["UoM"].ToString();
                            }
                        }
                    }
                    
                }
            }
        }
        public void RGV_Item_Txt_TextChanged(object sender, EventArgs e)
        {
            Double Qty = 0;
            Double Unit = 0;
            RadTextBoxEditorElement TTB = (RadTextBoxEditorElement)sender;
            if (TTB.Name == "Qty_Txt")
            {
                GridViewRowInfo currentRow = RGV_Item.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Qty = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);

                    Unit = Convert.ToDouble(currentRow.Cells["UnitPrice_Txt"].Value == DBNull.Value ? null : currentRow.Cells["UnitPrice_Txt"].Value);
                    Double Amount = Qty * Unit;

                    currentRow.Cells["Amount_Txt"].Value = Amount;
                }
            }
            else if (TTB.Name == "UnitPrice_Txt")
            {
                GridViewRowInfo currentRow = RGV_Item.CurrentRow;
                if (!string.IsNullOrEmpty(((RadTextBoxEditorElement)sender).Text))
                {
                    Unit = Convert.ToDouble(((RadTextBoxEditorElement)sender).Text);
                    Qty = Convert.ToDouble(currentRow.Cells["Qty_Txt"].Value == DBNull.Value ? null : currentRow.Cells["Qty_Txt"].Value);

                    Double Amount = Qty * Unit;
                    currentRow.Cells["Amount_Txt"].Value = Amount;

                }
            }
        }
        private void RGV_Item_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            GridViewRowInfo currentRow = RGV_Item.CurrentRow;

            GridViewRowInfo row = RGV_ExpenseItem.CurrentRow;

            if (RGV_Item.Columns[e.ColumnIndex].Name == "Expense_Cmd")
            {
                string searchValue = Convert.ToString(currentRow.Cells["ItemCode_Cmbx"].Value);
                PO_ItemNo.Text = searchValue;

                RGV_ExpenseItem.SelectionMode = GridViewSelectionMode.FullRowSelect;
                try
                {
                    for (int i = 0; i < RGV_ExpenseItem.Rows.Count; i++)
                    {
                        if (RGV_ExpenseItem.Rows[i].Cells["PO_ItemLineNo_Txt"].Value != null && RGV_ExpenseItem.Rows[i].Cells["PO_ItemLineNo_Txt"].Value.ToString().Equals(searchValue))
                        {
                            RGV_ExpenseItem.Rows[i].IsVisible = true;
                        }
                        else
                        {
                            RGV_ExpenseItem.Rows[i].IsVisible = false;
                        }
                    }
                }
                catch
                {
                }
            }
            if (row != null)
            {
                Int64 valueToSet = Convert.ToInt64(PO_ItemNo.Text);
                row.Cells["PO_ItemLineNo_Txt"].Value = valueToSet;
            }
        }

        //GV_ExpenseHead
        private void Btn_Expense_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                ExpensePopUp.Visible = true;
                ExpensePopUp.Dock = DockStyle.Fill;
                Po_Date_Cal.Visible = false;
                CalenderPic.Visible = false;
                Btn_Update.Visible = false;
                Btn_Cancel.Visible = false;
            }
        }
        private void GV_ExpenseHead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_ExpenseHead.Columns[e.ColumnIndex].Name == "H_Delete")
            {
                try
                {
                    GV_ExpenseHead.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_ExpenseHead_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                if (GV_ExpenseHead.Columns[e.ColumnIndex].Name.Equals("H_ExpenseCode_Cmbx"))
                {
                    if (e.RowIndex >= 0)
                    {
                        object selectedValue = GV_ExpenseHead.Rows[e.RowIndex].Cells["H_ExpenseCode_Cmbx"].Value;

                        if (selectedValue != null)
                        {
                            P_DTO.ExpenseCode = Convert.ToInt64(selectedValue);
                            P_DTO.Id = 204;
                            DS = P_DAO.PurchaseDB(P_DTO);
                            GV_ExpenseHead.Rows[e.RowIndex].Cells["H_EC_Description_Txt"].Value = DS.Tables[0].Rows[0]["EC_Description"].ToString();
                            GV_ExpenseHead.Rows[e.RowIndex].Cells["H_LedgerAccount_Txt"].Value = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                            GV_ExpenseHead.Rows[e.RowIndex].Cells["H_LedgerName_Txt"].Value = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                        }
                    }
                }
            //}
            //catch { }
        }
        private void GV_ExpenseHead_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void GV_ExpenseHead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow row in GV_ExpenseHead.Rows)
            //{
            //    if (Convert.ToString(row.Cells["H_ExpenseCode_Cmbx"].Value) != "")
            //    {
            //        var selectedValue = row.Cells["H_ExpenseCode_Cmbx"].Value.ToString();

            //        DataSet Ds1 = new DataSet();
            //        P_DTO.ExpenseCode = Convert.ToInt64(selectedValue);
            //        P_DTO.Id = 204;
            //        Ds1 = P_DAO.PurchaseDB(P_DTO);

            //        row.Cells["H_EC_Description_Txt"].Value = Ds1.Tables[0].Rows[0]["EC_Description"].ToString();
            //        row.Cells["H_LedgerAccount_Txt"].Value = Ds1.Tables[0].Rows[0]["LedgerAccount"].ToString();
            //        row.Cells["H_LedgerName_Txt"].Value = Ds1.Tables[0].Rows[0]["LedgerName"].ToString();
            //    }
            //}
        }
        private void ExpenseCloseButton_Click(object sender, EventArgs e)
        {
            ExpensePopUp.Visible = false;
            CalenderPic.Visible = true;
            Btn_Update.Visible = true;
            Btn_Cancel.Visible = true;
        }

        //RGV_ExpenseHead
        private void RGV_ExpenseHead_ValueChanged(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RGV_ExpenseHead.CurrentRow;

            if (this.RGV_ExpenseHead.ActiveEditor is RadDropDownListEditor dropDownListEditor)
            {
                RadDropDownListEditorElement RRR = (RadDropDownListEditorElement)dropDownListEditor.EditorElement;
                GridComboBoxCellElement RRE = (GridComboBoxCellElement)RRR.Parent;
                GridViewComboBoxColumn GCB = (GridViewComboBoxColumn)RRE.Data;

                if (Convert.ToString(this.RGV_ExpenseHead.ActiveEditor.Value) != "" && GCB.Name == "H_ExpenseCode_Cmbx")
                {
                    String ECode = Convert.ToString(this.RGV_ExpenseHead.ActiveEditor.Value);
                    if (ECode != null)
                    {
                        P_DTO.ExpenseCode = Convert.ToInt64(ECode);
                        P_DTO.Id = 204;
                        DS = P_DAO.PurchaseDB(P_DTO);
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            currentRow.Cells["H_EC_Description_Txt"].Value = DS.Tables[0].Rows[0]["EC_Description"].ToString();
                            //currentRow.Cells["H_LedgerAccount_Txt"].Value = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                            //currentRow.Cells["H_LedgerName_Txt"].Value = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                        }
                    }
                }
                if (Convert.ToString(this.RGV_ExpenseHead.ActiveEditor.Value) != "" && GCB.Name == "H_Allocate_Cmbx")
                {
                    if (Convert.ToInt64(this.RGV_ExpenseHead.ActiveEditor.Value) == 1)
                    {
                        currentRow.Cells["H_LedgerAccount_Txt"].Value = Convert.ToString(currentRow.Cells["H_LedgerAccount_Txt"].Value = "");
                        currentRow.Cells["H_LedgerName_Txt"].Value = Convert.ToString(currentRow.Cells["H_LedgerName_Txt"].Value = "");
                    }
                    else
                    {
                        currentRow.Cells["H_LedgerAccount_Txt"].Value = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                        currentRow.Cells["H_LedgerName_Txt"].Value = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                    }
                }
            }
        }

        //GV_ExpenseItem
        private void GV_ExpenseItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_ExpenseItem.Columns[e.ColumnIndex].Name == "I_Delete")
            {
                try
                {
                    GV_ExpenseItem.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_ExpenseItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            if (GV_ExpenseItem.Columns[e.ColumnIndex].Name.Equals("I_ExpenseCode_Cmbx"))
            {
                if (e.RowIndex >= 0)
                {
                    object selectedValue = GV_ExpenseItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (selectedValue != null)
                    {
                        P_DTO.ExpenseCode = Convert.ToInt64(selectedValue);
                        P_DTO.Id = 205;
                        DS = P_DAO.PurchaseDB(P_DTO);
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            GV_ExpenseItem.Rows[e.RowIndex].Cells["I_EC_Description_Txt"].Value = DS.Tables[0].Rows[0]["EC_Description"].ToString();
                            GV_ExpenseItem.Rows[e.RowIndex].Cells["I_LedgerAccount_Txt"].Value = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                            GV_ExpenseItem.Rows[e.RowIndex].Cells["I_LedgerName_Txt"].Value = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                        }
                    }
                }
            }
            Int64 valueToSet = Convert.ToInt64(PO_ItemNo.Text);
            if (GV_ExpenseItem.CurrentRow != null)
            {
                GV_ExpenseItem.CurrentRow.Cells[1].Value = valueToSet;
            }
            //}
            //catch { }
        }
        private void GV_ExpenseItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void GV_ExpenseItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in GV_ExpenseItem.Rows)
            {
                if (Convert.ToString(row.Cells["I_ExpenseCode_Cmbx"].Value) != "")
                {
                    var selectedValue = row.Cells["I_ExpenseCode_Cmbx"].Value.ToString();

                    DataSet Ds4 = new DataSet();
                    P_DTO.ExpenseCode = Convert.ToInt64(selectedValue);
                    P_DTO.Id = 205;
                    Ds4 = P_DAO.PurchaseDB(P_DTO);

                    row.Cells["I_EC_Description_Txt"].Value = Ds4.Tables[0].Rows[0]["EC_Description"].ToString();
                    row.Cells["I_LedgerAccount_Txt"].Value = Ds4.Tables[0].Rows[0]["LedgerAccount"].ToString();
                    row.Cells["I_LedgerName_Txt"].Value = Ds4.Tables[0].Rows[0]["LedgerName"].ToString();
                }
            }
        }
        //RGV_ExpenseItem
        private void RGV_ExpenseItem_ValueChanged(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RGV_ExpenseItem.CurrentRow;

            if (this.RGV_ExpenseItem.ActiveEditor is RadDropDownListEditor dropDownListEditor)
            {
                RadDropDownListEditorElement RRR = (RadDropDownListEditorElement)dropDownListEditor.EditorElement;
                GridComboBoxCellElement RRE = (GridComboBoxCellElement)RRR.Parent;
                GridViewComboBoxColumn GCB = (GridViewComboBoxColumn)RRE.Data;

                if (Convert.ToString(this.RGV_ExpenseItem.ActiveEditor.Value) != "" && GCB.Name == "I_ExpenseCode_Cmbx")
                {
                    String ECode = Convert.ToString(this.RGV_ExpenseItem.ActiveEditor.Value);
                    if (ECode != null)
                    {
                        P_DTO.ExpenseCode = Convert.ToInt64(ECode);
                        P_DTO.Id = 205;
                        DS = P_DAO.PurchaseDB(P_DTO);
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            currentRow.Cells["I_EC_Description_Txt"].Value = DS.Tables[0].Rows[0]["EC_Description"].ToString();
                            currentRow.Cells["I_LedgerAccount_Txt"].Value = DS.Tables[0].Rows[0]["LedgerAccount"].ToString();
                            currentRow.Cells["I_LedgerName_Txt"].Value = DS.Tables[0].Rows[0]["LedgerName"].ToString();
                        }
                    }
                }
            }
        }
        
        private void ItemExpenseCloseButton_Click(object sender, EventArgs e)
        {
            ExpenseItemPopUp.Visible = false;
            Btn_Expense.Visible = true;
            CalenderPic.Visible = true;
            Btn_Update.Visible = true;
            Btn_Cancel.Visible = true;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (RGV_Item.Rows.Count == 1)
                {
                    Acc = 0;
                    MessageBox.Show("Required Atleast One item");
                }
                else if (Acc == 1)
                {
                    var list = new List<String>();
                    var list1 = new List<String>();
                    var list2 = new List<String>();

                    for (int i = 0; i < RGV_ExpenseHead.Rows.Count - 1; i++)
                    {
                        String ExpenseCode = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_ExpenseCode_Cmbx"].Value);
                        String Remarks = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Remarks_Rtxt"].Value);
                        String Occurrence = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Occurrence_Cmbx"].Value);
                        String ChargeableMethod = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_ChargeableMethod_Cmbx"].Value);
                        String ExpenseBase = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_ExpenseBase_Txt"].Value);
                        String Allocate = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Allocate_Cmbx"].Value);

                        String Code = "";
                        if (ExpenseCode.Trim().Length > 0)
                        {
                            if (RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value != null && RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value.ToString());
                            }
                            list.Add(Code);
                        }

                        if (ExpenseCode.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ExpenseCode is Required");
                            break;
                        }
                        else if (Remarks.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Remarks is Required");
                            break;
                        }
                        else if (Occurrence.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Occurrence is Required");
                            break;
                        }
                        else if (ChargeableMethod.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ChargeableMethod is Required");
                            break;
                        }
                        else if (ExpenseBase.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ExpenseBase is Required");
                            break;
                        }
                        else if (ExpenseBase.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ExpenseBase is Required");
                            break;
                        }
                        else if (Allocate.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Allocate is Required");
                            break;
                        }
                    }
                    for (int i = 0; i < RGV_ExpenseItem.Rows.Count-1; i++)
                    {
                        String ExpenseCode = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_ExpenseCode_Cmbx"].Value);
                        String Remarks = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_Remarks_Rtxt"].Value);
                        String Occurrence = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_Occurrence_Cmbx"].Value);
                        String ChargeableMethod = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_ChargeableMethod_Cmbx"].Value);
                        String ExpenseBase = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_ExpenseBase_Txt"].Value);
                        String Allocate = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_Allocate_Cmbx"].Value);

                        String Code = "";
                        if (ExpenseCode.Trim().Length > 0)
                        {
                            if (RGV_ExpenseItem.Rows[i].Cells["I_Number"].Value != null && RGV_ExpenseItem.Rows[i].Cells["I_Number"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(RGV_ExpenseItem.Rows[i].Cells["I_Number"].Value.ToString());
                            }
                            list1.Add(Code);
                        }

                        else if (ExpenseCode.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ExpenseCode is Required");
                            break;
                        }
                        else if (Remarks.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Remarks is Required");
                            break;
                        }
                        else if (Occurrence.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Occurrence is Required");
                            break;
                        }
                        else if (ChargeableMethod.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ChargeableMethod is Required");
                            break;
                        }
                        else if (ExpenseBase.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ExpenseBase is Required");
                            break;
                        }
                        else if (Allocate.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Allocate is Required");
                            break;
                        }
                    }
                    for (int i = 0; i < RGV_Item.Rows.Count; i++)
                    {
                        String ItemCode = Convert.ToString(RGV_Item.Rows[i].Cells["ItemCode_Cmbx"].Value);
                        String UoM = Convert.ToString(RGV_Item.Rows[i].Cells["UoM_Cmbx"].Value);
                        String PO_Qty = Convert.ToString(RGV_Item.Rows[i].Cells["Qty_Txt"].Value);
                        String UnitPrice = Convert.ToString(RGV_Item.Rows[i].Cells["UnitPrice_Txt"].Value);
                        String Amount = Convert.ToString(RGV_Item.Rows[i].Cells["Amount_Txt"].Value);
                        String DeliveryDate = Convert.ToString(RGV_Item.Rows[i].Cells["DeliveryDate_dt"].Value);

                        String Code = "";
                        if (ItemCode.Trim().Length > 0)
                        {
                            if (RGV_Item.Rows[i].Cells["PO_LineNo_Txt"].Value != null && RGV_Item.Rows[i].Cells["PO_LineNo_Txt"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(RGV_Item.Rows[i].Cells["PO_LineNo_Txt"].Value.ToString());
                            }
                            list2.Add(Code);
                        }
                        if (ItemCode.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ItemCode is Required");
                            break;
                        }
                        else if (UoM.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("UoM is Required");
                            break;
                        }
                        else if (PO_Qty.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("PO_Qty is Required");
                            break;
                        }
                        else if (UnitPrice.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("UnitPrice is Required");
                            break;
                        }
                        else if (Amount.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("Amount is Required");
                            break;
                        }
                        else if (DeliveryDate.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("DeliveryDate is Required");
                            break;
                        }
                    }
                    if (Acc == 1)
                    {
                        P_DTO.PurchaseNumber = Convert.ToInt64(PurchaseNumber_Txt.Text);
                        P_DTO.Search = String.Join(",", list);
                        P_DTO.PaymentMethod = String.Join(",", list1);
                        P_DTO.PaymentTerms = String.Join(",", list2);
                        P_DTO.Id = 213;
                        DS = P_DAO.PurchaseDB(P_DTO);

                        P_DTO.PurchaseOrderNo = PurchaseOrderNo_Txt.Text;
                        P_DTO.PoDate = Convert.ToInt32(Convert.ToDateTime(PoDate_dt.Text).ToString("yyyyMMdd"));
                        if (IsImportOrder_ckbx.Checked == true)
                        {
                            P_DTO.IsImportOrder = 1;
                        }
                        else
                        {
                            P_DTO.IsImportOrder = 0;
                        }
                        P_DTO.VendorCode = Convert.ToInt64(VendorCode_Cmbx.SelectedValue);
                        P_DTO.Currency = Convert.ToInt64(Currency_Cmbx.SelectedValue == null ? 1 : Currency_Cmbx.SelectedValue);
                        P_DTO.MaterialSegregation = Convert.ToInt64(MaterialSegragation_Cmbx.SelectedValue == null ? 1 : MaterialSegragation_Cmbx.SelectedValue);
                        P_DTO.PaymentTerms = PaymentTerms_Txt.Text;
                        P_DTO.PaymentMethod = PaymentMethod_Txt.Text;
                        P_DTO.DeliveryTerms = DeliveryTerms_Txt.Text;
                        P_DTO.DeliveryMode = DeliveryMode_Txt.Text;
                        P_DTO.Tax = Tax_rtxt.Text;
                        P_DTO.Inspection = Inspection_rtxt.Text;
                        P_DTO.TechnicalDeliveryConditions = TechnicalDeliveryConditions_rtxt.Text;
                        P_DTO.Remarks = Remarks_rtxt.Text;
                        P_DTO.Id = 206;
                        DS = P_DAO.PurchaseDB(P_DTO);

                        String Code = "";
                        for (int j = 0; j < RGV_Item.Rows.Count; j++)
                        {
                            if (RGV_Item.Rows[j].Cells["PO_LineNo_Txt"].Value != null)
                            {
                                Code = Convert.ToString(RGV_Item.Rows[j].Cells["PO_LineNo_Txt"].Value.ToString());
                            }
                            P_DTO.ItemCode = Convert.ToInt64(RGV_Item.Rows[j].Cells["ItemCode_Cmbx"].Value.ToString());
                            P_DTO.UoM = Convert.ToInt64(RGV_Item.Rows[j].Cells["UoM_Cmbx"].Value.ToString());
                            P_DTO.PO_Qty = Convert.ToDouble(RGV_Item.Rows[j].Cells["Qty_Txt"].Value.ToString());
                            P_DTO.UnitPrice = Convert.ToDouble(RGV_Item.Rows[j].Cells["UnitPrice_Txt"].Value.ToString());
                            P_DTO.Amount = Convert.ToDouble(RGV_Item.Rows[j].Cells["Amount_Txt"].Value.ToString());
                            P_DTO.DeliveryDate = Convert.ToInt32(Convert.ToDateTime(RGV_Item.Rows[j].Cells["DeliveryDate_dt"].Value).ToString("yyyyMMdd"));

                            if (Code == null || Code == "")
                            {
                                P_DTO.Id = 207;
                            }
                            else
                            {
                                P_DTO.Number = Convert.ToInt64(Code);
                                P_DTO.Id = 208;
                            }
                            DS = P_DAO.PurchaseDB(P_DTO);
                        }
                        for (int i = 0; i < RGV_ExpenseHead.Rows.Count-1; i++)
                        {
                            if (RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value != null)
                            {
                                Code = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value.ToString());
                            }
                            P_DTO.ExpenseCode = Convert.ToInt64(RGV_ExpenseHead.Rows[i].Cells["H_ExpenseCode_Cmbx"].Value.ToString());
                            P_DTO.Remarks = Convert.ToString(RGV_ExpenseHead.Rows[i].Cells["H_Remarks_Rtxt"].Value.ToString());
                            P_DTO.Occurrence = Convert.ToInt64(RGV_ExpenseHead.Rows[i].Cells["H_Occurrence_Cmbx"].Value.ToString());
                            P_DTO.ChargeableMethod = Convert.ToInt64(RGV_ExpenseHead.Rows[i].Cells["H_ChargeableMethod_Cmbx"].Value.ToString());
                            P_DTO.ExpenseBase = Convert.ToDouble(RGV_ExpenseHead.Rows[i].Cells["H_ExpenseBase_Txt"].Value.ToString());
                            P_DTO.Allocate = Convert.ToInt64(RGV_ExpenseHead.Rows[i].Cells["H_Allocate_Cmbx"].Value.ToString());

                            if (Code == null || Code == "")
                            {
                                P_DTO.Id = 209;
                            }
                            else
                            {
                                P_DTO.Number = Convert.ToInt64(RGV_ExpenseHead.Rows[i].Cells["H_Number"].Value.ToString());
                                P_DTO.Id = 210;
                            }
                            DS = P_DAO.PurchaseDB(P_DTO);
                        }
                        for (int j = 0; j < RGV_ExpenseItem.Rows.Count; j++)
                        {
                            if (RGV_ExpenseItem.Rows[j].Cells["I_Number"].Value != null)
                            {
                                Code = Convert.ToString(RGV_ExpenseItem.Rows[j].Cells["I_Number"].Value.ToString());
                            }
                            P_DTO.ExpenseCode = Convert.ToInt64(RGV_ExpenseItem.Rows[j].Cells["I_ExpenseCode_Cmbx"].Value.ToString());
                            P_DTO.Remarks = Convert.ToString(RGV_ExpenseItem.Rows[j].Cells["I_Remarks_Rtxt"].Value.ToString());
                            P_DTO.Occurrence = Convert.ToInt64(RGV_ExpenseItem.Rows[j].Cells["I_Occurrence_Cmbx"].Value.ToString());
                            P_DTO.ChargeableMethod = Convert.ToInt64(RGV_ExpenseItem.Rows[j].Cells["I_ChargeableMethod_Cmbx"].Value.ToString());
                            P_DTO.ExpenseBase = Convert.ToDouble(RGV_ExpenseItem.Rows[j].Cells["I_ExpenseBase_Txt"].Value.ToString());
                            P_DTO.Allocate = Convert.ToInt64(RGV_ExpenseItem.Rows[j].Cells["I_Allocate_Cmbx"].Value.ToString());

                            if (Code == null || Code == "")
                            {
                                P_DTO.Id = 211;
                            }
                            else
                            {
                                P_DTO.Number = Convert.ToInt64(RGV_ExpenseItem.Rows[j].Cells["I_Number"].Value.ToString());
                                P_DTO.Id = 212;
                            }
                            DS = P_DAO.PurchaseDB(P_DTO);
                        }
                        MessageBox.Show(Alert.Edit());
                    }
                }
            }
        }
        
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(RGV_Item.Rows.Count));
            //PurchaseList purchaseList = new PurchaseList();
            //purchaseList.Show();
        }
    }
}
