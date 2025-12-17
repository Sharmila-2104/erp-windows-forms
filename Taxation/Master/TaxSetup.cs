using ERP.ControlMaster.CommonFeatures;
using ERP.GeneralLedger.Master;
using ERP.Purchase.Item;
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
    public partial class TaxSetup : Form
    {
        TaxSetup_DTO TS_DTO = new TaxSetup_DTO();
        TaxSetup_DAO TS_DAO = new TaxSetup_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        DataSet DS = new DataSet();
        Validation Va = new Validation();

        DateTimePicker DTP = new DateTimePicker();
        Rectangle Rect = new Rectangle();
        public TaxSetup()
        {
            InitializeComponent();
            Eve.FormController(this);
            PanelList.Dock = DockStyle.Fill;
            PanelAdd.Visible = false;

            GV_DetailsList.Controls.Add(DTP);
            DTP.Visible = false;
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.TextChanged += new EventHandler(DTP_TextChange);
        }

        private void DTP_TextChange(object sender, EventArgs e)
        {
            GV_DetailsList.CurrentCell.Value = DTP.Text;
        }

        private void TaxSetUp_Load(object sender, EventArgs e)
        {
            GetList();
            Clear();
        }
        void GetList()
        {
            TS_DTO.Id = 11;
            DS = TS_DAO.TaxSetupDB(TS_DTO);
            GV_List.DataSource = DS.Tables[0];
        }

        private void GV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        TS_DTO.TaxSetupNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxSetupNumber"].Value);
                        TS_DTO.Id = 12;
                        DS = TS_DAO.TaxSetupDB(TS_DTO);
                        MessageBox.Show(Alert.Delete());
                        GetList();
                    }
                    catch
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
            }
            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {

                TS_DTO.TaxSetupNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxSetupNumber"].Value);
                TS_DTO.Id = 4;
                DS = TS_DAO.TaxSetupDB(TS_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    TaxElement_Cmbx.DataSource = DS.Tables[2];
                    TaxElement_Cmbx.ValueMember = "TaxElementNumber";
                    TaxElement_Cmbx.DisplayMember = "TaxElement";

                    TaxNature_Cmbx.DataSource = DS.Tables[3];
                    TaxNature_Cmbx.ValueMember = "Number";
                    TaxNature_Cmbx.DisplayMember = "Nature";

                    TaxSetupNumber_Txt.Text = DS.Tables[0].Rows[0]["TaxSetupNumber"].ToString();
                    TaxElement_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxElement"].ToString();
                    ElementDescription_Txt.Text = DS.Tables[0].Rows[0]["DesNumber"].ToString();
                    if (Convert.ToInt32(DS.Tables[0].Rows[0]["LoadonInventory"]) == 1)
                    {
                        LoadonInventory_Ckbx.Checked = true;
                    }
                    else
                    {
                        LoadonInventory_Ckbx.Checked = false;
                    }
                    LoadonInventoryPercent_Txt_Decimal.Text = Convert.ToDouble(DS.Tables[0].Rows[0]["LoadonInventoryPercent"]).ToString();
                    TaxNature_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxNature"].ToString();

                    TaxNature_GvCmbx.DataSource = DS.Tables[4];
                    TaxNature_GvCmbx.ValueMember = "Number";
                    TaxNature_GvCmbx.DisplayMember = "Nature";

                    HSN_Cmbx.DataSource = DS.Tables[5];
                    HSN_Cmbx.ValueMember = "HSN_Number";
                    HSN_Cmbx.DisplayMember = "HSN_Code";

                    SAC_Cmbx.DataSource = DS.Tables[6];
                    SAC_Cmbx.ValueMember = "SAC_Number";
                    SAC_Cmbx.DisplayMember = "SAC_Code";

                    GV_DetailsList.DataSource = DS.Tables[1];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;

                    PanelAdd.Dock = DockStyle.Fill;
                    PanelAdd.Visible = true;
                    PanelAdd.BringToFront();

                    TaxElement_Cmbx.Enabled = false;
                    Btn_Clear.Text = "Cancel";
                    LoadonInventory_Ckbx.Focus();
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    PanelList.Dock = DockStyle.Fill;
                    PanelAdd.Visible = false;
                }
            }
        }
        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            Clear();
            PanelAdd.Dock = DockStyle.Fill;
            PanelAdd.Visible = true;
            TaxElement_Cmbx.Enabled = true;
            TaxElement_Cmbx.Focus();
            PanelAdd.BringToFront();
            GetData();
        }
        void GetData()
        {
            TS_DTO.Id = 2;
            DS = TS_DAO.TaxSetupDB(TS_DTO);

            TaxElement_Cmbx.DataSource = DS.Tables[0];
            TaxElement_Cmbx.ValueMember = "TaxElementNumber";
            TaxElement_Cmbx.DisplayMember = "TaxElement";
            TaxElement_Cmbx.SelectedIndex = -1;

            TaxNature_Cmbx.DataSource = DS.Tables[1];
            TaxNature_Cmbx.ValueMember = "Number";
            TaxNature_Cmbx.DisplayMember = "Nature";
            TaxNature_Cmbx.SelectedIndex = -1;

            TaxNature_GvCmbx.DataSource = DS.Tables[2];
            TaxNature_GvCmbx.ValueMember = "Number";
            TaxNature_GvCmbx.DisplayMember = "Nature";

            HSN_Cmbx.DataSource = DS.Tables[3];
            HSN_Cmbx.ValueMember = "HSN_Number";
            HSN_Cmbx.DisplayMember = "HSN_Code";

            SAC_Cmbx.DataSource = DS.Tables[4];
            SAC_Cmbx.ValueMember = "SAC_Number";
            SAC_Cmbx.DisplayMember = "SAC_Code";

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

            PanelList.Dock = DockStyle.Fill;
            PanelAdd.Visible = false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (GV_DetailsList.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsList.Rows.Count-1; i++)
                    {
                        String FromDate = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value);
                        String TaxNature = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxNature_GvCmbx"].Value);
                        if (FromDate.Trim().Length < 10) 
                        {
                            Acc = 0;
                            MessageBox.Show("FromDate is required");
                            break;
                        }
                        else if (ToDate.Trim().Length < 10) 
                        {
                            Acc = 0;
                            MessageBox.Show("ToDate is required");
                            break;
                        }
                        else if (TaxNature.Trim().Length < 1) 
                        {
                            Acc = 0;
                            MessageBox.Show("TaxNature is required");
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
                    TS_DTO.TaxElement = Convert.ToInt64(TaxElement_Cmbx.SelectedValue);
                    if (LoadonInventory_Ckbx.Checked == true)
                    {
                        TS_DTO.LoadonInventory = 1;
                    }
                    else
                    {
                        TS_DTO.LoadonInventory = 0;
                    }
                    TS_DTO.LoadonInventoryPercent = Convert.ToDouble(LoadonInventoryPercent_Txt_Decimal.Text);
                    TS_DTO.TaxNature = Convert.ToInt64(TaxNature_Cmbx.SelectedValue);
                    TS_DTO.CreatorCode = 1;
                    TS_DTO.Id = 1;
                    DS = TS_DAO.TaxSetupDB(TS_DTO);
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        TS_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(GV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        TS_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(GV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        TS_DTO.GvTaxNature = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxNature_GvCmbx"].Value.ToString());
                        if(GV_DetailsList.Rows[i].Cells["FixedPercent_Txt"].Value == null || GV_DetailsList.Rows[i].Cells["FixedPercent_Txt"].Value == DBNull.Value)
                        {
                            TS_DTO.FixedPercent = 0;
                        }
                        else 
                        {
                            TS_DTO.FixedPercent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["FixedPercent_Txt"].Value.ToString());
                        }
                        if(GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value == null || GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value == DBNull.Value)
                        {
                            TS_DTO.HSN = 1;
                        }
                        else 
                        {
                            TS_DTO.HSN = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value.ToString());
                        }
                        if (GV_DetailsList.Rows[i].Cells["HSN_Percent_Txt"].Value == null || GV_DetailsList.Rows[i].Cells["HSN_Percent_Txt"].Value == DBNull.Value)
                        {
                            TS_DTO.HSN_Percent = 0;
                        }
                        else
                        {
                            TS_DTO.HSN_Percent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["HSN_Percent_Txt"].Value.ToString());
                        }
                        if (GV_DetailsList.Rows[i].Cells["SAC_Cmbx"].Value == null || GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value == DBNull.Value)
                        {
                            TS_DTO.SAC = 1;
                        }
                        else
                        {
                            TS_DTO.SAC = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["SAC_Cmbx"].Value.ToString());
                        }
                        if (GV_DetailsList.Rows[i].Cells["SAC_Percent_Txt"].Value == null || GV_DetailsList.Rows[i].Cells["SAC_Percent_Txt"].Value == DBNull.Value)
                        {
                            TS_DTO.SAC_Percent = 0;
                        }
                        else
                        {
                            TS_DTO.SAC_Percent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["SAC_Percent_Txt"].Value.ToString());
                        }
                        if (GV_DetailsList.Rows[i].Cells["Abatement_Txt"].Value == null || GV_DetailsList.Rows[i].Cells["Abatement_Txt"].Value == DBNull.Value)
                        {
                            TS_DTO.Abatement = 0;
                        }
                        else
                        {
                            TS_DTO.Abatement = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["Abatement_Txt"].Value.ToString());
                        }
                        TS_DTO.Id = 3;
                        DS = TS_DAO.TaxSetupDB(TS_DTO);
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
                if (GV_DetailsList.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        String FromDate = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value);
                        String TaxNature = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxNature_GvCmbx"].Value);
                        
                        String Code = "";
                        if (GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value != null && GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value != System.DBNull.Value)
                        {
                            Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value.ToString());
                        }
                        list.Add(Code);

                        if (FromDate.Trim().Length < 10)
                        {
                            Acc = 0;
                            MessageBox.Show("FromDate is required");
                            break;
                        }
                        else if (ToDate.Trim().Length < 10)
                        {
                            Acc = 0;
                            MessageBox.Show("ToDate is required");
                            break;
                        }
                        else if (TaxNature.Trim().Length < 1)
                        {
                            Acc = 0;
                            MessageBox.Show("TaxNature is required");
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
                    if (LoadonInventory_Ckbx.Checked == true)
                    {
                        TS_DTO.LoadonInventory = 1;
                    }
                    else
                    {
                        TS_DTO.LoadonInventory = 0;
                    }
                    TS_DTO.LoadonInventoryPercent = Convert.ToDouble(LoadonInventoryPercent_Txt_Decimal.Text);
                    TS_DTO.TaxNature = Convert.ToInt64(TaxNature_Cmbx.SelectedValue);
                    TS_DTO.CreatorCode = 1;
                    TS_DTO.Id = 7;
                    DS = TS_DAO.TaxSetupDB(TS_DTO);

                    TS_DTO.TaxSetupNumber = Convert.ToInt64(TaxSetupNumber_Txt.Text);
                    TS_DTO.Search = String.Join(",", list);
                    TS_DTO.Id = 9;
                    TS_DAO.TaxSetupDB(TS_DTO);

                    String Code = "";
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        if (GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value != null)
                        {
                            Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value.ToString());
                        }
                        TS_DTO.TaxSetupNumber = Convert.ToInt64(TaxSetupNumber_Txt.Text);
                        TS_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(GV_DetailsList.Rows[i].Cells["FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        TS_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(GV_DetailsList.Rows[i].Cells["ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        TS_DTO.GvTaxNature = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxNature_GvCmbx"].Value.ToString());
                        TS_DTO.FixedPercent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["FixedPercent_Txt"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["FixedPercent_Txt"].Value.ToString());
                        TS_DTO.HSN = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["HSN_Cmbx"].Value.ToString());
                        TS_DTO.HSN_Percent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["HSN_Percent_Txt"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["HSN_Percent_Txt"].Value.ToString()); 
                        TS_DTO.SAC = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["SAC_Cmbx"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["SAC_Cmbx"].Value.ToString());
                        TS_DTO.SAC_Percent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["SAC_Percent_Txt"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["SAC_Percent_Txt"].Value.ToString());
                        TS_DTO.Abatement = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["Abatement_Txt"].Value == DBNull.Value ? "0" : GV_DetailsList.Rows[i].Cells["Abatement_Txt"].Value.ToString());

                        if (Code == null || Code == "")
                        {
                            TS_DTO.Id = 5;
                        }
                        else
                        {
                            TS_DTO.TaxSetupDetailsNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value.ToString());
                            TS_DTO.Id = 6;
                        }
                        DS = TS_DAO.TaxSetupDB(TS_DTO);
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

            LoadonInventory_Ckbx.Checked = false;

            TaxElement_Cmbx.Focus();

            while (GV_DetailsList.Rows.Count > 1)
            {
                GV_DetailsList.Rows.RemoveAt(0);
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

        private void TaxElement_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TaxElement_Cmbx.SelectedValue.ToString() != "")
            {
                TS_DTO.TaxElement = Convert.ToInt64(TaxElement_Cmbx.SelectedValue);
                TS_DTO.Id = 8;
                DS = TS_DAO.TaxSetupDB(TS_DTO);
                ElementDescription_Txt.Text = DS.Tables[0].Rows[0]["ElementDescription"].ToString();
            }
        }

        private void GV_DetailsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (GV_DetailsList.Columns[e.ColumnIndex].Name)
                {
                    case "FromDate_Dt":
                        Rect = GV_DetailsList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        DTP.Size = new Size(Rect.Width, Rect.Height);
                        DTP.Location = new Point(Rect.X, Rect.Y);
                        DTP.Visible = true;
                        break;
                    case "ToDate_Dt":
                        Rect = GV_DetailsList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        DTP.Size = new Size(Rect.Width, Rect.Height);
                        DTP.Location = new Point(Rect.X, Rect.Y);
                        DTP.Visible = true;
                        break;
                }
            }
            catch { }

        }
        private void GV_DetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_DetailsList.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GV_DetailsList.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_DetailsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
