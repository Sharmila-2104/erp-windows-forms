using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP.Purchase.Item.Master
{
    public partial class ItemSubCategory : Form
    {
        ItemSubCategory_DAO IS_DAO = new ItemSubCategory_DAO();
        ItemSubCategory_DTO IS_DTO = new ItemSubCategory_DTO();
        DataSet DS = new DataSet();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        public ItemSubCategory()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void ItemSubCategory_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();                    
        }
        void GetData()
        {
            IS_DTO.Id = 2;
            DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
            GV_List.DataSource =DS.Tables[0];

            UnderISubCategory_Cmbx.DataSource = DS.Tables[1];
            UnderISubCategory_Cmbx.ValueMember = "ItemSubCategoryNumber";
            UnderISubCategory_Cmbx.DisplayMember = "ItemSubCategory";
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
                        IS_DTO.ItemSubCategoryNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ItemSubCategoryNumber"].Value);
                        IS_DTO.Id = 3;
                        DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
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
                IS_DTO.ItemSubCategoryNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_ItemSubCategoryNumber"].Value);
                IS_DTO.Id = 4;
                DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderISubCategory_Cmbx.DataSource = DS.Tables[1];
                    UnderISubCategory_Cmbx.ValueMember = "ItemSubCategoryNumber";
                    UnderISubCategory_Cmbx.DisplayMember = "ItemSubCategory";

                    ItemSubCategoryNumber_Txt.Text = DS.Tables[0].Rows[0]["ItemSubCategoryNumber"].ToString();
                    ItemSubCategory_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemSubCategory"].ToString();
                    ISC_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["ISC_Description"].ToString();
                    UnderISubCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderISubCategory"].ToString();

                    ItemSubCategory_Txt_Special.Focus();

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
                    IS_DTO.ItemSubCategory = ItemSubCategory_Txt_Special.Text;
                    IS_DTO.ISC_Description = ISC_Description_Txt_Special.Text;
                    IS_DTO.UnderISubCategory = Convert.ToInt64(UnderISubCategory_Cmbx.SelectedValue);
                    IS_DTO.CreatorCode = 1;
                    IS_DTO.Rights = 1;
                    IS_DTO.Id = 1;
                    DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
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

            ItemSubCategory_Txt_Special.Focus();

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
                if (Duplicate(ItemSubCategoryNumber_Txt.Text))
                {
                    IS_DTO.ItemSubCategoryNumber = Convert.ToInt32(ItemSubCategoryNumber_Txt.Text);
                    IS_DTO.ItemSubCategory = ItemSubCategory_Txt_Special.Text;
                    IS_DTO.ISC_Description = ISC_Description_Txt_Special.Text;
                    IS_DTO.UnderISubCategory = Convert.ToInt64(UnderISubCategory_Cmbx.SelectedValue);
                    IS_DTO.CreatorCode = 1;
                    IS_DTO.Rights = 1;
                    IS_DTO.Id = 5;
                    DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }

        private void ItemSubCategory_Txt_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(ItemSubCategoryNumber_Txt.Text));
        }
        Boolean Duplicate(String ItemSubCategoryNumber)
        {
            if (ItemSubCategoryNumber.Length > 0)
            {
                IS_DTO.ItemSubCategoryNumber = Convert.ToInt32(ItemSubCategoryNumber);
                IS_DTO.ItemSubCategory = ItemSubCategory_Txt_Special.Text;
                IS_DTO.Id = 7;
                DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
            }
            else
            {
                IS_DTO.ItemSubCategory = ItemSubCategory_Txt_Special.Text;
                IS_DTO.Id = 6;
                DS = IS_DAO.ItemSubCategoryDB(IS_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                ItemSubCategory_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
