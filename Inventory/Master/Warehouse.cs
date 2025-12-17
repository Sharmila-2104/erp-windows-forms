using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP.Purchase.Item.Master
{
    public partial class Warehouse : Form
    {
        Warehouse_DAO WH_DAO = new Warehouse_DAO();
        Warehouse_DTO WH_DTO = new Warehouse_DTO();
       
        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public Warehouse()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            WH_DTO.Id = 2;
            DS = WH_DAO.WarehouseDB(WH_DTO);
            GV_List.DataSource = DS.Tables[0];

            WarehouseCategory_Cmbx.DataSource = DS.Tables[1];
            WarehouseCategory_Cmbx.ValueMember = "Number";
            WarehouseCategory_Cmbx.DisplayMember = "Warehouse";

            WarehouseGroup_Cmbx.DataSource = DS.Tables[2];
            WarehouseGroup_Cmbx.ValueMember = "WarehouseNumber";
            WarehouseGroup_Cmbx.DisplayMember = "WarehouseCode";
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
                        WH_DTO.WarehouseNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_WarehouseNumber"].Value);
                        WH_DTO.Id = 3;
                        DS = WH_DAO.WarehouseDB(WH_DTO);
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
            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                WH_DTO.WarehouseNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_WarehouseNumber"].Value); ;
                WH_DTO.Id = 4;
                DS = WH_DAO.WarehouseDB(WH_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    WarehouseCategory_Cmbx.DataSource = DS.Tables[1];
                    WarehouseCategory_Cmbx.ValueMember = "Number";
                    WarehouseCategory_Cmbx.DisplayMember = "Warehouse";

                    WarehouseGroup_Cmbx.DataSource = DS.Tables[2];
                    WarehouseGroup_Cmbx.ValueMember = "WarehouseNumber";
                    WarehouseGroup_Cmbx.DisplayMember = "WarehouseCode";

                    WarehouseNumber_Txt.Text = DS.Tables[0].Rows[0]["WarehouseNumber"].ToString();
                    WarehouseCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["WarehouseCategory"].ToString();
                    WarehouseCode_Txt_Special.Text = DS.Tables[0].Rows[0]["WarehouseCode"].ToString();
                    WarehouseDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["WarehouseDescription"].ToString();
                    WarehouseGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["WarehouseGroup"].ToString();

                    WarehouseCategory_Cmbx.Focus();

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

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (Duplicate(""))
                {
                    WH_DTO.WarehouseCategory = Convert.ToInt64(WarehouseCategory_Cmbx.SelectedValue);
                    WH_DTO.WarehouseCode = WarehouseCode_Txt_Special.Text;
                    WH_DTO.WarehouseDescription = WarehouseDescription_Txt_Special.Text;
                    WH_DTO.WarehouseGroup = Convert.ToInt64(WarehouseGroup_Cmbx.SelectedValue);
                    WH_DTO.CreatorCode = 1;
                    WH_DTO.Rights = 1;
                    WH_DTO.Id = 1;
                    DS = WH_DAO.WarehouseDB(WH_DTO);
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

            WarehouseCategory_Cmbx.Focus();

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
            Btn_Clear.Visible = true;
            Btn_Clear.Text = Btn_Clear.Tag.ToString();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
           if(Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (Duplicate(WarehouseNumber_Txt.Text))
                {
                    WH_DTO.WarehouseNumber = Convert.ToInt32(WarehouseNumber_Txt.Text);
                    WH_DTO.WarehouseCategory = Convert.ToInt64(WarehouseCategory_Cmbx.SelectedValue);
                    WH_DTO.WarehouseCode = WarehouseCode_Txt_Special.Text;
                    WH_DTO.WarehouseDescription = WarehouseDescription_Txt_Special.Text;
                    WH_DTO.WarehouseGroup = Convert.ToInt64(WarehouseGroup_Cmbx.SelectedValue);
                    WH_DTO.CreatorCode = 1;
                    WH_DTO.Rights = 1;
                    WH_DTO.Id =5;
                    DS = WH_DAO.WarehouseDB(WH_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void WarehouseCode_Txt_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(WarehouseNumber_Txt.Text));
        }
        Boolean Duplicate(String WarehouseNumber)
        {
            if (WarehouseNumber.Length > 0)
            {
                WH_DTO.WarehouseNumber = Convert.ToInt32(WarehouseNumber);
                WH_DTO.WarehouseCode = WarehouseCode_Txt_Special.Text;
                WH_DTO.Id = 7;
                DS = WH_DAO.WarehouseDB(WH_DTO);
            }
            else
            {
                WH_DTO.WarehouseCode = WarehouseCode_Txt_Special.Text;
                WH_DTO.Id = 6;
                DS = WH_DAO.WarehouseDB(WH_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                WarehouseCode_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
