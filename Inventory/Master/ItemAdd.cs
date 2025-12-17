using ERP.Purchase.Item.Master;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Purchase.Item
{
    public partial class ItemAdd : Form
    {
        Item_DAO I_DAO = new Item_DAO();
        Item_DTO I_DTO = new Item_DTO();

        DataSet DS = new DataSet();
        Int64 Code = 0;

        public ItemAdd()
        {
            InitializeComponent();
        }

        public ItemAdd(Int64 Number)
        {
            InitializeComponent();
            Code = Number;
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {
            if (Code == 0)
            {
                Btn_Save.Visible = true;
                Btn_Update.Visible = false;
                Btn_Clear.Visible = true;
                GV_DetailsList.Columns["DeleteColumn"].Visible = false;

                I_DTO.Id = 2;
                DS = I_DAO.ItemDB(I_DTO);

                ItemGroup_Cmbx.DataSource = DS.Tables[1];
                ItemGroup_Cmbx.ValueMember = "ItemGroupNumber";
                ItemGroup_Cmbx.DisplayMember = "ItemGroup";

                ItemCategory_Cmbx.DataSource = DS.Tables[2];
                ItemCategory_Cmbx.ValueMember = "ItemCategoryNumber";
                ItemCategory_Cmbx.DisplayMember = "ItemCategory";

                ItemSubCategory_Cmbx.DataSource = DS.Tables[3];
                ItemSubCategory_Cmbx.ValueMember = "ItemSubCategoryNumber";
                ItemSubCategory_Cmbx.DisplayMember = "ItemSubCategory";

                MaterialClassification_Cmbx.DataSource = DS.Tables[4];
                MaterialClassification_Cmbx.ValueMember = "Number";
                MaterialClassification_Cmbx.DisplayMember = "MaterialClassification";

                PurchaseWarehouse_Cmbx.DataSource = DS.Tables[5];
                PurchaseWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                PurchaseWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                SaleWarehouse_Cmbx.DataSource = DS.Tables[6];
                SaleWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                SaleWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                HSN_Code_Cmbx.DataSource = DS.Tables[7];
                HSN_Code_Cmbx.ValueMember = "HSN_Number";
                HSN_Code_Cmbx.DisplayMember = "HSN_Code";

                UoM_Cmbx.DataSource = DS.Tables[8];
                UoM_Cmbx.ValueMember = "UnitNumber";
                UoM_Cmbx.DisplayMember = "UnitCode";

                PurchaseUnit_Cmbx.DataSource = DS.Tables[9];
                PurchaseUnit_Cmbx.ValueMember = "UnitNumber";
                PurchaseUnit_Cmbx.DisplayMember = "UnitCode";

                ProductionUnit_Cmbx.DataSource = DS.Tables[10];
                ProductionUnit_Cmbx.ValueMember = "UnitNumber";
                ProductionUnit_Cmbx.DisplayMember = "UnitCode";

                SaleUnit_Cmbx.DataSource = DS.Tables[11];
                SaleUnit_Cmbx.ValueMember = "UnitNumber";
                SaleUnit_Cmbx.DisplayMember = "UnitCode";

                FromUnit_Cmbx.DataSource = DS.Tables[12];
                FromUnit_Cmbx.ValueMember = "ItemUnitConversion";
                FromUnit_Cmbx.DisplayMember = "FromUnit";

                ToUnit_Cmbx.DataSource = DS.Tables[13];
                ToUnit_Cmbx.ValueMember = "ItemUnitConversion";
                ToUnit_Cmbx.DisplayMember = "ToUnit";
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

            I_DTO.ItemNumber = Number;
            I_DTO.Id = 4;
            DS = I_DAO.ItemDB(I_DTO);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ItemGroup_Cmbx.DataSource = DS.Tables[1];
                ItemGroup_Cmbx.ValueMember = "ItemGroupNumber";
                ItemGroup_Cmbx.DisplayMember = "ItemGroup";

                ItemCategory_Cmbx.DataSource = DS.Tables[2];
                ItemCategory_Cmbx.ValueMember = "ItemCategoryNumber";
                ItemCategory_Cmbx.DisplayMember = "ItemCategory";

                ItemSubCategory_Cmbx.DataSource = DS.Tables[3];
                ItemSubCategory_Cmbx.ValueMember = "ItemSubCategoryNumber";
                ItemSubCategory_Cmbx.DisplayMember = "ItemSubCategory";

                MaterialClassification_Cmbx.DataSource = DS.Tables[4];
                MaterialClassification_Cmbx.ValueMember = "Number";
                MaterialClassification_Cmbx.DisplayMember = "Classification";

                PurchaseWarehouse_Cmbx.DataSource = DS.Tables[5];
                PurchaseWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                PurchaseWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                SaleWarehouse_Cmbx.DataSource = DS.Tables[6];
                SaleWarehouse_Cmbx.ValueMember = "WarehouseNumber";
                SaleWarehouse_Cmbx.DisplayMember = "WarehouseCode";

                HSN_Code_Cmbx.DataSource = DS.Tables[7];
                HSN_Code_Cmbx.ValueMember = "HSN_Number";
                HSN_Code_Cmbx.DisplayMember = "HSN_Code";

                UoM_Cmbx.DataSource = DS.Tables[8];
                UoM_Cmbx.ValueMember = "UnitNumber";
                UoM_Cmbx.DisplayMember = "UnitCode";

                PurchaseUnit_Cmbx.DataSource = DS.Tables[9];
                PurchaseUnit_Cmbx.ValueMember = "UnitNumber";
                PurchaseUnit_Cmbx.DisplayMember = "UnitCode";

                ProductionUnit_Cmbx.DataSource = DS.Tables[10];
                ProductionUnit_Cmbx.ValueMember = "UnitNumber";
                ProductionUnit_Cmbx.DisplayMember = "UnitCode";

                SaleUnit_Cmbx.DataSource = DS.Tables[11];
                SaleUnit_Cmbx.ValueMember = "UnitNumber";
                SaleUnit_Cmbx.DisplayMember = "UnitCode";

                FromUnit_Cmbx.DataSource = DS.Tables[12];
                FromUnit_Cmbx.ValueMember = "ItemUnitConversion";
                FromUnit_Cmbx.DisplayMember = "FromUnit";

                ToUnit_Cmbx.DataSource = DS.Tables[13];
                ToUnit_Cmbx.ValueMember = "ItemUnitConversion";
                ToUnit_Cmbx.DisplayMember = "ToUnit";


                ItemCode_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemCode"].ToString();
                ItemDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemDescription"].ToString();
                ItemPartNumber_Txt_Special.Text = DS.Tables[0].Rows[0]["ItemPartNumber"].ToString();
                InnerDia_Txt_Special.Text = DS.Tables[0].Rows[0]["InnerDia"].ToString();
                OuterDia_Txt_Special.Text = DS.Tables[0].Rows[0]["OuterDia"].ToString();
                Thickness_Txt_Special.Text = DS.Tables[0].Rows[0]["Thickness"].ToString();
                Length_Txt_Special.Text = DS.Tables[0].Rows[0]["Length"].ToString();
                Spec_Txt_Special.Text = DS.Tables[0].Rows[0]["Spec"].ToString();
                MaterialGrade_Txt_Special.Text = DS.Tables[0].Rows[0]["MaterialGrade"].ToString();

                ItemGroup_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["ItemGroup"].ToString();
                ItemCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["ItemCategory"].ToString();
                ItemSubCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["ItemSubCategory"].ToString();
                MaterialClassification_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["MaterialClassification"].ToString();
                PurchaseWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PurchaseWarehouse"].ToString();

                SaleWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["SaleWarehouse"].ToString();
                HSN_Code_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["HSN_Code"].ToString();
                UoM_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UoM"].ToString();
                PurchaseUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PurchaseUnit"].ToString();
                ProductionUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["ProductionUnit"].ToString();
                SaleUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["SaleUnit"].ToString();
                
                FromUnit_Cmbx.DataSource = DS.Tables[1];
                FromUnit_Cmbx.ValueMember = "ItemUnitConversion";
                FromUnit_Cmbx.DisplayMember = "FromUnit";

                ToUnit_Cmbx.DataSource = DS.Tables[2];
                ToUnit_Cmbx.ValueMember = "ItemUnitConversion";
                ToUnit_Cmbx.DisplayMember = "ToUnit";

                GV_DetailsList.DataSource = DS.Tables[0];

                
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ItemCode_Txt_Special.Text))
            {
                ItemCode_Txt_Special.Focus();
                MessageBox.Show("Item Code is Required");
            }

            else
            {
                I_DTO.ItemCode = ItemCode_Txt_Special.Text;
                I_DTO.ItemDescription = ItemDescription_Txt_Special.Text;
                I_DTO.ItemPartNumber = ItemPartNumber_Txt_Special.Text;
                I_DTO.InnerDia = InnerDia_Txt_Special.Text;
                I_DTO.OuterDia = OuterDia_Txt_Special.Text;
                I_DTO.Thickness = Thickness_Txt_Special.Text;
                I_DTO.Length = Length_Txt_Special.Text;
                I_DTO.Spec = Spec_Txt_Special.Text;
                I_DTO.MaterialGrade = MaterialGrade_Txt_Special.Text;

                I_DTO.ItemGroup = Convert.ToInt64(ItemGroup_Cmbx.SelectedValue);
                I_DTO.ItemCategory = Convert.ToInt64(ItemCategory_Cmbx.SelectedValue);
                I_DTO.ItemSubCategory = Convert.ToInt64(ItemSubCategory_Cmbx.SelectedValue);
                I_DTO.MaterialSegregation = Convert.ToInt64(MaterialClassification_Cmbx.SelectedValue);
                I_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue);
                I_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue);

                I_DTO.HSN_Code = Convert.ToInt64(HSN_Code_Cmbx.SelectedValue);
                I_DTO.UoM = Convert.ToInt64(UoM_Cmbx.SelectedValue);
                I_DTO.PurchaseUnit = Convert.ToInt64(PurchaseUnit_Cmbx.SelectedValue);
                I_DTO.ProductionUnit = Convert.ToInt64(ProductionUnit_Cmbx.SelectedValue);
                I_DTO.SaleUnit = Convert.ToInt64(SaleUnit_Cmbx.SelectedValue);
                I_DTO.CreatorCode = 1;
                I_DTO.Id = 1;
                DS = I_DAO.ItemDB(I_DTO);

                try
                {
                    for (int i = 0; i < GV_DetailsList.Rows.Count-1; i++)
                    {
                        I_DTO.FromQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["FromQty_Txt"].Value.ToString());
                        I_DTO.FromUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["FromUnit_Cmbx"].Value.ToString());
                        I_DTO.ToQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["ToQty_Txt"].Value.ToString());
                        I_DTO.ToUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ToUnit_Cmbx"].Value.ToString());
                        I_DTO.Id = 3;
                        DS = I_DAO.ItemDB(I_DTO);
                    }
                }
                catch { }
                Clear();
                MessageBox.Show("Added Successfully");
            }

            void Clear()
            {
                ItemCode_Txt_Special.Clear();
                ItemDescription_Txt_Special.Clear();
                ItemPartNumber_Txt_Special.Clear();
                InnerDia_Txt_Special.Clear();
                OuterDia_Txt_Special.Clear();
                Thickness_Txt_Special.Clear();
                Length_Txt_Special.Clear();
                Spec_Txt_Special.Clear();
                MaterialGrade_Txt_Special.Clear();
                GV_DetailsList.Rows.Clear();
            }
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Item List = new Item();
            List.Show();

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ItemCode_Txt_Special.Text))
            {
                ItemCode_Txt_Special.Focus();
                MessageBox.Show("Item Code is Required");
            }
            else
            {
                I_DTO.ItemCode = ItemCode_Txt_Special.Text;
                I_DTO.ItemDescription = ItemDescription_Txt_Special.Text;
                I_DTO.ItemPartNumber = ItemPartNumber_Txt_Special.Text;
                I_DTO.InnerDia = InnerDia_Txt_Special.Text;
                I_DTO.OuterDia = OuterDia_Txt_Special.Text;
                I_DTO.Thickness = Thickness_Txt_Special.Text;
                I_DTO.Length = Length_Txt_Special.Text;
                I_DTO.Spec = Spec_Txt_Special.Text;
                I_DTO.MaterialGrade = MaterialGrade_Txt_Special.Text;

                I_DTO.ItemGroup = Convert.ToInt64(ItemGroup_Cmbx.SelectedValue);
                I_DTO.ItemCategory = Convert.ToInt64(ItemCategory_Cmbx.SelectedValue);
                I_DTO.ItemSubCategory = Convert.ToInt64(ItemSubCategory_Cmbx.SelectedValue);
                I_DTO.MaterialSegregation = Convert.ToInt64(MaterialClassification_Cmbx.SelectedValue);
                I_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue);
                I_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue);


                I_DTO.HSN_Code = Convert.ToInt64(HSN_Code_Cmbx.SelectedValue);
                I_DTO.UoM = Convert.ToInt64(UoM_Cmbx.SelectedValue);
                I_DTO.PurchaseUnit = Convert.ToInt64(PurchaseUnit_Cmbx.SelectedValue);
                I_DTO.ProductionUnit = Convert.ToInt64(ProductionUnit_Cmbx.SelectedValue);
                I_DTO.SaleUnit = Convert.ToInt64(SaleUnit_Cmbx.SelectedValue);
                I_DTO.Id = 6;
                DS = I_DAO.ItemDB(I_DTO);
                
                String Code = "";
                for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                {
                    if (GV_DetailsList.Rows[i].Cells["GV_Number"].Value != null)
                    {
                        Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["GV_Number"].Value.ToString());
                    }

                    I_DTO.FromQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["GV_Qty"].Value.ToString());
                    I_DTO.FromUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["DDL_FromUnit"].Value.ToString());
                    I_DTO.ToQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["GV_ToQty"].Value.ToString());
                    I_DTO.ToUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["DDL_ToUnit"].Value.ToString());

                    if (Code == null || Code == "")
                    {
                        I_DTO.Id = 3;
                    }
                    else
                    {
                        I_DTO.ItemNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["GV_Number"].Value.ToString());
                        I_DTO.Id = 8;
                    }
                    DS = I_DAO.ItemDB(I_DTO);
                }
                MessageBox.Show("Updated Successfully");
            }
        }

        void GV_DDL()
        {
            I_DTO.Id = 2;
            DS = I_DAO.ItemDB(I_DTO);   
        }

        private void GV_ItemD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_DetailsList.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    I_DTO.ItemNumber = Convert.ToInt32(GV_DetailsList.Rows[e.RowIndex].Cells["GV_Number"].Value);
                    I_DTO.Id = 9;
                    DS = I_DAO.ItemDB(I_DTO);
                    GetData(Code);
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
        }
    }
}
