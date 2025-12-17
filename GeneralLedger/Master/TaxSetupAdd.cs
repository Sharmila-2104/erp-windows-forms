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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ERP.GeneralLedger.Master
{
    public partial class TaxSetupAdd : Form
    {
        TaxSetup_DAO TS_DAO = new TaxSetup_DAO();
        TaxSetup_DTO TS_DTO = new TaxSetup_DTO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        Int64 Code = 0;

        public TaxSetupAdd()
        {
            InitializeComponent();
        }

        public TaxSetupAdd(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
        }

        private void TaxSetupAdd_Load(object sender, EventArgs e)
        {
            if (Code == 0)
            {
                Btn_Save.Visible = true;
                Btn_Update.Visible = false;
                Btn_Clear.Visible = true;

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
            }
            else
            {
                Btn_Save.Visible = false;
                Btn_Update.Visible = true;
                Btn_Clear.Visible = false;

                TaxElement_Cmbx.Enabled = false;

                GetData(Code);
            }
        }

        void GetData(Int64 Number)
        {
            TS_DTO.TaxSetupNumber = Number;
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
                LoadonInventoryPercent_Txt_Digit.Text = DS.Tables[0].Rows[0]["LoadonInventoryPercent"].ToString();
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

                TaxSetupDetails.DataSource = DS.Tables[1];
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (TaxSetupDetails.Rows.Count > 1)
                {
                    for (int i = 0; i < TaxSetupDetails.Rows.Count - 1; i++)
                    {
                        String FromDate = Convert.ToString(TaxSetupDetails.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(TaxSetupDetails.Rows[i].Cells["ToDate_Dt"].Value);
                        String TaxNature = Convert.ToString(TaxSetupDetails.Rows[i].Cells["TaxNature_GvCmbx"].Value);
                        String FixedPercent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["FixedPercent_Txt"].Value);
                        String HSN_Percent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["HSN_Percent_Txt"].Value);
                        String SAC_Percent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["SAC_Percent_Txt"].Value);
                        String Abatement = Convert.ToString(TaxSetupDetails.Rows[i].Cells["Abatement_Txt"].Value);
                        if (FromDate.Trim().Length > 0 && ToDate.Trim().Length > 0 && TaxNature.Trim().Length > 0 && FixedPercent.Trim().Length > 0 && HSN_Percent.Trim().Length > 0 && SAC_Percent.Trim().Length > 0 && Abatement.Trim().Length > 0)
                        {
                        }
                        else
                        {
                            Acc = 0;
                            MessageBox.Show("enter required fields");
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
                    TS_DTO.LoadonInventoryPercent = Convert.ToDouble(LoadonInventoryPercent_Txt_Digit.Text);
                    TS_DTO.TaxNature = Convert.ToInt64(TaxNature_Cmbx.SelectedValue);
                    TS_DTO.CreatorCode = 1;
                    TS_DTO.Id = 1;
                    DS = TS_DAO.TaxSetupDB(TS_DTO);
                    for (int i = 0; i < TaxSetupDetails.Rows.Count - 1; i++)
                    {
                        TS_DTO.FromDate = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["FromDate_Dt"].Value.ToString());
                        TS_DTO.ToDate = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["ToDate_Dt"].Value.ToString());
                        TS_DTO.GvTaxNature = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["TaxNature_GvCmbx"].Value.ToString());
                        TS_DTO.FixedPercent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["FixedPercent_Txt"].Value.ToString());
                        TS_DTO.HSN = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["HSN_Cmbx"].Value == null ? "0" : TaxSetupDetails.Rows[i].Cells["HSN_Cmbx"].Value.ToString());
                        TS_DTO.HSN_Percent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["HSN_Percent_Txt"].Value.ToString());
                        TS_DTO.SAC = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["SAC_Cmbx"].Value == null ? "0" : TaxSetupDetails.Rows[i].Cells["SAC_Cmbx"].Value.ToString());
                        TS_DTO.SAC_Percent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["SAC_Percent_Txt"].Value.ToString());
                        TS_DTO.Abatement = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["Abatement_Txt"].Value.ToString());
                        TS_DTO.Id = 3;
                        DS = TS_DAO.TaxSetupDB(TS_DTO);
                    }
                    Clear();
                    MessageBox.Show(Alert.Save());
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
                Int32 Acc = 1;
                if (TaxSetupDetails.Rows.Count > 1)
                {
                    for (int i = 0; i < TaxSetupDetails.Rows.Count - 1; i++)
                    {
                        String FromDate = Convert.ToString(TaxSetupDetails.Rows[i].Cells["FromDate_Dt"].Value);
                        String ToDate = Convert.ToString(TaxSetupDetails.Rows[i].Cells["ToDate_Dt"].Value);
                        String TaxNature = Convert.ToString(TaxSetupDetails.Rows[i].Cells["TaxNature_GvCmbx"].Value);
                        String FixedPercent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["FixedPercent_Txt"].Value);
                        String HSN_Percent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["HSN_Percent_Txt"].Value);
                        String SAC_Percent = Convert.ToString(TaxSetupDetails.Rows[i].Cells["SAC_Percent_Txt"].Value);
                        String Abatement = Convert.ToString(TaxSetupDetails.Rows[i].Cells["Abatement_Txt"].Value);
                        if (FromDate.Trim().Length > 0 && ToDate.Trim().Length > 0 && TaxNature.Trim().Length > 0 && FixedPercent.Trim().Length > 0 && HSN_Percent.Trim().Length > 0 && SAC_Percent.Trim().Length > 0 && Abatement.Trim().Length > 0)
                        {
                        }
                        else
                        {
                            Acc = 0;
                            MessageBox.Show("enter required fields");
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
                    TS_DTO.LoadonInventoryPercent = Convert.ToDouble(LoadonInventoryPercent_Txt_Digit.Text);
                    TS_DTO.TaxNature = Convert.ToInt64(TaxNature_Cmbx.SelectedValue);
                    TS_DTO.CreatorCode = 1;
                    TS_DTO.Id = 7;
                    DS = TS_DAO.TaxSetupDB(TS_DTO);

                    String Code = "";
                    for (int i = 0; i < TaxSetupDetails.Rows.Count - 1; i++)
                    {
                        if (TaxSetupDetails.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value != null)
                        {
                            Code = Convert.ToString(TaxSetupDetails.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value.ToString());
                        }
                        TS_DTO.TaxSetupNumber = Convert.ToInt64(TaxSetupNumber_Txt.Text);
                        TS_DTO.FromDate = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["FromDate_Dt"].Value.ToString());
                        TS_DTO.ToDate = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["ToDate_Dt"].Value.ToString());
                        TS_DTO.GvTaxNature = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["TaxNature_GvCmbx"].Value.ToString());
                        TS_DTO.FixedPercent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["FixedPercent_Txt"].Value.ToString());
                        TS_DTO.HSN = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["HSN_Cmbx"].Value == System.DBNull.Value ? "0" : TaxSetupDetails.Rows[i].Cells["HSN_Cmbx"].Value.ToString());
                        TS_DTO.HSN_Percent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["HSN_Percent_Txt"].Value.ToString());
                        TS_DTO.SAC = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["SAC_Cmbx"].Value == System.DBNull.Value ? "0" : TaxSetupDetails.Rows[i].Cells["SAC_Cmbx"].Value.ToString());
                        TS_DTO.SAC_Percent = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["SAC_Percent_Txt"].Value.ToString());
                        TS_DTO.Abatement = Convert.ToDouble(TaxSetupDetails.Rows[i].Cells["Abatement_Txt"].Value.ToString());

                        if (Code == null || Code == "")
                        {
                            TS_DTO.Id = 5;
                        }
                        else
                        {
                            TS_DTO.TaxSetupDetailsNumber = Convert.ToInt64(TaxSetupDetails.Rows[i].Cells["TaxSetupDetailsNumber_Txt"].Value.ToString());
                            TS_DTO.Id = 6;
                        }
                        DS = TS_DAO.TaxSetupDB(TS_DTO);
                    }
                    MessageBox.Show(Alert.Edit());
                }
            }
        }

        void Clear()
        {
            TaxElement_Cmbx.SelectedIndex = -1;
            TaxNature_Cmbx.SelectedIndex = -1;
            LoadonInventory_Ckbx.Checked = false;

            TaxSetupDetails.Rows.Clear();

            ElementDescription_Txt.Clear();
            LoadonInventoryPercent_Txt_Digit.Clear();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void TaxSetupDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void TaxSetupDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TaxSetupDetails.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                TaxSetupDetails.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
