using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Tax;
using ERP.Purchase.Vendor.Master;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ERP.Purchase.Vendor
{
    public partial class VendorAdd : Form
    {
        Vendor_DTO V_DTO = new Vendor_DTO();
        Vendor_DAO V_DAO = new Vendor_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        Validation Va = new Validation();
        DataSet DS = new DataSet();
        Int64 Code = 0;

        DateTimePicker DTP = new DateTimePicker();
        DateTimePicker GST_DTP = new DateTimePicker();

        Rectangle Rect = new Rectangle();

        String L = "";
        public VendorAdd(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
        }

        public VendorAdd()
        {
            InitializeComponent();

            WH_GridView.Controls.Add(DTP);
            DTP.Visible = false;
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.TextChanged += new EventHandler(DTP_TextChange);

            GST_GridView.Controls.Add(GST_DTP);
            GST_DTP.Visible = false;
            GST_DTP.Format = DateTimePickerFormat.Custom;
            GST_DTP.TextChanged += new EventHandler(DTP_TextChange_GST);
        }
        private void DTP_TextChange(object sender, EventArgs e)
        {
            WH_GridView.CurrentCell.Value = DTP.Text;
        }
        private void DTP_TextChange_GST(object sender, EventArgs e)
        {
            GST_GridView.CurrentCell.Value = GST_DTP.Text;
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
                    V_DTO.VendorGroup = Convert.ToInt64(VendorGroup_Cmbx.SelectedValue == null ? 1 : VendorGroup_Cmbx.SelectedValue);
                    V_DTO.VendorCategory = Convert.ToInt64(VendorCategory_Cmbx.SelectedValue == null ? 1 : VendorCategory_Cmbx.SelectedValue);
                    V_DTO.RegistrationType = Convert.ToInt64(RegistrationType_Cmbx.SelectedValue == null ? 1 : RegistrationType_Cmbx.SelectedValue);
                    V_DTO.GSTIN = GSTIN_Txt.Text;
                    V_DTO.AssesseeTerritory = Convert.ToInt64(AssesseeTerritory_Cmbx.SelectedValue == null ? 1 : AssesseeTerritory_Cmbx.SelectedValue);
                    V_DTO.TransportAgency = Convert.ToInt32(TransportAgency_Cmbx.SelectedValue == null ? 1 : TransportAgency_Cmbx.SelectedValue);
                    V_DTO.TransporterID = TransporterID_Txt_Special.Text;
                    V_DTO.PaymentTerms = PaymentTerms_Rtxt_Special.Text;
                    V_DTO.PaymentMode = PaymentMode_Txt_Special.Text;
                    if(CreditDays_Txt_Special.Text == "" )
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
                    //Back();
                }
            }
        }
        void Clear()
        {
            Va.AllClear(this);

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
                //Back();
            }
            else
            {
                Btn_Clear.Text = Btn_Clear.Tag.ToString();
            }
        }

        private void RBtn_Foreign_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VendorAdd_Load(object sender, EventArgs e)
        {
            if (Code == 0)
            {
                Btn_Save.Visible = true;
                Btn_Update.Visible = false;
                Btn_Clear.Visible = true;

                V_DTO.Id = 2;
                DS = V_DAO.VendorDB(V_DTO);

                VendorGroup_Cmbx.DataSource = DS.Tables[0];
                VendorGroup_Cmbx.DisplayMember = "VendorGroup";
                VendorGroup_Cmbx.ValueMember = "VendorGroupNumber";
                VendorGroup_Cmbx.SelectedIndex = -1;

                VendorCategory_Cmbx.DataSource = DS.Tables[1];
                VendorCategory_Cmbx.DisplayMember = "VendorCategory";
                VendorCategory_Cmbx.ValueMember = "VendorCategoryNumber";
                VendorCategory_Cmbx.SelectedIndex = -1;

                RegistrationType_Cmbx.DataSource = DS.Tables[2];
                RegistrationType_Cmbx.DisplayMember = "Type";
                RegistrationType_Cmbx.ValueMember = "Number";
                RegistrationType_Cmbx.SelectedIndex = -1;

                AssesseeTerritory_Cmbx.DataSource = DS.Tables[3];
                AssesseeTerritory_Cmbx.DisplayMember = "Territory";
                AssesseeTerritory_Cmbx.ValueMember = "Number";
                AssesseeTerritory_Cmbx.SelectedIndex = -1;

                PaymentBase_Cmbx.DataSource = DS.Tables[4];
                PaymentBase_Cmbx.DisplayMember = "Payment";
                PaymentBase_Cmbx.ValueMember = "Number";
                PaymentBase_Cmbx.SelectedIndex = -1;

                Currency_Cmbx.DataSource = DS.Tables[5];
                Currency_Cmbx.DisplayMember = "CurrencyCode";
                Currency_Cmbx.ValueMember = "CurrencyNumber";
                Currency_Cmbx.SelectedIndex = -1;

                WithholdTax_Cmbx.DataSource = DS.Tables[6];
                WithholdTax_Cmbx.DisplayMember = "Transporter";
                WithholdTax_Cmbx.ValueMember = "Number";
                WithholdTax_Cmbx.SelectedIndex = -1;

                AssesseeNature_Cmbx.DataSource = DS.Tables[7];
                AssesseeNature_Cmbx.DisplayMember = "Nature";
                AssesseeNature_Cmbx.ValueMember = "Number";
                AssesseeNature_Cmbx.SelectedIndex = -1;

                TransportAgency_Cmbx.DataSource = DS.Tables[8];
                TransportAgency_Cmbx.DisplayMember = "Transporter";
                TransportAgency_Cmbx.ValueMember = "Number";
                TransportAgency_Cmbx.SelectedIndex = -1;

                V_DTO.Id = 102;
                DS = V_DAO.VendorDB(V_DTO);
                WH_TaxCategory_Cmbx.DataSource = DS.Tables[0];
                WH_TaxCategory_Cmbx.DisplayMember = "Category";
                WH_TaxCategory_Cmbx.ValueMember = "TaxCategory";
                //WH_TaxCategory_Cmbx.Visible = false;

                

                V_DTO.Id = 202;
                DS = V_DAO.VendorDB(V_DTO);
                GST_TaxCategory_Cmbx.DataSource = DS.Tables[0];
                GST_TaxCategory_Cmbx.DisplayMember = "Category";
                GST_TaxCategory_Cmbx.ValueMember = "TaxCategory";
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
            V_DTO.VendorNumber = Number;
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

                WH_TaxCategory_Cmbx.DataSource = DS.Tables[11];
                WH_TaxCategory_Cmbx.DisplayMember = "Category";
                WH_TaxCategory_Cmbx.ValueMember = "TaxCategory";

                WH_TaxType_Cmbx.DataSource = DS.Tables[12];
                WH_TaxType_Cmbx.DisplayMember = "Type";
                WH_TaxType_Cmbx.ValueMember = "TaxType";

                WH_TaxCode_Cmbx.DataSource = DS.Tables[13];
                WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";
                WH_TaxCode_Cmbx.ValueMember = "WithholdtaxNumber";

                WH_GridView.DataSource = DS.Tables[10];

                GST_TaxCategory_Cmbx.DataSource = DS.Tables[15];
                GST_TaxCategory_Cmbx.DisplayMember = "Category";
                GST_TaxCategory_Cmbx.ValueMember = "TaxCategory";

                GST_TaxType_Cmbx.DataSource = DS.Tables[16];
                GST_TaxType_Cmbx.DisplayMember = "Type";
                GST_TaxType_Cmbx.ValueMember = "TaxType";

                GST_TaxCluster_Cmbx.DataSource = DS.Tables[17];
                GST_TaxCluster_Cmbx.DisplayMember = "TaxCluster";
                GST_TaxCluster_Cmbx.ValueMember = "TaxClusterNumber";

                GST_GridView.DataSource = DS.Tables[14];
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
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
                    Clear();
                    //Back();
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Vendor Ven = new Vendor();
            Close();
            Ven.Show();
        }

        private void GV_List_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            WH_GridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //WH_GridView
        System.Windows.Forms.ComboBox CurCombo;

        private void WH_TaxType_Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    V_DTO.TaxCategory = Convert.ToInt32(CurCombo.SelectedValue);
            //    V_DTO.Id = 103;
            //    DS = V_DAO.VendorDB(V_DTO);

            //    DataGridViewComboBoxCell ExerciseCell = (DataGridViewComboBoxCell)(WH_GridView.CurrentRow.Cells["WH_TaxCode_Cmbx"]);
            //    ExerciseCell.DataSource = DS.Tables[0];
            //    ExerciseCell.DisplayMember = "Type";
            //    ExerciseCell.ValueMember = "TaxType";
            //}
            //catch { }
        }

        private void WH_TaxCategory_Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (CurCombo.SelectedValue != null)
            //    {
            //        V_DTO.TaxCategory = Convert.ToInt32(CurCombo.SelectedValue);
            //        V_DTO.Id = 104;
            //        DS = V_DAO.VendorDB(V_DTO);

            //        DataGridViewComboBoxCell ExerciseCell = (DataGridViewComboBoxCell)(WH_GridView.CurrentRow.Cells["WH_TaxType_Cmbx"]);
            //        ExerciseCell.DataSource = DS.Tables[0];
            //        ExerciseCell.DisplayMember = "WH_TaxCode";
            //        ExerciseCell.ValueMember = "WithholdtaxNumber";
            //    }
            //}
            //catch { }
        }


        private void WH_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (WH_GridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    WH_GridView.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
            //if (WH_GridView.Columns[e.ColumnIndex].HeaderText == "Category")
            //{
            //    Int32 vv = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value);
            //}
        }

        private void WH_GridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxCategory_Cmbx"))
            //{
            //    V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
            //    V_DTO.Id = 103;
            //    DS = V_DAO.VendorDB(V_DTO);

            //    this.WH_TaxCode_Cmbx.DataSource = DS.Tables[0];
            //    this.WH_TaxType_Cmbx.DisplayMember = "Type";
            //    this.WH_TaxType_Cmbx.ValueMember = "Number";
            //}
            //else if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxType_Cmbx"))
            //{
            //    V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
            //    V_DTO.TaxType = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxType_Cmbx"].Value.ToString());
            //    V_DTO.Id = 104;
            //    DS = V_DAO.VendorDB(V_DTO);

            //    this.WH_TaxCode_Cmbx.DataSource = DS.Tables[0];
            //    this.WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";
            //    this.WH_TaxCode_Cmbx.ValueMember = "WithholdtaxNumber";
            //}
        }
        private void WH_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (WH_GridView.Columns[e.ColumnIndex].Name)
                {
                    case "WH_FromDate_Dt":
                        Rect = WH_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        DTP.Size = new Size(Rect.Width, Rect.Height);
                        DTP.Location = new Point(Rect.X, Rect.Y);
                        DTP.Visible = true;
                        break;
                    case "WH_ToDate_Dt":
                        Rect = WH_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        DTP.Size = new Size(Rect.Width, Rect.Height);
                        DTP.Location = new Point(Rect.X, Rect.Y);
                        DTP.Visible = true;
                        break;
                }
            }
            catch { }
        }
        private void WH_GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void WH_GridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxCategory_Cmbx"))
            {
                V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                V_DTO.Id = 103;
                DS = V_DAO.VendorDB(V_DTO);

                this.WH_TaxType_Cmbx.DataSource = DS.Tables[0];
                this.WH_TaxType_Cmbx.DisplayMember = "Type";
                this.WH_TaxType_Cmbx.ValueMember = "Number";
            }
            else if (WH_GridView.Columns[e.ColumnIndex].Name.Equals("WH_TaxType_Cmbx"))
            {
                V_DTO.TaxCategory = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxCategory_Cmbx"].Value.ToString());
                V_DTO.TaxType = Convert.ToInt32(WH_GridView.Rows[e.RowIndex].Cells["WH_TaxType_Cmbx"].Value.ToString());
                V_DTO.Id = 104;
                DS = V_DAO.VendorDB(V_DTO);

                this.WH_TaxCode_Cmbx.DataSource = DS.Tables[0];
                this.WH_TaxCode_Cmbx.DisplayMember = "WH_TaxCode";
                this.WH_TaxCode_Cmbx.ValueMember = "WithholdtaxNumber";
            }
            else if((WH_GridView.Columns[e.ColumnIndex].HeaderText == "WHTaxCode"))
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
        

        //GST_Gridview
        System.Windows.Forms.ComboBox Combo;


        private void GST_TaxCategory_Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Combo.SelectedValue != null)
                {
                    V_DTO.TaxCategory = Convert.ToInt32(Combo.SelectedValue);
                    V_DTO.Id = 204;
                    DS = V_DAO.VendorDB(V_DTO);

                    DataGridViewComboBoxCell ExerciseCell = (DataGridViewComboBoxCell)(WH_GridView.CurrentRow.Cells["GST_TaxType_Cmbx"]);
                    ExerciseCell.DataSource = DS.Tables[0];
                    ExerciseCell.DisplayMember = "TaxCluster";
                    ExerciseCell.ValueMember = "TaxClusterNumber";
                }
            }
            catch { }
        }
        private void GST_TaxType_Cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                V_DTO.TaxCategory = Convert.ToInt32(Combo.SelectedValue);
                V_DTO.Id = 203;
                DS = V_DAO.VendorDB(V_DTO);

                DataGridViewComboBoxCell ExerciseCell = (DataGridViewComboBoxCell)(WH_GridView.CurrentRow.Cells["GST_TaxCluster_Cmbx"]);
                ExerciseCell.DataSource = DS.Tables[0];
                ExerciseCell.DisplayMember = "Type";
                ExerciseCell.ValueMember = "TaxType";
            }
            catch { }
        }

        private void GST_GridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GST_GridView.Columns[e.ColumnIndex].Name.Equals("GST_TaxCategory_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    V_DTO.Id = 203;
                    DS = V_DAO.VendorDB(V_DTO);

                    //GV_List.Rows[e.RowIndex].Cells[1].Value = DS.Tables[0];
                    this.GST_TaxType_Cmbx.DataSource = DS.Tables[0];
                    this.GST_TaxType_Cmbx.DisplayMember = "Type";
                    this.GST_TaxType_Cmbx.ValueMember = "TaxType";
                }
                else if (GST_GridView.Columns[e.ColumnIndex].Name.Equals("GST_TaxType_Cmbx"))
                {
                    V_DTO.TaxCategory = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    V_DTO.Id = 204;
                    DS = V_DAO.VendorDB(V_DTO);

                    this.GST_TaxCluster_Cmbx.DataSource = DS.Tables[0];
                    this.GST_TaxCluster_Cmbx.DisplayMember = "TaxCluster";
                    this.GST_TaxCluster_Cmbx.ValueMember = "TaxClusterNumber";
                }
            }
            catch { }
        }

        private void GST_GridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GST_GridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GST_GridView.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
            if (GST_GridView.Columns[e.ColumnIndex].HeaderText == "Category")
            {
                Int32 vv = Convert.ToInt32(GST_GridView.Rows[e.RowIndex].Cells["GST_TaxCategory_Cmbx"].Value);
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
                        GST_DTP.Size = new Size(Rect.Width, Rect.Height);
                        GST_DTP.Location = new Point(Rect.X, Rect.Y);
                        GST_DTP.Visible = true;
                        break;
                    case "GST_ToDate_Dt":
                        Rect = GST_GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        GST_DTP.Size = new Size(Rect.Width, Rect.Height);
                        GST_DTP.Location = new Point(Rect.X, Rect.Y);
                        GST_DTP.Visible = true;
                        break;
                }
            }
            catch { }
        }

        private void GST_GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void GST_GridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((GST_GridView.Columns[e.ColumnIndex].HeaderText == "TaxCluster"))
            {
                String a = Convert.ToString(GST_TaxCluster_Cmbx.Index);
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

        private void VendorCode_Txt_Special_Leave(object sender, EventArgs e)
        {
            //Duplicate(Convert.ToString(VendorNumber_Txt.Text));
        }
        //Boolean Duplicate(String VendorNumber)
        //{
        //    if (VendorNumber.Trim().Length > 0)
        //    {
        //        V_DTO.VendorNumber = Convert.ToInt32(VendorNumber);
        //        V_DTO.VendorCode = VendorCode_Txt_Special.Text;
        //        V_DTO.Id = 4;
        //        DS = V_DAO.VendorDB(V_DTO);
        //    }
        //    else
        //    {
        //        V_DTO.VendorCode = VendorCode_Txt_Special.Text;
        //        V_DTO.Id = 3;
        //        DS = V_DAO.VendorDB(V_DTO);
        //    }

        //    if (DS.Tables[0].Rows.Count != 0)
        //    {
        //        MessageBox.Show(Alert.Duplicate());
        //        VendorCode_Txt_Special.Focus();
        //        return false;
        //    }
        //    return true;
        //}
    }
}
