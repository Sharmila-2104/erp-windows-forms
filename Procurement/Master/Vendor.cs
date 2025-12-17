using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Vendor.Master;
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
using static System.Net.WebRequestMethods;

namespace ERP.Purchase.Vendor
{
    public partial class Vendor : Form
    {
        Vendor_DTO V_DTO = new Vendor_DTO();
        Vendor_DAO V_DAO = new Vendor_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        DataSet DS = new DataSet();
        Validation Va = new Validation();

        MonthCalendar myCal = new MonthCalendar();
        PictureBox PBox = new PictureBox();

        MonthCalendar GST_myCal = new MonthCalendar();
        PictureBox GST_PBox = new PictureBox();

        Rectangle Rect = new Rectangle();

        String L = "";
        public Vendor()
        {
            InitializeComponent();
            Eve.FormController(this);
            PanelList.Dock = DockStyle.Fill;
            PanelAdd.Visible = false;

            WH_GridView.Controls.Add(PBox);
            WH_GridView.Controls.Add(myCal);

            myCal.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);
            myCal.Leave += new EventHandler(MonthCalendar_Leave);

            PBox.Click += new EventHandler(PBox_Click);

            PBox.Visible = false;
            myCal.Visible = false;

            GST_GridView.Controls.Add(GST_PBox);
            GST_GridView.Controls.Add(GST_myCal);

            GST_myCal.DateSelected += new DateRangeEventHandler(GST_MonthCalendar_DateSelected);
            GST_myCal.Leave += new EventHandler(GST_MonthCalendar_Leave);

            GST_PBox.Click += new EventHandler(DBox_Click);

            GST_PBox.Visible = false;
            GST_myCal.Visible = false;
        }

        private void PBox_Click(object sender, EventArgs e)
        {
            myCal.Visible = !myCal.Visible;
            myCal.Focus();
        }

        private void DBox_Click(object sender, EventArgs e)
        {
            GST_myCal.Visible = !myCal.Visible;
            GST_myCal.Focus();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            GetList();
            Clear();
        }

