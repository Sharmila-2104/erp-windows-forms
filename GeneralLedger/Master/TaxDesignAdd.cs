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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP.GeneralLedger.Master
{
    public partial class TaxDesignAdd : Form
    {
        TaxDesign_DTO TD_DTO = new TaxDesign_DTO();
        TaxDesign_DAO TD_DAO = new TaxDesign_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        Int64 Code = 0;
        

        public TaxDesignAdd()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        public TaxDesignAdd(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
        }
        private void TaxDesignAdd_Load(object sender, EventArgs e)
        {
            if (Code == 0)
            {
                Btn_Save.Visible = true;
                Btn_Update.Visible = false;
                Btn_Clear.Visible = true;

                TD_DTO.Id = 2;
                DS = TD_DAO.TaxDesignDB(TD_DTO);

                TaxCluster_Cmbx.DataSource = DS.Tables[0];
                TaxCluster_Cmbx.ValueMember = "Number";
                TaxCluster_Cmbx.DisplayMember = "Cluster";
                TaxCluster_Cmbx.SelectedIndex = -1;

                TaxNature_Cmbx.DataSource = DS.Tables[1];
                TaxNature_Cmbx.ValueMember = "Number";
                TaxNature_Cmbx.DisplayMember = "Nature";

                ChargeableBasis_Cmbx.DataSource = DS.Tables[2];
                ChargeableBasis_Cmbx.ValueMember = "Number";
                ChargeableBasis_Cmbx.DisplayMember = "ChargeableBasis";
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
            TD_DTO.TaxDesignNumber = Number;
            TD_DTO.Id = 4;
            DS = TD_DAO.TaxDesignDB(TD_DTO);
            if (DS.Tables[0].Rows.Count > 0)
            {
                TaxCluster_Cmbx.DataSource = DS.Tables[2];
                TaxCluster_Cmbx.ValueMember = "Number";
                TaxCluster_Cmbx.DisplayMember = "Cluster";

                TaxNature_Cmbx.DataSource = DS.Tables[3];
                TaxNature_Cmbx.ValueMember = "Number";
                TaxNature_Cmbx.DisplayMember = "Nature";

                ChargeableBasis_Cmbx.DataSource = DS.Tables[4];
                ChargeableBasis_Cmbx.ValueMember = "Number";
                ChargeableBasis_Cmbx.DisplayMember = "ChargeableBasis";

                TaxCluster_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["Number"].ToString();
                ClusterDescription_Txt.Text = DS.Tables[0].Rows[0]["Description"].ToString();

                GV_DetailsList.DataSource = DS.Tables[1];
            }

            TaxCluster_Cmbx.Enabled = false;
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
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        String CalculationFactors = Convert.ToString(GV_DetailsList.Rows[i].Cells["CalculationFactors_Txt"].Value);
                        if (CalculationFactors.Trim().Length > 0)
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
                if (Acc == 1)
                {
                    TD_DTO.TaxCluster = Convert.ToInt64(TaxCluster_Cmbx.SelectedValue);
                    TD_DTO.CreatorCode = 1;
                    TD_DTO.Id = 1;
                    DS = TD_DAO.TaxDesignDB(TD_DTO);
                    for (int i = 0; i < GV_DetailsList.Rows.Count; i++)
                    {
                        TD_DTO.TaxClusterDetailsNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ClusterNumber"].Value.ToString());
                        if (Convert.ToBoolean(GV_DetailsList.Rows[i].Cells["LoadonInventory_Ckbx"].Value) == true)
                        {
                            TD_DTO.LoadonInventory = 1;
                        }
                        else
                        {
                            TD_DTO.LoadonInventory = 0;
                        }
                        TD_DTO.Index = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["Index_Txt"].Value.ToString());
                        TD_DTO.LoadonInventoryPercent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["LoadonInventoryPercent_Txt"].Value.ToString());
                        TD_DTO.TaxNature = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxNature_Cmbx"].Value.ToString());
                        TD_DTO.ChargeableBasis = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ChargeableBasis_Cmbx"].Value.ToString());
                        TD_DTO.CalculationFactors = GV_DetailsList.Rows[i].Cells["CalculationFactors_Txt"].Value.ToString();
                        TD_DTO.Id = 7;
                        DS = TD_DAO.TaxDesignDB(TD_DTO);
                    }
                    MessageBox.Show(Alert.Save());
                    Clear();
                    //GetData();
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

            TaxCluster_Cmbx.Focus();

            Btn_Save.Visible = true;
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
                String Code = "";
                for (int i = 0; i < GV_DetailsList.Rows.Count; i++)
                {
                    if (GV_DetailsList.Rows[i].Cells["TaxDesignDetailsNumber"].Value != null)
                    {
                        Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxDesignDetailsNumber"].Value.ToString());
                    }
                    TD_DTO.Index = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["Index_Txt"].Value.ToString());
                    if (GV_DetailsList.Rows[i].Cells["LoadonInventory_Ckbx"].Value == System.DBNull.Value)
                    {
                        TD_DTO.LoadonInventory = 0;
                    }
                    else if (Convert.ToInt32(GV_DetailsList.Rows[i].Cells["LoadonInventory_Ckbx"].Value) == 1)
                    {
                        TD_DTO.LoadonInventory = 1;
                    }
                    else if (Convert.ToInt32(GV_DetailsList.Rows[i].Cells["LoadonInventory_Ckbx"].Value) == 0)
                    {
                        TD_DTO.LoadonInventory = 0;
                    }
                    TD_DTO.LoadonInventoryPercent = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["LoadonInventoryPercent_Txt"].Value.ToString());
                    TD_DTO.TaxNature = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxNature_Cmbx"].Value.ToString());
                    TD_DTO.ChargeableBasis = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ChargeableBasis_Cmbx"].Value.ToString());
                    TD_DTO.CalculationFactors = GV_DetailsList.Rows[i].Cells["CalculationFactors_Txt"].Value.ToString();
                    if (Code == null || Code == "")
                    {
                        TD_DTO.Id = 3;
                    }
                    else
                    {
                        TD_DTO.TaxDesignDetailsNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxDesignDetailsNumber"].Value.ToString());
                        TD_DTO.Id = 8;
                    }
                    DS = TD_DAO.TaxDesignDB(TD_DTO);
                }
                MessageBox.Show("Updated Successfully");
            }
        }


        private void DdL_Cluster_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TaxCluster_Cmbx.SelectedValue.ToString() != "")
            {
                object selectedValue = TaxCluster_Cmbx.SelectedValue;

                TD_DTO.TaxCluster = Convert.ToInt64(selectedValue);
                TD_DTO.Id = 3;
                DS = TD_DAO.TaxDesignDB(TD_DTO);
                ClusterDescription_Txt.Text = DS.Tables[0].Rows[0]["Description"].ToString();

                GV_DetailsList.DataSource = DS.Tables[1];
            }
        }
    }
}
