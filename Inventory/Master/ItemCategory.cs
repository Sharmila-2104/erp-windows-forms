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

namespace ERP.Purchase.Item.Master
{
    public partial class ItemCategory : Form
    {
        ItemCategory_DTO IC_DTO = new ItemCategory_DTO();
        ItemCategory_DAO IC_DAO = new ItemCategory_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        public ItemCategory()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void ItemCategory_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            IC_DTO.Id = 2;
            DS = IC_DAO.ItemCategoryDB(IC_DTO);
            GV_List.DataSource = DS.Tables[0];

            UnderICategory_Cmbx.DataSource = DS.Tables[1];
            UnderICategory_Cmbx.ValueMember = "ItemCategoryNumber";
            UnderICategory_Cmbx.DisplayMember = "ItemCategory";
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
                        IC_DTO.ItemCategoryNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ItemCategoryNumber"].Value);
                        IC_DTO.Id = 3;
                        DS = IC_DAO.ItemCategoryDB(IC_DTO);
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
                IC_DTO.ItemCategoryNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_ItemCategoryNumber"].Value);
                IC_DTO.Id = 4;
                DS = IC_DAO.ItemCategoryDB(IC_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderICategory_Cmbx.DataSource = DS.Tables[1];
                    UnderICategory_Cmbx.ValueMember = "ItemCategoryNumber";
                    UnderICategory_Cmbx.DisplayMember = "ItemCategory";

                    ItemCategoryNumber_Txt.Text = DS.Tables[0].Rows[0]["ItemCategoryNumber"].ToString();
                    ItemCategory_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemCategory"].ToString();
                    IC_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["IC_Description"].ToString();
                    UnderICategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderICategory"].ToString();

                    ItemCategory_Txt_Special.Focus();

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
                    IC_DTO.ItemCategory = ItemCategory_Txt_Special.Text;
                    IC_DTO.IC_Description = IC_Description_Txt_Special.Text;
                    IC_DTO.UnderICategory = Convert.ToInt64(UnderICategory_Cmbx.SelectedValue);
                    IC_DTO.CreatorCode = 1;
                    IC_DTO.Rights = 1;
                    IC_DTO.Id = 1;
                    DS = IC_DAO.ItemCategoryDB(IC_DTO);
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

            ItemCategory_Txt_Special.Focus();

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
                if (Duplicate(ItemCategoryNumber_Txt.Text))
                {
                    IC_DTO.ItemCategoryNumber = Convert.ToInt64(ItemCategoryNumber_Txt.Text);
                    IC_DTO.ItemCategory = ItemCategory_Txt_Special.Text;
                    IC_DTO.IC_Description = IC_Description_Txt_Special.Text;
                    IC_DTO.UnderICategory = Convert.ToInt64(UnderICategory_Cmbx.SelectedValue);
                    IC_DTO.CreatorCode = 1;
                    IC_DTO.Rights = 1;
                    IC_DTO.Id = 5;
                    DS = IC_DAO.ItemCategoryDB(IC_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void ItemCategory_txt_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(ItemCategoryNumber_Txt.Text));
        }
        Boolean Duplicate(String ItemCategoryNumber)
        {
            if (ItemCategoryNumber.Trim().Length > 0)
            {
                IC_DTO.ItemCategoryNumber = Convert.ToInt64(ItemCategoryNumber);
                IC_DTO.ItemCategory = ItemCategory_Txt_Special.Text;
                IC_DTO.Id = 7;
                DS = IC_DAO.ItemCategoryDB(IC_DTO);
            }
            else
            {
                IC_DTO.ItemCategory = ItemCategory_Txt_Special.Text;
                IC_DTO.Id = 6;
                DS = IC_DAO.ItemCategoryDB(IC_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                ItemCategory_Txt_Special.Focus();
                return false;
            }
            return true;
        }
       
    }
}