        void GetList()
        {
            V_DTO.Id = 11;
            DS = V_DAO.VendorDB(V_DTO);
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
                        V_DTO.VendorNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorNumber"].Value);
                        V_DTO.Id = 12;
                        DS = V_DAO.VendorDB(V_DTO);
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
                V_DTO.VendorNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorNumber"].Value);
                V_DTO.Id = 21;
                DS = V_DAO.VendorDB(V_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    VendorGroup_Cmbx.DataSource = DS.Tables[1];
                    VendorGroup_Cmbx.DisplayMember = "VendorGroup";
                    VendorGroup_Cmbx.ValueMember = "VendorGroupNumber";

                    VendorCategory_Cmbx.DataSource = DS.Tables[2];
                    VendorCategory_Cmbx.DisplayMember = "VendorCategory";
                    VendorCategory_Cmbx.ValueMember = "VendorCategoryNumber";

                    RegistrationType_Cmbx.DataSource = DS.Tables[3];
                    RegistrationType_Cmbx.DisplayMember = "Type";
                    RegistrationType_Cmbx.ValueMember = "Number";

                    AssesseeTerritory_Cmbx.DataSource = DS.Tables[4];
                    AssesseeTerritory_Cmbx.DisplayMember = "Territory";
                    AssesseeTerritory_Cmbx.ValueMember = "Number";

                    PaymentBase_Cmbx.DataSource = DS.Tables[5];
                    PaymentBase_Cmbx.DisplayMember = "Payment";
                    PaymentBase_Cmbx.ValueMember = "Number";

                    Currency_Cmbx.DataSource = DS.Tables[6];
                    Currency_Cmbx.DisplayMember = "CurrencyCode";
                    Currency_Cmbx.ValueMember = "CurrencyNumber";

                    WithholdTax_Cmbx.DataSource = DS.Tables[7];
                    WithholdTax_Cmbx.DisplayMember = "Transporter";
                    WithholdTax_Cmbx.ValueMember = "Number";

                    AssesseeNature_Cmbx.DataSource = DS.Tables[8];
                    AssesseeNature_Cmbx.DisplayMember = "Nature";
                    AssesseeNature_Cmbx.ValueMember = "Number";

                    TransportAgency_Cmbx.DataSource = DS.Tables[9];
                    TransportAgency_Cmbx.DisplayMember = "Transporter";
                    TransportAgency_Cmbx.ValueMember = "Number";

                    VendorNumber_Txt.Text = DS.Tables[0].Rows[0]["VendorNumber"].ToString();
                    VendorCode_Txt_Special.Text = DS.Tables[0].Rows[0]["VendorCode"].ToString();
                    VendorName_Txt_Special.Text = DS.Tables[0].Rows[0]["VendorName"].ToString();
                    Address_Rtxt_Special.Text = DS.Tables[0].Rows[0]["Address"].ToString();
                    City_Txt_Alpha.Text = DS.Tables[0].Rows[0]["City"].ToString();
                    State_Txt_Alpha.Text = DS.Tables[0].Rows[0]["State"].ToString();
                    Country_Txt_Alpha.Text = DS.Tables[0].Rows[0]["Country"].ToString();
                    Pincode_Txt_Digit.Text = DS.Tables[0].Rows[0]["PIN"].ToString();
                    ContactPerson_Txt_Special.Text = DS.Tables[0].Rows[0]["ContactPerson"].ToString();
                    CP_Telephone_Txt_Special.Text = DS.Tables[0].Rows[0]["CP_Telephone"].ToString();
                    CP_Mobile_Txt_Special.Text = DS.Tables[0].Rows[0]["CP_Mobile"].ToString();
                    CP_Email_Txt_Special.Text = DS.Tables[0].Rows[0]["CP_Email"].ToString();
                    AccountsPerson_Txt_Special.Text = DS.Tables[0].Rows[0]["AccountsPerson"].ToString();
                    AP_Telephone_Txt_Special.Text = DS.Tables[0].Rows[0]["AP_Telephone"].ToString();
                    AP_Mobile_Txt_Special.Text = DS.Tables[0].Rows[0]["AP_Mobile"].ToString();
                    AP_Email_Txt_Special.Text = DS.Tables[0].Rows[0]["AP_Email"].ToString();
                    L = DS.Tables[0].Rows[0]["VendorLocation"].ToString();
                    if (L == "1")
                    {
                        DomesticVendor_Rbtn.Checked = true;
                    }
                    else if (L == "2")
                    {
                        ForeignVendor_Rbtn.Checked = true;
                    }
                    VendorGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["VendorGroup"].ToString();
                    VendorCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["VendorCategory"].ToString();
                    RegistrationType_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["RegistrationType"].ToString();
                    GSTIN_Txt.Text = DS.Tables[0].Rows[0]["GSTIN"].ToString();
                    AssesseeTerritory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["AssesseeTerritory"].ToString();
                    TransportAgency_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TransportAgency"].ToString();
                    TransporterID_Txt_Special.Text = DS.Tables[0].Rows[0]["TransporterID"].ToString();
                    PaymentTerms_Rtxt_Special.Text = DS.Tables[0].Rows[0]["PaymentTerms"].ToString();
                    PaymentMode_Txt_Special.Text = DS.Tables[0].Rows[0]["PaymentMode"].ToString();
                    CreditDays_Txt_Special.Text = DS.Tables[0].Rows[0]["CreditDays"].ToString();
                    PaymentBase_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PaymentBase"].ToString();
                    Currency_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["Currency"].ToString();
                    AccountName_Txt_Special.Text = DS.Tables[0].Rows[0]["AccountName"].ToString();
                    AccountNumber_Txt_Special.Text = DS.Tables[0].Rows[0]["AccountNumber"].ToString();
                    IFSC_Txt_Special.Text = DS.Tables[0].Rows[0]["IFSC"].ToString();
                    BankName_Txt_Special.Text = DS.Tables[0].Rows[0]["BankName"].ToString();
                    PAN_Txt_Special.Text = DS.Tables[0].Rows[0]["PAN"].ToString();
                    WithholdTax_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["WithholdTax"].ToString();
                    AssesseeNature_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["AssesseeNature"].ToString();

                    DataGridViewComboBoxColumn WH_TaxCategory = WH_GridView.Columns["WH_TaxCategory_Cmbx"] as DataGridViewComboBoxColumn;
                    WH_TaxCategory.DataSource = DS.Tables[11];
                    WH_TaxCategory.DisplayMember = "Category";
                    WH_TaxCategory.ValueMember = "TaxCategory";

                    WH_GridView.DataSource = DS.Tables[10];

                    DataGridViewComboBoxColumn GST_TaxCategory = GST_GridView.Columns["GST_TaxCategory_Cmbx"] as DataGridViewComboBoxColumn;
                    GST_TaxCategory.DataSource = DS.Tables[15];
                    GST_TaxCategory.DisplayMember = "Category";
                    GST_TaxCategory.ValueMember = "TaxCategory";

                    GST_GridView.DataSource = DS.Tables[14];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;

                    SetWhPanel();
                    SetGSTPanel();

                    PanelAdd.Dock = DockStyle.Fill;
                    PanelAdd.Visible = true;
                    PanelAdd.BringToFront();

                    VendorCode_Txt_Special.Focus();


                    Btn_Clear.Text = "Cancel";
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    PanelList.Dock = DockStyle.Fill;
                    PanelAdd.Visible = false;
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SetWhPanel();
            SetGSTPanel();

            PanelAdd.Dock = DockStyle.Fill;
            PanelAdd.Visible = true;
            PanelAdd.BringToFront();

            VendorCode_Txt_Special.Focus();

            GetData();
            Clear();
        }
        void SetWhPanel()
        {
            Int32 PWid = AddInner.Width;
            Int32 PWidOne = (AddInner.Width / 2);
            WHPopUp.Size = new Size(PWid, AddInner.Height);

            WHPopUp.BackColor = Color.FromArgb(10, 0, 0, 0);
            WHPopUp.Dock = DockStyle.Fill;

            WHPopUp.Visible = false;
        }
        void SetGSTPanel()
        {
            Int32 PWid = AddInner.Width;
            Int32 PWidOne = (AddInner.Width / 2);
            GstPopUp.Size = new Size(PWid, AddInner.Height);

            GstPopUp.BackColor = Color.FromArgb(10, 0, 0, 0);
            GstPopUp.Dock = DockStyle.Fill;

            GstPopUp.Visible = false;
        }
        void GetData()
        {
            V_DTO.Id = 2;
            DS = V_DAO.VendorDB(V_DTO);

            VendorGroup_Cmbx.DataSource = DS.Tables[0];
            VendorGroup_Cmbx.DisplayMember = "VendorGroup";
            VendorGroup_Cmbx.ValueMember = "VendorGroupNumber";

            VendorCategory_Cmbx.DataSource = DS.Tables[1];
            VendorCategory_Cmbx.DisplayMember = "VendorCategory";
            VendorCategory_Cmbx.ValueMember = "VendorCategoryNumber";

            RegistrationType_Cmbx.DataSource = DS.Tables[2];
            RegistrationType_Cmbx.DisplayMember = "Type";
            RegistrationType_Cmbx.ValueMember = "Number";

            AssesseeTerritory_Cmbx.DataSource = DS.Tables[3];
            AssesseeTerritory_Cmbx.DisplayMember = "Territory";
            AssesseeTerritory_Cmbx.ValueMember = "Number";

            PaymentBase_Cmbx.DataSource = DS.Tables[4];
            PaymentBase_Cmbx.DisplayMember = "Payment";
            PaymentBase_Cmbx.ValueMember = "Number";

            Currency_Cmbx.DataSource = DS.Tables[5];
            Currency_Cmbx.DisplayMember = "CurrencyCode";
            Currency_Cmbx.ValueMember = "CurrencyNumber";

            WithholdTax_Cmbx.DataSource = DS.Tables[6];
            WithholdTax_Cmbx.DisplayMember = "Transporter";
            WithholdTax_Cmbx.ValueMember = "Number";

            AssesseeNature_Cmbx.DataSource = DS.Tables[7];
            AssesseeNature_Cmbx.DisplayMember = "Nature";
            AssesseeNature_Cmbx.ValueMember = "Number";

            TransportAgency_Cmbx.DataSource = DS.Tables[8];
            TransportAgency_Cmbx.DisplayMember = "Transporter";
            TransportAgency_Cmbx.ValueMember = "Number";

            WH_TaxCategory_Cmbx.DataSource = DS.Tables[9];
            WH_TaxCategory_Cmbx.DisplayMember = "Category";
            WH_TaxCategory_Cmbx.ValueMember = "TaxCategory";

            GST_TaxCategory_Cmbx.DataSource = DS.Tables[10];
            GST_TaxCategory_Cmbx.DisplayMember = "Category";
            GST_TaxCategory_Cmbx.ValueMember = "TaxCategory";

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
            else if (DomesticVendor_Rbtn.Checked == false && ForeignVendor_Rbtn.Checked == false)
            {
                MessageBox.Show("Select an Option for Vendor Location");
            }
            else
            {
                Int32 Acc = 1;
                for (int i = 0; i < WH_GridView.Rows.Count - 1; i++)
                {
                    String TaxCategory = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxCategory_Cmbx"].Value);
                    String TaxType = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxType_Cmbx"].Value);
                    String WH_TaxCode = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxCode_Cmbx"].Value);
                    String FromDate = Convert.ToString(WH_GridView.Rows[i].Cells["WH_FromDate_Dt"].Value);
                    String ToDate = Convert.ToString(WH_GridView.Rows[i].Cells["WH_ToDate_Dt"].Value);

                    if (FromDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("FromDate is Required");
                        break;
                    }
                    else if (ToDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("ToDate is Required");
                        break;
                    }
                    else if (TaxCategory.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCategory is Required");
                        break;
                    }
                    else if (TaxType.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxType is Required");
                        break;
                    }
                    else if (WH_TaxCode.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("WH_TaxCode is Required");
                        break;
                    }
                }

                for (int i = 0; i < GST_GridView.Rows.Count - 1; i++)
                {
                    String TaxCategory = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxCategory_Cmbx"].Value);
                    String TaxType = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxType_Cmbx"].Value);
                    String TaxCluster = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxCluster_Cmbx"].Value);
                    String FromDate = Convert.ToString(GST_GridView.Rows[i].Cells["GST_FromDate_Dt"].Value);
                    String ToDate = Convert.ToString(GST_GridView.Rows[i].Cells["GST_ToDate_Dt"].Value);

                    if (FromDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("FromDate is Required");
                        break;
                    }
                    else if (ToDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("ToDate is Required");
                        break;
                    }
                    else if (TaxCategory.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCategory is Required");
                        break;
                    }
                    else if (TaxType.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxType is Required");
                        break;
                    }
                    else if (TaxCluster.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCluster is Required");
                        break;
                    }
                }
                if (Acc == 1)
                {
                    V_DTO.VendorCode = VendorCode_Txt_Special.Text;
                    V_DTO.VendorName = VendorName_Txt_Special.Text;
                    V_DTO.Address = Address_Rtxt_Special.Text;
                    V_DTO.City = City_Txt_Alpha.Text;
                    V_DTO.State = State_Txt_Alpha.Text;
                    V_DTO.Country = Country_Txt_Alpha.Text;
                    V_DTO.PIN = Pincode_Txt_Digit.Text;
                    V_DTO.ContactPerson = ContactPerson_Txt_Special.Text;
                    V_DTO.CP_Telephone = CP_Telephone_Txt_Special.Text;
                    V_DTO.CP_Mobile = CP_Mobile_Txt_Special.Text;
                    V_DTO.CP_Email = CP_Email_Txt_Special.Text;
                    V_DTO.AccountsPerson = AccountsPerson_Txt_Special.Text;
                    V_DTO.AP_Telephone = AP_Telephone_Txt_Special.Text;
                    V_DTO.AP_Mobile = AP_Mobile_Txt_Special.Text;
                    V_DTO.AP_Email = AP_Email_Txt_Special.Text;
                    if (DomesticVendor_Rbtn.Checked)
                    {
                        V_DTO.VendorLocation = (1);
                    }
                    else
                    {
                        V_DTO.VendorLocation = (2);
                    }
                    V_DTO.VendorGroup = Convert.ToInt64(VendorGroup_Cmbx.SelectedValue);
                    V_DTO.VendorCategory = Convert.ToInt64(VendorCategory_Cmbx.SelectedValue);
                    V_DTO.RegistrationType = Convert.ToInt64(RegistrationType_Cmbx.SelectedValue == null ? 1 : RegistrationType_Cmbx.SelectedValue);
                    V_DTO.GSTIN = GSTIN_Txt.Text;
                    V_DTO.AssesseeTerritory = Convert.ToInt64(AssesseeTerritory_Cmbx.SelectedValue == null ? 1 : AssesseeTerritory_Cmbx.SelectedValue);
                    V_DTO.TransportAgency = Convert.ToInt32(TransportAgency_Cmbx.SelectedValue == null ? 1 : TransportAgency_Cmbx.SelectedValue);
                    V_DTO.TransporterID = TransporterID_Txt_Special.Text;
                    V_DTO.PaymentTerms = PaymentTerms_Rtxt_Special.Text;
                    V_DTO.PaymentMode = PaymentMode_Txt_Special.Text;
                    if (CreditDays_Txt_Special.Text == "")
                    {
                        V_DTO.CreditDays = 0;
                    }
                    else
                    {
                        V_DTO.CreditDays = Convert.ToInt32(CreditDays_Txt_Special.Text);
                    }
                    V_DTO.PaymentBase = Convert.ToInt64(PaymentBase_Cmbx.SelectedValue == null ? 1 : PaymentBase_Cmbx.SelectedValue);
                    V_DTO.Currency = Convert.ToInt64(Currency_Cmbx.SelectedValue == null ? 1 : Currency_Cmbx.SelectedValue);
                    V_DTO.AccountName = AccountName_Txt_Special.Text;
                    V_DTO.AccountNumber = AccountNumber_Txt_Special.Text;
                    V_DTO.IFSC = IFSC_Txt_Special.Text;
                    V_DTO.BankName = BankName_Txt_Special.Text;
                    V_DTO.PAN = PAN_Txt_Special.Text;
                    V_DTO.WithholdTax = Convert.ToInt64(WithholdTax_Cmbx.SelectedValue == null ? 1 : WithholdTax_Cmbx.SelectedValue);
                    V_DTO.AssesseeNature = Convert.ToInt64(AssesseeNature_Cmbx.SelectedValue == null ? 1 : AssesseeNature_Cmbx.SelectedValue);
                    V_DTO.CreatorCode = 1;
                    V_DTO.Id = 1;
                    DS = V_DAO.VendorDB(V_DTO);

                    for (int i = 0; i < WH_GridView.Rows.Count - 1; i++)
                    {
                        V_DTO.TaxCategory = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                        V_DTO.TaxType = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxType_Cmbx"].Value.ToString());
                        V_DTO.WH_TaxCode = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxCode_Cmbx"].Value.ToString());
                        V_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(WH_GridView.Rows[i].Cells["WH_FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(WH_GridView.Rows[i].Cells["WH_ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.Id = 101;
                        DS = V_DAO.VendorDB(V_DTO);
                    }
                    for (int i = 0; i < GST_GridView.Rows.Count - 1; i++)
                    {
                        V_DTO.TaxCategory = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxCategory_Cmbx"].Value.ToString());
                        V_DTO.TaxType = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxType_Cmbx"].Value.ToString());
                        V_DTO.TaxCluster = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxCluster_Cmbx"].Value.ToString());
                        V_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(GST_GridView.Rows[i].Cells["GST_FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(GST_GridView.Rows[i].Cells["GST_ToDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.Id = 201;
                        DS = V_DAO.VendorDB(V_DTO);
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
                var list1 = new List<String>();
                Int32 Acc = 1;

                for (int i = 0; i < WH_GridView.Rows.Count - 1; i++)
                {
                    String TaxCategory = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxCategory_Cmbx"].Value);
                    String TaxType = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxType_Cmbx"].Value);
                    String WH_TaxCode = Convert.ToString(WH_GridView.Rows[i].Cells["WH_TaxCode_Cmbx"].Value);
                    String FromDate = Convert.ToString(WH_GridView.Rows[i].Cells["WH_FromDate_Dt"].Value);
                    String ToDate = Convert.ToString(WH_GridView.Rows[i].Cells["WH_ToDate_Dt"].Value);

                    String Code = "";
                    if (TaxCategory.Trim().Length > 0)
                    {
                        if (WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value != null && WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value != System.DBNull.Value)
                        {
                            Code = Convert.ToString(WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value.ToString());
                        }
                        list.Add(Code);
                    }
                    if (FromDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("FromDate is Required");
                        break;
                    }
                    else if (ToDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("ToDate is Required");
                        break;
                    }
                    else if (TaxCategory.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCategory is Required");
                        break;
                    }
                    else if (TaxType.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxType is Required");
                        break;
                    }
                    else if (WH_TaxCode.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("WH_TaxCode is Required");
                        break;
                    }
                }
                for (int i = 0; i < GST_GridView.Rows.Count - 1; i++)
                {
                    String TaxCategory = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxCategory_Cmbx"].Value);
                    String TaxType = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxType_Cmbx"].Value);
                    String TaxCluster = Convert.ToString(GST_GridView.Rows[i].Cells["GST_TaxCluster_Cmbx"].Value);
                    String FromDate = Convert.ToString(GST_GridView.Rows[i].Cells["GST_FromDate_Dt"].Value);
                    String ToDate = Convert.ToString(GST_GridView.Rows[i].Cells["GST_ToDate_Dt"].Value);

                    String Code1 = "";
                    if (TaxCategory.Trim().Length > 0)
                    {
                        if (GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value != null && GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value != System.DBNull.Value)
                        {
                            Code1 = Convert.ToString(GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value.ToString());
                        }
                        list1.Add(Code1);
                    }
                    if (FromDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("FromDate is Required");
                        break;
                    }
                    else if (ToDate.Trim().Length < 10)
                    {
                        Acc = 0;
                        MessageBox.Show("ToDate is Required");
                        break;
                    }
                    else if (TaxCategory.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCategory is Required");
                        break;
                    }
                    else if (TaxType.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxType is Required");
                        break;
                    }
                    else if (TaxCluster.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("TaxCluster is Required");
                        break;
                    }
                }
                if (Acc == 1)
                {
                    V_DTO.VendorNumber = Convert.ToInt64(VendorNumber_Txt.Text);
                    V_DTO.Search = String.Join(",", list);
                    V_DTO.VendorCode = String.Join(",", list1);
                    V_DTO.Id = 106;
                    DS = V_DAO.VendorDB(V_DTO);

                    V_DTO.VendorCode = VendorCode_Txt_Special.Text;
                    V_DTO.VendorName = VendorName_Txt_Special.Text;
                    V_DTO.Address = Address_Rtxt_Special.Text;
                    V_DTO.City = City_Txt_Alpha.Text;
                    V_DTO.State = State_Txt_Alpha.Text;
                    V_DTO.Country = Country_Txt_Alpha.Text;
                    V_DTO.PIN = Pincode_Txt_Digit.Text;
                    V_DTO.ContactPerson = ContactPerson_Txt_Special.Text;
                    V_DTO.CP_Telephone = CP_Telephone_Txt_Special.Text;
                    V_DTO.CP_Mobile = CP_Mobile_Txt_Special.Text;
                    V_DTO.CP_Email = CP_Email_Txt_Special.Text;
                    V_DTO.AccountsPerson = AccountsPerson_Txt_Special.Text;
                    V_DTO.AP_Telephone = AP_Telephone_Txt_Special.Text;
                    V_DTO.AP_Mobile = AP_Mobile_Txt_Special.Text;
                    V_DTO.AP_Email = AP_Email_Txt_Special.Text;
                    if (DomesticVendor_Rbtn.Checked)
                    {
                        V_DTO.VendorLocation = (1);
                    }
                    else
                    {
                        V_DTO.VendorLocation = (2);
                    }
                    V_DTO.VendorGroup = Convert.ToInt64(VendorGroup_Cmbx.SelectedValue == null ? 1 : VendorGroup_Cmbx.SelectedValue);
                    V_DTO.VendorCategory = Convert.ToInt64(VendorCategory_Cmbx.SelectedValue == null ? 1 : VendorCategory_Cmbx.SelectedValue);
                    V_DTO.RegistrationType = Convert.ToInt64(RegistrationType_Cmbx.SelectedValue == null ? 1 : RegistrationType_Cmbx.SelectedValue);
                    V_DTO.GSTIN = GSTIN_Txt.Text;
                    V_DTO.AssesseeTerritory = Convert.ToInt64(AssesseeTerritory_Cmbx.SelectedValue == null ? 1 : AssesseeTerritory_Cmbx.SelectedValue);
                    V_DTO.TransportAgency = Convert.ToInt32(TransportAgency_Cmbx.SelectedValue == null ? 1 : TransportAgency_Cmbx.SelectedValue);
                    V_DTO.TransporterID = TransporterID_Txt_Special.Text;
                    V_DTO.PaymentTerms = PaymentTerms_Rtxt_Special.Text;
                    V_DTO.PaymentMode = PaymentMode_Txt_Special.Text;
                    V_DTO.CreditDays = Convert.ToInt32(CreditDays_Txt_Special.Text);
                    V_DTO.PaymentBase = Convert.ToInt64(PaymentBase_Cmbx.SelectedValue == null ? 1 : PaymentBase_Cmbx.SelectedValue);
                    V_DTO.Currency = Convert.ToInt64(Currency_Cmbx.SelectedValue == null ? 1 : Currency_Cmbx.SelectedValue);
                    V_DTO.AccountName = AccountName_Txt_Special.Text;
                    V_DTO.AccountNumber = AccountNumber_Txt_Special.Text;
                    V_DTO.IFSC = IFSC_Txt_Special.Text;
                    V_DTO.BankName = BankName_Txt_Special.Text;
                    V_DTO.PAN = PAN_Txt_Special.Text;
                    V_DTO.WithholdTax = Convert.ToInt64(WithholdTax_Cmbx.SelectedValue == null ? 1 : WithholdTax_Cmbx.SelectedValue);
                    V_DTO.AssesseeNature = Convert.ToInt64(AssesseeNature_Cmbx.SelectedValue == null ? 1 : AssesseeNature_Cmbx.SelectedValue);
                    V_DTO.CreatorCode = 1;
                    V_DTO.Id = 22;
                    DS = V_DAO.VendorDB(V_DTO);

                    String Code = "";
                    for (int i = 0; i < WH_GridView.Rows.Count - 1; i++)
                    {
                        if (WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value != null)
                        {
                            Code = Convert.ToString(WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value.ToString());
                        }
                        V_DTO.VendorNumber = Convert.ToInt64(VendorNumber_Txt.Text);
                        V_DTO.TaxCategory = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                        V_DTO.TaxType = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxType_Cmbx"].Value.ToString());
                        V_DTO.WH_TaxCode = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_TaxCode_Cmbx"].Value.ToString());
                        V_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(WH_GridView.Rows[i].Cells["WH_FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(WH_GridView.Rows[i].Cells["WH_ToDate_Dt"].Value).ToString("yyyyMMdd"));

                        if (Code == null || Code == "")
                        {
                            V_DTO.Id = 108;
                        }
                        else
                        {
                            V_DTO.Number = Convert.ToInt64(WH_GridView.Rows[i].Cells["WH_Number_Txt"].Value.ToString());
                            V_DTO.Id = 105;
                        }
                        DS = V_DAO.VendorDB(V_DTO);
                    }
                    for (int i = 0; i < GST_GridView.Rows.Count - 1; i++)
                    {
                        if (GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value != null)
                        {
                            Code = Convert.ToString(GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value.ToString());
                        }
                        V_DTO.VendorNumber = Convert.ToInt64(VendorNumber_Txt.Text);
                        V_DTO.TaxCategory = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxCategory_Cmbx"].Value.ToString());
                        V_DTO.TaxType = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxType_Cmbx"].Value.ToString());
                        V_DTO.TaxCluster = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_TaxCluster_Cmbx"].Value.ToString());
                        V_DTO.FromDate = Convert.ToInt32(Convert.ToDateTime(GST_GridView.Rows[i].Cells["GST_FromDate_Dt"].Value).ToString("yyyyMMdd"));
                        V_DTO.ToDate = Convert.ToInt32(Convert.ToDateTime(GST_GridView.Rows[i].Cells["GST_ToDate_Dt"].Value).ToString("yyyyMMdd"));

                        if (Code == null || Code == "")
                        {
                            V_DTO.Id = 207;
                        }
                        else
                        {
                            V_DTO.Number = Convert.ToInt64(GST_GridView.Rows[i].Cells["GST_Number_Txt"].Value.ToString());
                            V_DTO.Id = 206;
                        }
                        DS = V_DAO.VendorDB(V_DTO);
                    }
                    MessageBox.Show(Alert.Edit());
                    GetList();
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

            DomesticVendor_Rbtn.Checked = false;
            ForeignVendor_Rbtn.Checked = false;

            while (WH_GridView.Rows.Count > 1)
            {
                WH_GridView.Rows.RemoveAt(0);
            }

            while (GST_GridView.Rows.Count > 1)
            {
                GST_GridView.Rows.RemoveAt(0);
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

        private void WithholdTax_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (WithholdTax_Cmbx.SelectedValue.ToString() == "2")
            {
                WHPopUp.Visible = true;
            }
            else
            {
                WHPopUp.Visible = false;
            }
        }
        private void WH_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (WH_GridView.Columns[e.ColumnIndex].Name)
                {
                    case "WH_FromDate_Dt":
                        Rect = WH_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        myCal.Left = Rect.Left;
                        myCal.Top = Rect.Bottom + 5;

                        PBox.Image = Properties.Resources.calender;
                        PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        PBox.Size = new Size(25, Rect.Height);
                        PBox.Visible = true;
                        break;
                    case "WH_ToDate_Dt":
                        Rect = WH_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
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

            if (WH_GridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    WH_GridView.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void WH_GridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxCategory_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                    V_DTO.Id = 103;
                    DS = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell WHTaxType = WH_GridView.Rows[e.RowIndex].Cells["WH_TaxType_Cmbx"] as DataGridViewComboBoxCell;

                    WHTaxType.DataSource = DS.Tables[0];
                    WHTaxType.DisplayMember = "Type";
                    WHTaxType.ValueMember = "Number";
                }
                else if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxType_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                    V_DTO.TaxType = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxType_Cmbx"].Value.ToString());
                    V_DTO.Id = 104;
                    DS = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell WHTaxCode = WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCode_Cmbx"] as DataGridViewComboBoxCell;

                    WHTaxCode.DataSource = DS.Tables[0];
                    WHTaxCode.DisplayMember = "WH_TaxCode";
                    WHTaxCode.ValueMember = "WithholdtaxNumber";
                }
                else if ((WH_GridView.Columns[e.ColumnIndex].HeaderText == "WH Tax Code"))
                {
                    String a = Convert.ToString(WH_TaxCode_Cmbx.Index);
                    if (e.RowIndex >= 0)
                    {
                        object selectedValue = WH_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                        if (selectedValue != null)
                        {
                            V_DTO.WH_TaxCode = Convert.ToInt64(selectedValue);
                            V_DTO.Id = 107;
                            DS = V_DAO.VendorDB(V_DTO);
                            WH_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = DS.Tables[0].Rows[0]["WH_TaxDescription"].ToString();
                        }
                    }
                }
            }
            catch { }

            switch (WH_GridView.Columns[e.ColumnIndex].Name)
            {
                case "WH_FromDate_Dt":
                    try
                    {
                        String Date = Convert.ToDateTime(WH_GridView.Rows[e.RowIndex].Cells["WH_FromDate_Dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        WH_GridView.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        WH_GridView.CurrentCell.Value = "";
                        MessageBox.Show("Date is Not in Correct Format");
                    }
                    break;
                case "WH_ToDate_Dt":
                    try
                    {
                        String Date = Convert.ToDateTime(WH_GridView.Rows[e.RowIndex].Cells["WH_FromDate_Dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        WH_GridView.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        WH_GridView.CurrentCell.Value = "";
                        MessageBox.Show("Date is Not in Correct Format");
                    }
                    break;
            }

        }
        private void WH_GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid")
            //{
            //    //object value = WH_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //    //if (!((DataGridViewComboBoxColumn)WH_GridView.Columns[e.ColumnIndex]).Items.Contains(value))
            //    //{
            //        e.ThrowException = false;
            //    //}
            //}
            e.Cancel = true;
        }
        private void WH_GridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in WH_GridView.Rows)
            {
                if (Convert.ToString(row.Cells["WH_TaxCategory_Cmbx"].Value) != "")
                {
                    var selectedValue = row.Cells["WH_TaxCategory_Cmbx"].Value.ToString();

                    DataSet Ds3 = new DataSet();
                    V_DTO.TaxCategory = Convert.ToInt32(selectedValue);
                    V_DTO.Id = 103;
                    Ds3 = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell WHTaxType = row.Cells["WH_TaxType_Cmbx"] as DataGridViewComboBoxCell;

                    WHTaxType.DataSource = Ds3.Tables[0];
                    WHTaxType.DisplayMember = "Type";
                    WHTaxType.ValueMember = "Number";
                }

                if (Convert.ToString(row.Cells["WH_TaxCategory_Cmbx"].Value) != "")
                {
                    var selectedValue = row.Cells["WH_TaxCategory_Cmbx"].Value.ToString();
                    var selectedValue1 = row.Cells["WH_TaxType_Cmbx"].Value.ToString();

                    DataSet Ds4 = new DataSet();
                    V_DTO.TaxCategory = Convert.ToInt32(selectedValue);
                    V_DTO.TaxType = Convert.ToInt32(selectedValue1);
                    V_DTO.Id = 104;
                    Ds4 = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell WHTaxCode = row.Cells["WH_TaxCode_Cmbx"] as DataGridViewComboBoxCell;

                    WHTaxCode.DataSource = Ds4.Tables[0];
                    WHTaxCode.DisplayMember = "WH_TaxCode";
                    WHTaxCode.ValueMember = "WithholdtaxNumber";
                }
            }
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            WH_GridView.CurrentCell.Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            myCal.Visible = false;
        }
        private void MonthCalendar_Leave(object sender, EventArgs e)
        {
            myCal.Visible = false;
        }
        private void WHCloseButton_Click(object sender, EventArgs e)
        {
            WHPopUp.Visible = false;
        }


        private void RegistrationType_Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistrationType_Cmbx.SelectedIndex > -1)
            {
                GstPopUp.Visible = true;
            }
            else
            {
                GstPopUp.Visible = false;
            }
        }
        private void GST_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (GST_GridView.Columns[e.ColumnIndex].Name)
                {
                    case "GST_FromDate_Dt":
                        Rect = GST_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        GST_myCal.Left = Rect.Left;
                        GST_myCal.Top = Rect.Bottom + 5;

                        GST_PBox.Image = Properties.Resources.calender;
                        GST_PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        GST_PBox.Size = new Size(25, Rect.Height);
                        GST_PBox.Visible = true;
                        break;
                    case "GST_ToDate_Dt":
                        Rect = GST_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        GST_myCal.Left = Rect.Left;
                        GST_myCal.Top = Rect.Bottom + 5;

                        GST_PBox.Image = Properties.Resources.calender;
                        GST_PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        GST_PBox.Size = new Size(25, Rect.Height);
                        GST_PBox.Visible = true;
                        break;
                }
            }
            catch { }

            if (GST_GridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GST_GridView.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }

        }
        private void GST_GridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GST_GridView.Columns[e.ColumnIndex].Name.Equals("GST_TaxCategory_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells["GST_TaxCategory_Cmbx"].Value.ToString());
                    V_DTO.Id = 203;
                    DS = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell GST_TaxType = GST_GridView.Rows[e.RowIndex].Cells["GST_TaxType_Cmbx"] as DataGridViewComboBoxCell;

                    GST_TaxType.DataSource = DS.Tables[0];
                    GST_TaxType.DisplayMember = "Type";
                    GST_TaxType.ValueMember = "Number";
                }
                else if (GST_GridView.Columns[e.ColumnIndex].Name.Equals("GST_TaxType_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells["GST_TaxCategory_Cmbx"].Value.ToString());
                    V_DTO.TaxType = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells["GST_TaxType_Cmbx"].Value.ToString());
                    V_DTO.Id = 204;
                    DS = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell GST_TaxCluster = GST_GridView.Rows[e.RowIndex].Cells["GST_TaxCluster_Cmbx"] as DataGridViewComboBoxCell;

                    GST_TaxCluster.DataSource = DS.Tables[0];
                    GST_TaxCluster.DisplayMember = "TaxCluster";
                    GST_TaxCluster.ValueMember = "TaxClusterNumber";
                }
                else if ((GST_GridView.Columns[e.ColumnIndex].HeaderText == "Tax Cluster"))
                {
                    if (e.RowIndex >= 0)
                    {
                        object selectedValue = GST_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                        if (selectedValue != null)
                        {
                            V_DTO.TaxCluster = Convert.ToInt64(selectedValue);
                            V_DTO.Id = 205;
                            DS = V_DAO.VendorDB(V_DTO);
                            GST_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = DS.Tables[0].Rows[0]["ClusterDescription"].ToString();
                        }
                    }
                }
            }
            catch { }

            switch (GST_GridView.Columns[e.ColumnIndex].Name)
            {
                case "GST_FromDate_Dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GST_GridView.Rows[e.RowIndex].Cells["GST_FromDate_Dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GST_GridView.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GST_GridView.CurrentCell.Value = "";
                        MessageBox.Show("Date is Not in Correct Format");
                    }
                    break;
                case "GST_ToDate_Dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GST_GridView.Rows[e.RowIndex].Cells["GST_ToDate_Dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GST_GridView.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GST_GridView.CurrentCell.Value = "";
                        MessageBox.Show("Date is Not in Correct Format");
                    }
                    break;
            }
        }
        private void GST_GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void GST_GridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in GST_GridView.Rows)
            {
                if (Convert.ToString(row.Cells["GST_TaxCategory_Cmbx"].Value) != "")
                {
                    var selectedValue = row.Cells["GST_TaxCategory_Cmbx"].Value.ToString();

                    DataSet Ds3 = new DataSet();
                    V_DTO.TaxCategory = Convert.ToInt32(selectedValue);
                    V_DTO.Id = 203;
                    Ds3 = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell GSTTaxType = row.Cells["GST_TaxType_Cmbx"] as DataGridViewComboBoxCell;

                    GSTTaxType.DataSource = Ds3.Tables[0];
                    GSTTaxType.DisplayMember = "Type";
                    GSTTaxType.ValueMember = "Number";
                }
                if (Convert.ToString(row.Cells["GST_TaxCategory_Cmbx"].Value) != "")
                {
                    var GSTTaxCategory = row.Cells["GST_TaxCategory_Cmbx"].Value.ToString();
                    var GSTTaxType = row.Cells["GST_TaxType_Cmbx"].Value.ToString();

                    DataSet Ds4 = new DataSet();
                    V_DTO.TaxCategory = Convert.ToInt32(GSTTaxCategory);
                    V_DTO.TaxType = Convert.ToInt32(GSTTaxType);
                    V_DTO.Id = 204;
                    Ds4 = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell GSTTaxCluster = row.Cells["GST_TaxCluster_Cmbx"] as DataGridViewComboBoxCell;

                    GSTTaxCluster.DataSource = Ds4.Tables[0];
                    GSTTaxCluster.DisplayMember = "TaxCluster";
                    GSTTaxCluster.ValueMember = "TaxClusterNumber";
                }
            }
        }
        private void GST_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            GST_GridView.CurrentCell.Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            GST_myCal.Visible = false;
        }
        private void GST_MonthCalendar_Leave(object sender, EventArgs e)
        {
            GST_myCal.Visible = false;
        }
        private void GSTCloseButton_Click(object sender, EventArgs e)
        {
            GstPopUp.Visible = false;
        }

        private void VendorCode_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(VendorNumber_Txt.Text));
        }
        Boolean Duplicate(String VendorNumber)
        {
            if (VendorNumber.Trim().Length > 0)
            {
                V_DTO.VendorNumber = Convert.ToInt32(VendorNumber);
                V_DTO.VendorCode = VendorCode_Txt_Special.Text;
                V_DTO.Id = 4;
                DS = V_DAO.VendorDB(V_DTO);
            }
            else
            {
                V_DTO.VendorCode = VendorCode_Txt_Special.Text;
                V_DTO.Id = 3;
                DS = V_DAO.VendorDB(V_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                VendorCode_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
