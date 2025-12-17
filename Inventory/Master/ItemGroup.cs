using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP.Purchase.Item.Master
{
    public partial class ItemGroup : Form
    {
        ItemGroup_DAO IG_DAO = new ItemGroup_DAO();
        ItemGroup_DTO IG_DTO = new ItemGroup_DTO();
        DataSet DS = new DataSet();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        public ItemGroup()
        {
            InitializeComponent();
            Eve.FormController(this);
        }
        private void ItemGroup_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            IG_DTO.Id =2;
            DS = IG_DAO.ItemGroupDB(IG_DTO);
            GV_List.DataSource = DS.Tables[0];

            UnderIGroup_Cmbx.DataSource = DS.Tables[1];
            UnderIGroup_Cmbx.ValueMember = "ItemGroupNumber";
            UnderIGroup_Cmbx.DisplayMember = "ItemGroup";

            MaterialOwnership_Cmbx.DataSource = DS.Tables[2];
            MaterialOwnership_Cmbx.ValueMember = "Number";
            MaterialOwnership_Cmbx.DisplayMember = "Ownership";

            PurchaseWarehouse_Cmbx.DataSource = DS.Tables[3];
            PurchaseWarehouse_Cmbx.ValueMember = "WarehouseNumber";
            PurchaseWarehouse_Cmbx.DisplayMember = "WarehouseCode";

            SaleWarehouse_Cmbx.DataSource = DS.Tables[4];
            SaleWarehouse_Cmbx.ValueMember = "WarehouseNumber";
            SaleWarehouse_Cmbx.DisplayMember = "WarehouseCode";

            MaterialClassification_Cmbx.DataSource = DS.Tables[5];
            MaterialClassification_Cmbx.ValueMember = "Number";
            MaterialClassification_Cmbx.DisplayMember = "Classification";
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
                        IG_DTO.ItemGroupNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ItemGroupNumber"].Value);
                        IG_DTO.Id = 3;
                        DS = IG_DAO.ItemGroupDB(IG_DTO);
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
                IG_DTO.ItemGroupNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ItemGroupNumber"].Value);
                IG_DTO.Id = 4;
                DS = IG_DAO.ItemGroupDB(IG_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnderIGroup_Cmbx.DataSource = DS.Tables[1];
                    UnderIGroup_Cmbx.ValueMember = "ItemGroupNumber";
                    UnderIGroup_Cmbx.DisplayMember = "ItemGroup";

                    MaterialOwnership_Cmbx.DataSource = DS.Tables[2];
                    MaterialOwnership_Cmbx.ValueMember = "Number";
                    MaterialOwnership_Cmbx.DisplayMember = "Ownership";

                    PurchaseWarehouse_Cmbx.DataSource = DS.Tables[3];
                    PurchaseWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                    PurchaseWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                    SaleWarehouse_Cmbx.DataSource = DS.Tables[4];
                    SaleWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                    SaleWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                    MaterialClassification_Cmbx.DataSource = DS.Tables[5];
                    MaterialClassification_Cmbx.ValueMember = "Number";
                    MaterialClassification_Cmbx.DisplayMember = "Classification";

                    ItemGroupNumber.Text = DS.Tables[0].Rows[0]["ItemGroupNumber"].ToString();
                    ItemGroup_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemGroup"].ToString();
                    IG_Description_Txt_Special.Text = DS.Tables[0].Rows[0]["IG_Description"].ToString();
                    UnderIGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UnderIGroup"].ToString();
                    MaterialOwnership_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["MaterialOwnership"].ToString();
                    PurchaseWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PurchaseWarehouse"].ToString();
                    SaleWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["SaleWarehouse"].ToString();
                    MaterialClassification_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["MaterialClassification"].ToString();

                    ItemGroup_Txt_Special.Focus();

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
                    IG_DTO.ItemGroup = ItemGroup_Txt_Special.Text;
                    IG_DTO.IG_Description = IG_Description_Txt_Special.Text;
                    IG_DTO.UnderIGroup = Convert.ToInt64(UnderIGroup_Cmbx.SelectedValue);
                    IG_DTO.MaterialOwnership = Convert.ToInt64(MaterialOwnership_Cmbx.SelectedValue);
                    IG_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue);
                    IG_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue);
                    IG_DTO.MaterialClassification = Convert.ToInt64(MaterialClassification_Cmbx.SelectedValue);
                    IG_DTO.CreatorCode = 1;
                    IG_DTO.Rights = 1;
                    IG_DTO.Id = 1;
                    DS = IG_DAO.ItemGroupDB(IG_DTO);
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

            ItemGroup_Txt_Special.Focus();

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
                if (Duplicate(ItemGroupNumber.Text))
                {
                    IG_DTO.ItemGroupNumber = Convert.ToInt64(ItemGroupNumber.Text);
                    IG_DTO.ItemGroup = ItemGroup_Txt_Special.Text;
                    IG_DTO.IG_Description = IG_Description_Txt_Special.Text;
                    IG_DTO.UnderIGroup = Convert.ToInt64(UnderIGroup_Cmbx.SelectedValue);
                    IG_DTO.MaterialOwnership = Convert.ToInt64(MaterialOwnership_Cmbx.SelectedValue);
                    IG_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue);
                    IG_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue);
                    IG_DTO.MaterialClassification = Convert.ToInt64(MaterialClassification_Cmbx.SelectedValue);
                    IG_DTO.CreatorCode = 1;
                    IG_DTO.Rights = 1;
                    IG_DTO.Id = 5;
                    DS = IG_DAO.ItemGroupDB(IG_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();                   
                }
            }
        }

        private void ItemGroup_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(ItemGroupNumber.Text));
        }
        Boolean Duplicate(String ItemGroupNumber)
        {
            if (ItemGroupNumber.Trim().Length > 0)
            {
                IG_DTO.ItemGroupNumber = Convert.ToInt32(ItemGroupNumber);
                IG_DTO.ItemGroup = ItemGroup_Txt_Special.Text;
                IG_DTO.Id = 7;
                DS = IG_DAO.ItemGroupDB(IG_DTO);
            }
            else
            {
                IG_DTO.ItemGroup = ItemGroup_Txt_Special.Text;
                IG_DTO.Id = 6;
                DS = IG_DAO.ItemGroupDB(IG_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                ItemGroup_Txt_Special.Focus();
                return false;
            }
            return true;
        }
    }
}
