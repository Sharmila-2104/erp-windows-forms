using ERP.ControlMaster.CommonFeatures;
using ERP.ControlMaster.Theme;
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

namespace ERP.Purchase.Vendor.Master
{
    public partial class VendorCategory : Form
    {
        VendorCategory_DTO VC_DTO = new VendorCategory_DTO();
        VendorCategory_DAO VC_DAO = new VendorCategory_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public VendorCategory()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void VendorCategory_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            VC_DTO.Id = 2;
            DS = VC_DAO.VendorCategoryDB(VC_DTO);
            GV_List.DataSource = DS.Tables[0];

            UnderVCategory_Cmbx.DataSource = DS.Tables[1];
            UnderVCategory_Cmbx.ValueMember = "VendorCategoryNumber";
            UnderVCategory_Cmbx.DisplayMember = "VendorCategory";
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
                        VC_DTO.VendorCategoryNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorCategoryNumber"].Value);
                        VC_DTO.Id = 3;
                        DS = VC_DAO.VendorCategoryDB(VC_DTO);
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
                VC_DTO.VendorCategoryNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorCategoryNumber"].Value);
                VC_DTO.Id = 4;
                DS = VC_DAO.VendorCategoryDB(VC_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderVCategory_Cmbx.DataSource = DS.Tables[1];
                    UnderVCategory_Cmbx.ValueMember = "VendorCategoryNumber";
                    UnderVCategory_Cmbx.DisplayMember = "VendorCategory";

                    VendorCategoryNumber_Txt.Text = DS.Tables[0].Rows[0]["VendorCategoryNumber"].ToString();
                    VendorCategory_Txt_Special.Text = DS.Tables[0].Rows[0]["VendorCategory"].ToString();
                    VC_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["VC_Description"].ToString();
                    UnderVCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderVCategory"].ToString();

                    VendorCategory_Txt_Special.Focus();

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
                    VC_DTO.VendorCategory = VendorCategory_Txt_Special.Text;
                    VC_DTO.VC_Description = VC_Description_Txt_Special.Text;
                    VC_DTO.UnderVCategory = Convert.ToInt64(UnderVCategory_Cmbx.SelectedValue);
                    VC_DTO.CreatorCode = 1;
                    VC_DTO.Rights = 1;
                    VC_DTO.Id = 1;
                    DS = VC_DAO.VendorCategoryDB(VC_DTO);
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

            VendorCategory_Txt_Special.Focus();

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
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
                if (Duplicate(VendorCategoryNumber_Txt.Text))
                {
                    VC_DTO.VendorCategoryNumber = Convert.ToInt64(VendorCategoryNumber_Txt.Text);
                    VC_DTO.VendorCategory = VendorCategory_Txt_Special.Text;
                    VC_DTO.VC_Description = VC_Description_Txt_Special.Text;
                    VC_DTO.UnderVCategory = Convert.ToInt64(UnderVCategory_Cmbx.SelectedValue);
                    VC_DTO.CreatorCode = 1;
                    VC_DTO.Rights = 1;
                    VC_DTO.Id = 5;
                    DS = VC_DAO.VendorCategoryDB(VC_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void VendorCategory_Txt_Leave(object sender, EventArgs e)
        {
            String VendorCategoryNumber = Convert.ToString(VendorCategoryNumber_Txt.Text);
            Duplicate(VendorCategoryNumber);
        }
        Boolean Duplicate(String VendorCategoryNumber)
        {
            if (VendorCategoryNumber.Trim().Length > 0)
            {
                VC_DTO.VendorCategoryNumber = Convert.ToInt64(VendorCategoryNumber);
                VC_DTO.VendorCategory = VendorCategory_Txt_Special.Text;
                VC_DTO.Id = 7;
                DS = VC_DAO.VendorCategoryDB(VC_DTO);
            }
            else
            {
                VC_DTO.VendorCategory = VendorCategory_Txt_Special.Text;
                VC_DTO.Id = 6;
                DS = VC_DAO.VendorCategoryDB(VC_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                VendorCategory_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
