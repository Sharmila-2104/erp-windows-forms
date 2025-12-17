using ERP.ControlMaster.CommonFeatures;
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
    public partial class VendorGroup : Form
    {
        VendorGroup_DTO VG_DTO = new VendorGroup_DTO();
        VendorGroup_DAO VG_DAO = new VendorGroup_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public VendorGroup()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void VendorGroup_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            VG_DTO.Id = 2;
            DS = VG_DAO.VendorGroupDB(VG_DTO);
            GV_List.DataSource = DS.Tables[0];

            UnderVGroup_Cmbx.DataSource = DS.Tables[1];
            UnderVGroup_Cmbx.DisplayMember = "VendorGroup";
            UnderVGroup_Cmbx.ValueMember = "VendorGroupNumber";
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
                        VG_DTO.VendorGroupNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorGroupNumber"].Value);
                        VG_DTO.Id = 3;
                        DS = VG_DAO.VendorGroupDB(VG_DTO);
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
                VG_DTO.VendorGroupNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_VendorGroupNumber"].Value);
                VG_DTO.Id = 4;
                DS = VG_DAO.VendorGroupDB(VG_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderVGroup_Cmbx.DataSource = DS.Tables[1];
                    UnderVGroup_Cmbx.DisplayMember = "VendorGroup";
                    UnderVGroup_Cmbx.ValueMember = "VendorGroupNumber";

                    VendorGroupNumber_Txt.Text = DS.Tables[0].Rows[0]["VendorGroupNumber"].ToString();
                    VendorGroup_Txt_Special.Text = DS.Tables[0].Rows[0]["VendorGroup"].ToString();
                    VG_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["VG_Description"].ToString();
                    UnderVGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderVGroup"].ToString();

                    VendorGroup_Txt_Special.Focus();

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

        private void GV_List_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GV_List.ClearSelection();
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
                    VG_DTO.VendorGroup = VendorGroup_Txt_Special.Text;
                    VG_DTO.VG_Description = VG_Description_Txt_Special.Text;
                    VG_DTO.UnderVGroup = Convert.ToInt64(UnderVGroup_Cmbx.SelectedValue);
                    VG_DTO.CreatorCode = 1;
                    VG_DTO.Rights = 1;
                    VG_DTO.Id = 1;
                    DS = VG_DAO.VendorGroupDB(VG_DTO);
                    MessageBox.Show(Alert.Save());
                    GetData();
                    Clear();
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            UnderVGroup_Cmbx.SelectedIndex = -1;
            Clear();
        }
        void Clear()
        {
            Va.AllClear(this);

            VendorGroup_Txt_Special.Focus();

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
                if (Duplicate(VendorGroupNumber_Txt.Text))
                {
                    VG_DTO.VendorGroupNumber = Convert.ToInt64(VendorGroupNumber_Txt.Text);
                    VG_DTO.VendorGroup = VendorGroup_Txt_Special.Text;
                    VG_DTO.VG_Description = VG_Description_Txt_Special.Text;
                    VG_DTO.UnderVGroup = Convert.ToInt64(UnderVGroup_Cmbx.SelectedValue);
                    VG_DTO.CreatorCode = 1;
                    VG_DTO.Rights = 1;
                    VG_DTO.Id = 5;
                    DS = VG_DAO.VendorGroupDB(VG_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void VendorGroup_Txt_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(VendorGroupNumber_Txt.Text));
        }
        Boolean Duplicate(String VendorGroupNumber)
        {
            if (VendorGroupNumber.Trim().Length > 0)
            {
                VG_DTO.VendorGroupNumber = Convert.ToInt64(VendorGroupNumber);
                VG_DTO.VendorGroup = VendorGroup_Txt_Special.Text;
                VG_DTO.Id = 7;
                DS = VG_DAO.VendorGroupDB(VG_DTO);
            }
            else
            {
                VG_DTO.VendorGroup = VendorGroup_Txt_Special.Text;
                VG_DTO.Id = 6;
                DS = VG_DAO.VendorGroupDB(VG_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                VendorGroup_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
