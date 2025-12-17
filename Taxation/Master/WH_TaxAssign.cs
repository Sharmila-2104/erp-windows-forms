using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Tax.Master;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ERP.Purchase.Tax
{
    public partial class WithHoldTaxAssign : Form
    {
        WH_TaxAssign_DTO WTA_DTO = new WH_TaxAssign_DTO();
        WH_TaxAssign_DAO WTA_DAO = new WH_TaxAssign_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        DataSet DS = new DataSet();
        Validation Va = new Validation();

        MonthCalendar myCal = new MonthCalendar();
        PictureBox PBox = new PictureBox();
        Rectangle Rect = new Rectangle();
        public WithHoldTaxAssign()
        {
            InitializeComponent();
            Eve.FormController(this);
            
            MainPanel.Dock = DockStyle.Fill;
            PanelList.Visible = false;

            RGV_List.CommandCellClick += RGV_List_CommandCellClick;
            RGV_List.CellFormatting += RGV_List_CellFormatting;

            Btn_Save.Click += new EventHandler(Btn_Save_Click);
            Btn_Create.Click += new EventHandler(Btn_Create_Click);
            Btn_Clear.Click += new EventHandler(Btn_Clear_Click);
            Btn_Back.Click += new EventHandler(Btn_Back_Click);
            Btn_Update.Click += new EventHandler(Btn_Update_Click);
            WH_TaxCode_Cmbx.SelectionChangeCommitted += new EventHandler(WH_TaxCode_Cmbx_SelectionChangeCommitted);
        }
        private void WithHoldTaxAssign_Load(object sender, EventArgs e)
        {
            GetData();
        }
        void GetList()
        {
            WTA_DTO.Id = 11;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
            RGV_List.DataSource = DS.Tables[0];
        }

        private void WH_TaxCode_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (WH_TaxCode_Cmbx.SelectedValue.ToString() != "")
            {
                WTA_DTO.WH_TaxCode = Convert.ToInt64(WH_TaxCode_Cmbx.SelectedValue);
                WTA_DTO.Id = 7;
                DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                WH_TaxDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["WH_TaxDescription"].ToString();
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
                        WTA_DTO.WH_TaxAssignNumber = Convert.ToInt32(currentRow.Cells["WH_TaxAssignNumber"].Value);
                        WTA_DTO.Id = 12;
                        DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                        MessageBox.Show(Alert.Delete());
                    }
                    catch
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
            }
            else if (RGV_List.Columns[e.ColumnIndex].Name == "Edit_Cmd")
            {
                WTA_DTO.WH_TaxAssignNumber = Convert.ToInt64(currentRow.Cells["WH_TaxAssignNumber"].Value);
                WTA_DTO.Id = 3;
                DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    WH_TaxCode_Cmbx.DataSource = DS.Tables[2];
                    WH_TaxCode_Cmbx.ValueMember = "WithholdtaxNumber";
                    WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";

                    WH_TaxAssignNumber_Txt.Text = DS.Tables[0].Rows[0]["WH_TaxAssignNumber"].ToString();
                    WH_TaxCode_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["WH_TaxCode"].ToString();
                    WH_TaxDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["Des"].ToString();

                    //RGV_DetailsList
                    GridViewComboBoxColumn GV_AssesseeNature_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["AssesseeNature_Cmbx"];
                    GV_AssesseeNature_Cmbx.DataSource = DS.Tables[3];
                    GV_AssesseeNature_Cmbx.DisplayMember = "Nature";
                    GV_AssesseeNature_Cmbx.ValueMember = "Number";

                    GridViewComboBoxColumn GV_IncludeTax_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["IncludeTax_Cmbx"];
                    GV_IncludeTax_Cmbx.DataSource = DS.Tables[4];
                    GV_IncludeTax_Cmbx.DisplayMember = "Include";
                    GV_IncludeTax_Cmbx.ValueMember = "Number";

                    GridViewComboBoxColumn GV_COA_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["COA_Cmbx"];
                    GV_COA_Cmbx.DataSource = DS.Tables[5];
                    GV_COA_Cmbx.DisplayMember = "LedgerAccount";
                    GV_COA_Cmbx.ValueMember = "LedgerNumber";

                    RGV_DetailsList.DataSource = DS.Tables[1];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;

                    WH_TaxCode_Cmbx.Enabled = false;
                    Btn_Clear.Text = "Cancel";

                    MainPanel.Dock = DockStyle.Fill;
                    MainPanel.Visible = true;
                    MainPanel.BringToFront();
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    PanelList.Dock = DockStyle.Fill;
                    MainPanel.Visible = false;
                }
            }
            GetList();
        }
        private void RGV_List_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;
            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Btn_Clear.Text = Btn_Clear.Tag.ToString();
            Clear();
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Visible = true;
            WH_TaxCode_Cmbx.Enabled = true;
            MainPanel.BringToFront();
            GetData();
        }
        void GetData()
        {
            WTA_DTO.Id = 2;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);

            WH_TaxCode_Cmbx.DataSource = DS.Tables[0];
            WH_TaxCode_Cmbx.ValueMember = "WithholdtaxNumber";
            WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";
            WH_TaxCode_Cmbx.SelectedIndex = -1;

            

            //RGV_DetailsList
            GridViewComboBoxColumn GV_AssesseeNature_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["AssesseeNature_Cmbx"];
            GV_AssesseeNature_Cmbx.DataSource = DS.Tables[1];
            GV_AssesseeNature_Cmbx.DisplayMember = "Nature";
            GV_AssesseeNature_Cmbx.ValueMember = "Number";

           

            GridViewComboBoxColumn GV_IncludeTax_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["IncludeTax_Cmbx"];
            GV_IncludeTax_Cmbx.DataSource = DS.Tables[2];
            GV_IncludeTax_Cmbx.DisplayMember = "Include";
            GV_IncludeTax_Cmbx.ValueMember = "Number";

            GridViewComboBoxColumn GV_COA_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["COA_Cmbx"];
            GV_COA_Cmbx.DataSource = DS.Tables[3];
            GV_COA_Cmbx.DisplayMember = "LedgerAccount";
            GV_COA_Cmbx.ValueMember = "LedgerNumber";

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
            Btn_Clear.Visible = true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Back();
        }
        void Back()
        {
            GetList();

            PanelList.Visible = true;
            PanelList.Dock = DockStyle.Fill;
            MainPanel.Visible = false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (RGV_DetailsList.Rows.Count > 0)
                {
                    for (int i = 0; i < RGV_DetailsList.Rows.Count; i++)
                    {
                        String AssesseeNature = Convert.ToString(RGV_DetailsList.Rows[i].Cells["AssesseeNature_Cmbx"].Value);
                        String FromDate = Convert.ToString(RGV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(RGV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value);
                        String SingleTransLimit = Convert.ToString(RGV_DetailsList.Rows[i].Cells["SingleTransLimit_Txt_Digit"].Value);
                        String AggregateTransLimit = Convert.ToString(RGV_DetailsList.Rows[i].Cells["AggregateTransLimit_Txt_Digit"].Value);
                        String IncludeTax = Convert.ToString(RGV_DetailsList.Rows[i].Cells["IncludeTax_Cmbx"].Value);
                        String PAN_TaxPercent = Convert.ToString(RGV_DetailsList.Rows[i].Cells["PAN_TaxPercent_Txt_Digit"].Value);
                        String NON_PAN_TaxPercent = Convert.ToString(RGV_DetailsList.Rows[i].Cells["NON_PAN_TaxPercent_Txt_Digit"].Value);
                        String COA = Convert.ToString(RGV_DetailsList.Rows[i].Cells["COA_Cmbx"].Value);
                        if (AssesseeNature.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("AssesseeNature is required");
                            break;
                        }
                        else if (FromDate.Trim().Length < 10)
                        {
                            Acc = 0;
                            MessageBox.Show("FromDate is required");
                            break;
                        }
                        else if (ToDate.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ToDate is required");
                            break;
                        }
                        else if (SingleTransLimit.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("SingleTransLimit is required");
                            break;
                        }
                        else if (AggregateTransLimit.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("AggregateTransLimit is required");
                            break;
                        }
                        else if (IncludeTax.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("IncludeTax is required");
                            break;
                        }
                        else if (PAN_TaxPercent.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("PAN_TaxPercent is required");
                            break;
                        }
                        else if (NON_PAN_TaxPercent.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("NON_PAN_TaxPercent is required");
                            break;
                        }
                        else if (COA.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("COA is required");
                            break;
                        }
                        //else
                        //{
                        //    Acc = 0;
                        //    MessageBox.Show("enter required fields");
                        //    break;
                        //}
                    }
                }
                else
                {
                    Acc = 0;
                    MessageBox.Show("enter required fields");
                }

                if (Acc == 1)
                {
                    WTA_DTO.WH_TaxCode = Convert.ToInt64(WH_TaxCode_Cmbx.SelectedValue);
                    WTA_DTO.CreatorCode = 1;
                    WTA_DTO.Id = 1;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                    for (int i = 0; i < RGV_DetailsList.Rows.Count; i++)
                    {
                        WTA_DTO.AssesseeNature = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["AssesseeNature_Cmbx"].Value.ToString());
                        WTA_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(RGV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        WTA_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(RGV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        WTA_DTO.SingleTransLimit = Convert.ToInt32(RGV_DetailsList.Rows[i].Cells["SingleTransLimit_Txt_Digit"].Value.ToString());
                        WTA_DTO.AggregateTransLimit = Convert.ToInt32(RGV_DetailsList.Rows[i].Cells["AggregateTransLimit_Txt_Digit"].Value.ToString());
                        WTA_DTO.IncludeTax = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["IncludeTax_Cmbx"].Value.ToString());
                        WTA_DTO.PAN_TaxPercent = Convert.ToDouble(RGV_DetailsList.Rows[i].Cells["PAN_TaxPercent_Txt_Digit"].Value.ToString());
                        WTA_DTO.NON_PAN_TaxPercent = Convert.ToDouble(RGV_DetailsList.Rows[i].Cells["NON_PAN_TaxPercent_Txt_Digit"].Value.ToString());
                        WTA_DTO.COA = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["COA_Cmbx"].Value.ToString());
                        WTA_DTO.Id = 4;
                        DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                    }
                    MessageBox.Show(Alert.Save());
                    Clear();
                    Back();
                }
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                var list = new List<String>();
                Int32 Acc = 1;
                if (RGV_DetailsList.Rows.Count > 0)
                {
                    for (int i = 0; i < RGV_DetailsList.Rows.Count; i++)
                    {
                        String AssesseeNature = Convert.ToString(RGV_DetailsList.Rows[i].Cells["AssesseeNature_Cmbx"].Value);
                        String FromDate = Convert.ToString(RGV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(RGV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value);
                        String SingleTransLimit = Convert.ToString(RGV_DetailsList.Rows[i].Cells["SingleTransLimit_Txt_Digit"].Value);
                        String AggregateTransLimit = Convert.ToString(RGV_DetailsList.Rows[i].Cells["AggregateTransLimit_Txt_Digit"].Value);
                        String IncludeTax = Convert.ToString(RGV_DetailsList.Rows[i].Cells["IncludeTax_Cmbx"].Value);
                        String PAN_TaxPercent = Convert.ToString(RGV_DetailsList.Rows[i].Cells["PAN_TaxPercent_Txt_Digit"].Value);
                        String NON_PAN_TaxPercent = Convert.ToString(RGV_DetailsList.Rows[i].Cells["NON_PAN_TaxPercent_Txt_Digit"].Value);
                        String COA = Convert.ToString(RGV_DetailsList.Rows[i].Cells["COA_Cmbx"].Value);

                        String Code = "";
                        if (RGV_DetailsList.Rows[i].Cells["WH_TaxAssignDetailsNumber_Txt"].Value != null && RGV_DetailsList.Rows[i].Cells["WH_TaxAssignDetailsNumber_Txt"].Value != System.DBNull.Value)
                        {
                            Code = Convert.ToString(RGV_DetailsList.Rows[i].Cells["WH_TaxAssignDetailsNumber_Txt"].Value.ToString());
                        }
                        list.Add(Code);

                        if (AssesseeNature.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("AssesseeNature is required");
                            break;
                        }
                        else if (FromDate.Trim().Length < 10)
                        {
                            Acc = 0;
                            MessageBox.Show("FromDate is required");
                            break;
                        }
                        else if (ToDate.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("ToDate is required");
                            break;
                        }
                        else if (SingleTransLimit.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("SingleTransLimit is required");
                            break;
                        }
                        else if (AggregateTransLimit.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("AggregateTransLimit is required");
                            break;
                        }
                        else if (IncludeTax.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("IncludeTax is required");
                            break;
                        }
                        else if (PAN_TaxPercent.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("PAN_TaxPercent is required");
                            break;
                        }
                        else if (NON_PAN_TaxPercent.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("NON_PAN_TaxPercent is required");
                            break;
                        }
                        else if (COA.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("COA is required");
                            break;
                        }
                    }
                }
                else
                {
                    Acc = 0;
                    MessageBox.Show("enter required fields");
                }

                if (Acc == 1)
                {
                    WTA_DTO.WH_TaxAssignNumber = Convert.ToInt64(WH_TaxAssignNumber_Txt.Text);
                    WTA_DTO.Search = String.Join(",", list);
                    WTA_DTO.Id = 8;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);

                    String Code = "";
                    for (int i = 0; i < RGV_DetailsList.Rows.Count; i++)
                    {
                        if (RGV_DetailsList.Rows[i].Cells["WH_TaxAssignDetailsNumber_Txt"].Value != null)
                        {
                            Code = Convert.ToString(RGV_DetailsList.Rows[i].Cells["WH_TaxAssignDetailsNumber_Txt"].Value.ToString());
                        }
                        WTA_DTO.WH_TaxAssignNumber = Convert.ToInt64(WH_TaxAssignNumber_Txt.Text);
                        WTA_DTO.AssesseeNature = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["AssesseeNature_Cmbx"].Value.ToString());
                        WTA_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(RGV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        WTA_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(RGV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        WTA_DTO.SingleTransLimit = Convert.ToInt32(RGV_DetailsList.Rows[i].Cells["SingleTransLimit_Txt_Digit"].Value.ToString());
                        WTA_DTO.AggregateTransLimit = Convert.ToInt32(RGV_DetailsList.Rows[i].Cells["AggregateTransLimit_Txt_Digit"].Value.ToString());
                        WTA_DTO.IncludeTax = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["IncludeTax_Cmbx"].Value.ToString());
                        WTA_DTO.PAN_TaxPercent = Convert.ToDouble(RGV_DetailsList.Rows[i].Cells["PAN_TaxPercent_Txt_Digit"].Value.ToString());
                        WTA_DTO.NON_PAN_TaxPercent = Convert.ToDouble(RGV_DetailsList.Rows[i].Cells["NON_PAN_TaxPercent_Txt_Digit"].Value.ToString());
                        WTA_DTO.COA = Convert.ToInt64(RGV_DetailsList.Rows[i].Cells["COA_Cmbx"].Value.ToString());

                        if (Code == null || Code == "")
                        {
                            WTA_DTO.Id = 5;
                        }
                        else
                        {
                            WTA_DTO.WH_TaxAssignDetailsNumber = Convert.ToInt64(Code);
                            WTA_DTO.Id = 6;
                        }
                        DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                    }
                    MessageBox.Show(Alert.Edit());
                    Clear();
                    Back();
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

            while (RGV_DetailsList.Rows.Count > 0)
            {
                RGV_DetailsList.Rows.RemoveAt(0);
            }
            if (Btn_Clear.Text == "Cancel")
            {
                Btn_Clear.Text = Btn_Clear.Tag.ToString();
                Back();
            }
            else
            {
                Btn_Clear.Text = Btn_Clear.Tag.ToString();
            }
        }
    }
}
