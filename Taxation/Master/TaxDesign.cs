using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Vendor;
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

namespace ERP.GeneralLedger.Master
{
    public partial class TaxDesign : Form
    {
        TaxDesign_DTO TD_DTO = new TaxDesign_DTO();
        TaxDesign_DAO TD_DAO = new TaxDesign_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        DataSet DS = new DataSet();
        Validation Va = new Validation();

        public TaxDesign()
        {
            InitializeComponent();
            Eve.FormController(this);
            PanelList.Dock = DockStyle.Fill;
            PanelAdd.Visible = false;
        }

        private void TaxDesign_Load(object sender, EventArgs e)
        {
            GetList();
        }

        void GetList()
        {
            TD_DTO.Id = 11;
            DS = TD_DAO.TaxDesignDB(TD_DTO);
            GV_List.DataSource = DS.Tables[0];
        }

        private void GV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        TD_DTO.TaxDesignNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxDesignNumber"].Value);
                        TD_DTO.Id = 12;
                        DS = TD_DAO.TaxDesignDB(TD_DTO);
                        MessageBox.Show(Alert.Delete());
                    }
                    catch 
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
                GetList();
            }
            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                TD_DTO.TaxDesignNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxDesignNumber"].Value);
                TD_DTO.Id = 4;
                DS = TD_DAO.TaxDesignDB(TD_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    TaxDesignNumber_Txt.Text = DS.Tables[4].Rows[0]["TaxDesignNumber"].ToString();
                    
                    TaxCluster_Cmbx.DataSource = DS.Tables[2];
                    TaxCluster_Cmbx.ValueMember = "TaxClusterNumber";
                    TaxCluster_Cmbx.DisplayMember = "TaxCluster";

                    //GVE_TaxNature_Cmbx.DataSource = DS.Tables[3];
                    //GVE_TaxNature_Cmbx.ValueMember = "Number";
                    //GVE_TaxNature_Cmbx.DisplayMember = "Nature";

                    GVE_ChargeableBasis_Cmbx.DataSource = DS.Tables[3];
                    GVE_ChargeableBasis_Cmbx.ValueMember = "Number";
                    GVE_ChargeableBasis_Cmbx.DisplayMember = "ChargeableBasis";

                    TaxCluster_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxCluster"].ToString();
                    ClusterDescription_Txt.Text = DS.Tables[0].Rows[0]["ClusterDescription"].ToString();

                    GV_DetailsListEdit.DataSource = DS.Tables[1];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;

                    TaxCluster_Cmbx.Enabled = false;
                    Btn_Clear.Text = "Cancel";

                    PanelAdd.Dock = DockStyle.Fill;
                    PanelAdd.Visible = true;
                    PanelAdd.BringToFront();

                    GV_DetailsListEdit.Visible = true;
                    GV_DetailsListEdit.Dock = DockStyle.Fill;

                    GV_DetailsListAdd.Visible = false;
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    GetList();
                    PanelList.Dock = DockStyle.Fill;
                    PanelAdd.Visible = false;
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Clear();
            GV_DetailsListEdit.Visible = false;
            PanelAdd.Dock = DockStyle.Fill;
            PanelAdd.Visible = true;

            TaxCluster_Cmbx.Focus();
            TaxCluster_Cmbx.Enabled = true;
            PanelAdd.BringToFront();

            GV_DetailsListAdd.Visible = true;
            GV_DetailsListAdd.Dock = DockStyle.Fill;


            GetData();
        }
        void GetData()
        {
            TD_DTO.Id = 2;
            DS = TD_DAO.TaxDesignDB(TD_DTO);

            TaxCluster_Cmbx.DataSource = DS.Tables[0];
            TaxCluster_Cmbx.ValueMember = "TaxClusterNumber";
            TaxCluster_Cmbx.DisplayMember = "TaxCluster";
            TaxCluster_Cmbx.SelectedIndex = -1;

            //TaxNature_Cmbx.DataSource = DS.Tables[1];
            //TaxNature_Cmbx.ValueMember = "Number";
            //TaxNature_Cmbx.DisplayMember = "Nature";

            ChargeableBasis_Cmbx.DataSource = DS.Tables[1];
            ChargeableBasis_Cmbx.ValueMember = "Number";
            ChargeableBasis_Cmbx.DisplayMember = "ChargeableBasis";

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
                if (GV_DetailsListAdd.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsListAdd.Rows.Count - 1; i++)
                    {
                        String CalculationFactors = Convert.ToString(GV_DetailsListAdd.Rows[i].Cells["CalculationFactors_Txt"].Value);
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
                    for (int i = 0; i < GV_DetailsListAdd.Rows.Count; i++)
                    {
                        TD_DTO.TaxClusterDetailsNumber = Convert.ToInt64(GV_DetailsListAdd.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value.ToString());
                        if (Convert.ToBoolean(GV_DetailsListAdd.Rows[i].Cells["LoadonInventory_Ckbx"].Value) == true)
                        {
                            TD_DTO.LoadonInventory = 1;
                        }
                        else
                        {
                            TD_DTO.LoadonInventory = 0;
                        }
                        TD_DTO.Index = Convert.ToInt64(GV_DetailsListAdd.Rows[i].Cells["Index_Txt"].Value.ToString());
                        TD_DTO.LoadonInventoryPercent = Convert.ToDouble(GV_DetailsListAdd.Rows[i].Cells["LoadonInventoryPercent_Txt"].Value.ToString());
                        TD_DTO.TaxNature = Convert.ToInt64(GV_DetailsListAdd.Rows[i].Cells["TaxNature_Cmbx"].Value.ToString());
                        TD_DTO.ChargeableBasis = Convert.ToInt64(GV_DetailsListAdd.Rows[i].Cells["ChargeableBasis_Cmbx"].Value.ToString());
                        TD_DTO.CalculationFactors = GV_DetailsListAdd.Rows[i].Cells["CalculationFactors_Txt"].Value.ToString();
                        TD_DTO.Id = 7;
                        DS = TD_DAO.TaxDesignDB(TD_DTO);
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
                if (GV_DetailsListEdit.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsListEdit.Rows.Count - 1; i++)
                    {
                        String CalculationFactors = Convert.ToString(GV_DetailsListEdit.Rows[i].Cells["GVE_CalculationFactors_Txt"].Value);
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
                    String Code = "";
                    for (int i = 0; i < GV_DetailsListEdit.Rows.Count; i++)
                    {
                        if (GV_DetailsListEdit.Rows[i].Cells["GVE_TaxDesignDetailsNumber_Txt"].Value != null)
                        {
                            Code = Convert.ToString(GV_DetailsListEdit.Rows[i].Cells["GVE_TaxDesignDetailsNumber_Txt"].Value.ToString());
                        }
                        TD_DTO.Index = Convert.ToInt64(GV_DetailsListEdit.Rows[i].Cells["GVE_Index_Txt_Digit"].Value.ToString());
                        if (GV_DetailsListEdit.Rows[i].Cells["GVE_LoadonInventory_Ckbx"].Value == System.DBNull.Value)
                        {
                            TD_DTO.LoadonInventory = 0;
                        }
                        else if (Convert.ToInt32(GV_DetailsListEdit.Rows[i].Cells["GVE_LoadonInventory_Ckbx"].Value) == 1)
                        {
                            TD_DTO.LoadonInventory = 1;
                        }
                        else if (Convert.ToInt32(GV_DetailsListEdit.Rows[i].Cells["GVE_LoadonInventory_Ckbx"].Value) == 0)
                        {
                            TD_DTO.LoadonInventory = 0;
                        }
                        TD_DTO.LoadonInventoryPercent = Convert.ToDouble(GV_DetailsListEdit.Rows[i].Cells["GVE_LoadonInventoryPercent_Txt"].Value.ToString());
                        TD_DTO.TaxNature = Convert.ToInt64(GV_DetailsListEdit.Rows[i].Cells["GVE_TaxNature_Cmbx"].Value.ToString());
                        TD_DTO.ChargeableBasis = Convert.ToInt64(GV_DetailsListEdit.Rows[i].Cells["GVE_ChargeableBasis_Cmbx"].Value.ToString());
                        TD_DTO.CalculationFactors = GV_DetailsListEdit.Rows[i].Cells["GVE_CalculationFactors_Txt"].Value.ToString();
                        if (Code == null || Code == "")
                        {
                            TD_DTO.Id = 3;
                        }
                        else
                        {
                            TD_DTO.TaxDesignDetailsNumber = Convert.ToInt64(GV_DetailsListEdit.Rows[i].Cells["GVE_TaxDesignDetailsNumber_Txt"].Value.ToString());
                            TD_DTO.Id = 8;
                        }
                        DS = TD_DAO.TaxDesignDB(TD_DTO);
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

            TaxCluster_Cmbx.Focus();

            while (GV_DetailsListAdd.Rows.Count > 0)
            {
                GV_DetailsListAdd.Rows.RemoveAt(0);
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
        private void TaxCluster_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TaxCluster_Cmbx.SelectedValue.ToString() != "")
            {
                object selectedValue = TaxCluster_Cmbx.SelectedValue;

                TD_DTO.TaxCluster = Convert.ToInt64(selectedValue);
                TD_DTO.Id = 3;
                DS = TD_DAO.TaxDesignDB(TD_DTO);
                ClusterDescription_Txt.Text = DS.Tables[0].Rows[0]["ClusterDescription"].ToString();

                GV_DetailsListAdd.DataSource = DS.Tables[1];
            }
        }


        private void GV_DetailsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
