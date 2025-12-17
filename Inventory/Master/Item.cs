using ERP.ControlMaster.CommonFeatures;
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
    public partial class Item : Form
    {
        Item_DTO I_DTO = new Item_DTO();
        Item_DAO I_DAO = new Item_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();

        DataSet DS = new DataSet();
        Validation Va = new Validation();

        public Item()
        {
            InitializeComponent();
            Eve.FormController(this);
            PanelList.Dock = DockStyle.Fill;
            PanelAdd.Visible = false;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            GetList();
            Clear();
        }

        void GetList()
        {
            I_DTO.Id = 11;
            DS = I_DAO.ItemDB(I_DTO);
            GV_List.DataSource = DS.Tables[0];
        }

        private void GV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        I_DTO.ItemNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_ItemNumber"].Value);
                        I_DTO.Id = 12;
                        DS = I_DAO.ItemDB(I_DTO);
                        MessageBox.Show(Alert.Delete());
                        GetList();
                    }
                    catch
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
            }
            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                I_DTO.ItemNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_ItemNumber"].Value);
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

                    MaterialSegregation_Cmbx.DataSource = DS.Tables[4];
                    MaterialSegregation_Cmbx.ValueMember = "Number";
                    MaterialSegregation_Cmbx.DisplayMember = "Segregation";

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

                    ItemNumber_Txt.Text = DS.Tables[0].Rows[0]["ItemNumber"].ToString();

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
                    MaterialSegregation_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["MaterialSegregation"].ToString();
                    PurchaseWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PurchaseWarehouse"].ToString();

                    SaleWarehouse_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["SaleWarehouse"].ToString();
                    HSN_Code_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["HSN_Code"].ToString();
                    UoM_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["UoM"].ToString();
                    PurchaseUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["PurchaseUnit"].ToString();
                    ProductionUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["ProductionUnit"].ToString();
                    SaleUnit_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["SaleUnit"].ToString();

                    FromUnit_Cmbx.DataSource = DS.Tables[12];
                    FromUnit_Cmbx.ValueMember = "UnitNumber";
                    FromUnit_Cmbx.DisplayMember = "UnitCode";

                    ToUnit_Cmbx.DataSource = DS.Tables[13];
                    ToUnit_Cmbx.ValueMember = "UnitNumber";
                    ToUnit_Cmbx.DisplayMember = "UnitCode";

                    GV_DetailsList.DataSource = DS.Tables[14];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;

                    PanelAdd.Dock = DockStyle.Fill;
                    PanelAdd.Visible = true;
                    PanelAdd.BringToFront();

                    ItemCode_Txt_Special.Focus();

                    Btn_Clear.Text = "Cancel";
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    PanelList.Dock = DockStyle.Fill;
                    PanelAdd.Visible = false;
                }
            }
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            PanelAdd.Dock = DockStyle.Fill;
            PanelAdd.Visible = true;
            PanelAdd.BringToFront();

            GetData();
            Clear();
        }

        void GetData() 
        {
            I_DTO.Id = 2;
            DS = I_DAO.ItemDB(I_DTO);

            ItemGroup_Cmbx.DataSource = DS.Tables[0];
            ItemGroup_Cmbx.ValueMember = "ItemGroupNumber";
            ItemGroup_Cmbx.DisplayMember = "ItemGroup";

            ItemCategory_Cmbx.DataSource = DS.Tables[1];
            ItemCategory_Cmbx.ValueMember = "ItemCategoryNumber";
            ItemCategory_Cmbx.DisplayMember = "ItemCategory";

            ItemSubCategory_Cmbx.DataSource = DS.Tables[2];
            ItemSubCategory_Cmbx.ValueMember = "ItemSubCategoryNumber";
            ItemSubCategory_Cmbx.DisplayMember = "ItemSubCategory";

            MaterialSegregation_Cmbx.DataSource = DS.Tables[3];
            MaterialSegregation_Cmbx.ValueMember = "Number";
            MaterialSegregation_Cmbx.DisplayMember = "Segregation";

            PurchaseWarehouse_Cmbx.DataSource = DS.Tables[4];
            PurchaseWarehouse_Cmbx.ValueMember = "WarehouseNumber";
            PurchaseWarehouse_Cmbx.DisplayMember = "WarehouseCode";

            SaleWarehouse_Cmbx.DataSource = DS.Tables[5];
            SaleWarehouse_Cmbx.ValueMember = "WarehouseNumber";
            SaleWarehouse_Cmbx.DisplayMember = "WarehouseCode";

            HSN_Code_Cmbx.DataSource = DS.Tables[6];
            HSN_Code_Cmbx.ValueMember = "HSN_Number";
            HSN_Code_Cmbx.DisplayMember = "HSN_Code";

            UoM_Cmbx.DataSource = DS.Tables[7];
            UoM_Cmbx.ValueMember = "UnitNumber";
            UoM_Cmbx.DisplayMember = "UnitCode";

            PurchaseUnit_Cmbx.DataSource = DS.Tables[8];
            PurchaseUnit_Cmbx.ValueMember = "UnitNumber";
            PurchaseUnit_Cmbx.DisplayMember = "UnitCode";

            ProductionUnit_Cmbx.DataSource = DS.Tables[9];
            ProductionUnit_Cmbx.ValueMember = "UnitNumber";
            ProductionUnit_Cmbx.DisplayMember = "UnitCode";

            SaleUnit_Cmbx.DataSource = DS.Tables[10];
            SaleUnit_Cmbx.ValueMember = "UnitNumber";
            SaleUnit_Cmbx.DisplayMember = "UnitCode";

            FromUnit_Cmbx.DataSource = DS.Tables[11];
            FromUnit_Cmbx.ValueMember = "UnitNumber";
            FromUnit_Cmbx.DisplayMember = "UnitCode";

            ToUnit_Cmbx.DataSource = DS.Tables[12];
            ToUnit_Cmbx.ValueMember = "UnitNumber";
            ToUnit_Cmbx.DisplayMember = "UnitCode";


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

                for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                {
                    String FromQty = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromQty_Txt"].Value);
                    String FromUnit = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromUnit_Cmbx"].Value);
                    String ToQty = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToQty_Txt"].Value);
                    String ToUnit = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToUnit_Cmbx"].Value);
                    if (FromQty.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("FromQty is required");
                        break;
                    }
                    else if (FromUnit.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("FromUnit is required");
                        break;
                    }
                    else if (ToQty.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("ToQty is required");
                        break;
                    }
                    else if (ToUnit.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("ToUnit is required");
                        break;
                    }
                }

                if (Acc == 1)
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
                    I_DTO.ItemCategory = Convert.ToInt64(ItemCategory_Cmbx.SelectedValue == null ? 1 : ItemCategory_Cmbx.SelectedValue);
                    I_DTO.ItemSubCategory = Convert.ToInt64(ItemSubCategory_Cmbx.SelectedValue == null ? 1 : ItemSubCategory_Cmbx.SelectedValue);
                    I_DTO.MaterialSegregation = Convert.ToInt64(MaterialSegregation_Cmbx.SelectedValue);
                    I_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue == null ? 1 : PurchaseWarehouse_Cmbx.SelectedValue);
                    I_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue == null ? 1 : SaleWarehouse_Cmbx.SelectedValue);
                    I_DTO.HSN_Code = Convert.ToInt64(HSN_Code_Cmbx.SelectedValue == null ? 1 : HSN_Code_Cmbx.SelectedValue);
                    I_DTO.UoM = Convert.ToInt64(UoM_Cmbx.SelectedValue);
                    I_DTO.PurchaseUnit = Convert.ToInt64(PurchaseUnit_Cmbx.SelectedValue == null ? 1 : PurchaseUnit_Cmbx.SelectedValue);
                    I_DTO.ProductionUnit = Convert.ToInt64(ProductionUnit_Cmbx.SelectedValue == null ? 1 : ProductionUnit_Cmbx.SelectedValue);
                    I_DTO.SaleUnit = Convert.ToInt64(SaleUnit_Cmbx.SelectedValue == null ? 1 : SaleUnit_Cmbx.SelectedValue);
                    I_DTO.CreatorCode = 1;
                    I_DTO.Id = 1;
                    DS = I_DAO.ItemDB(I_DTO);


                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        I_DTO.FromQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["FromQty_Txt"].Value.ToString());
                        I_DTO.FromUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["FromUnit_Cmbx"].Value.ToString());
                        I_DTO.ToQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["ToQty_Txt"].Value.ToString());
                        I_DTO.ToUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ToUnit_Cmbx"].Value.ToString());
                        I_DTO.Id = 3;
                        DS = I_DAO.ItemDB(I_DTO);
                    }
                    MessageBox.Show(Alert.Save());
                    Clear();
                    Back();
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Int32 Acc = 1;
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                var list = new List<String>();

                String Val = "";
                for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                {
                    String FromQty = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromQty_Txt"].Value);
                    String FromUnit = Convert.ToString(GV_DetailsList.Rows[i].Cells["FromUnit_Cmbx"].Value);
                    String ToQty = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToQty_Txt"].Value);
                    String ToUnit = Convert.ToString(GV_DetailsList.Rows[i].Cells["ToUnit_Cmbx"].Value);
                    
                    if (GV_DetailsList.Rows[i].Cells["UnitConversionNumber_Txt"].Value != null )
                    {
                        Val = Convert.ToString(GV_DetailsList.Rows[i].Cells["UnitConversionNumber_Txt"].Value.ToString());
                        list.Add(Val);
                    }

                    if (FromQty.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("FromQty is required");
                        break;
                    }
                    else if (FromUnit.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("FromUnit is required");
                        break;
                    }
                    else if (ToQty.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("ToQty is required");
                        break;
                    }
                    else if (ToUnit.Trim().Length < 1)
                    {
                        Acc = 0;
                        MessageBox.Show("ToUnit is required");
                        break;
                    }
                }

                if (Acc == 1)
                {
                    I_DTO.ItemNumber = Convert.ToInt64(ItemNumber_Txt.Text);
                    I_DTO.Search = String.Join(",", list);
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
                    I_DTO.ItemCategory = Convert.ToInt64(ItemCategory_Cmbx.SelectedValue == null ? 1 : ItemCategory_Cmbx.SelectedValue);
                    I_DTO.ItemSubCategory = Convert.ToInt64(ItemSubCategory_Cmbx.SelectedValue == null ? 1 : ItemSubCategory_Cmbx.SelectedValue);
                    I_DTO.MaterialSegregation = Convert.ToInt64(MaterialSegregation_Cmbx.SelectedValue);
                    I_DTO.PurchaseWarehouse = Convert.ToInt64(PurchaseWarehouse_Cmbx.SelectedValue == null ? 1 : PurchaseWarehouse_Cmbx.SelectedValue);
                    I_DTO.SaleWarehouse = Convert.ToInt64(SaleWarehouse_Cmbx.SelectedValue == null ? 1 : SaleWarehouse_Cmbx.SelectedValue);
                    I_DTO.HSN_Code = Convert.ToInt64(HSN_Code_Cmbx.SelectedValue == null ? 1 : HSN_Code_Cmbx.SelectedValue);
                    I_DTO.UoM = Convert.ToInt64(UoM_Cmbx.SelectedValue);
                    I_DTO.PurchaseUnit = Convert.ToInt64(PurchaseUnit_Cmbx.SelectedValue == null ? 1 : PurchaseUnit_Cmbx.SelectedValue);
                    I_DTO.ProductionUnit = Convert.ToInt64(ProductionUnit_Cmbx.SelectedValue == null ? 1 : ProductionUnit_Cmbx.SelectedValue);
                    I_DTO.SaleUnit = Convert.ToInt64(SaleUnit_Cmbx.SelectedValue == null ? 1 : SaleUnit_Cmbx.SelectedValue);
                    I_DTO.Id = 6;
                    DS = I_DAO.ItemDB(I_DTO);

                    String Code = "";
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        if (GV_DetailsList.Rows[i].Cells["UnitConversionNumber_Txt"].Value != null)
                        {
                            Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["UnitConversionNumber_Txt"].Value.ToString());
                        }

                        I_DTO.FromQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["FromQty_Txt"].Value.ToString());
                        I_DTO.FromUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["FromUnit_Cmbx"].Value.ToString());
                        I_DTO.ToQty = Convert.ToDouble(GV_DetailsList.Rows[i].Cells["ToQty_Txt"].Value.ToString());
                        I_DTO.ToUnit = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["ToUnit_Cmbx"].Value.ToString());

                        if (Code == null || Code == "")
                        {
                            I_DTO.Id = 5;
                        }
                        else
                        {
                            I_DTO.UnitConversionNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["UnitConversionNumber_Txt"].Value.ToString());
                            I_DTO.Id = 7;
                        }
                        DS = I_DAO.ItemDB(I_DTO);
                    }
                    MessageBox.Show(Alert.Edit());
                    GetList();
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

            ItemCode_Txt_Special.Focus();

            while (GV_DetailsList.Rows.Count > 1)
            {
                GV_DetailsList.Rows.RemoveAt(0);
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

        private void GV_DetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_DetailsList.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GV_DetailsList.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        
        private void GV_DetailsList_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
                e.Row.Cells["Sample"].Value = "=";
        }

        private void ItemCode_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(ItemNumber_Txt.Text));
        }
        Boolean Duplicate(String ItemNumber)
        {
            if (ItemNumber.Trim().Length > 0)
            {
                I_DTO.ItemNumber = Convert.ToInt32(ItemNumber);
                I_DTO.ItemCode = ItemCode_Txt_Special.Text;
                I_DTO.Id = 9;
                DS = I_DAO.ItemDB(I_DTO);
            }
            else
            {
                I_DTO.ItemCode = ItemCode_Txt_Special.Text;
                I_DTO.Id = 8;
                DS = I_DAO.ItemDB(I_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                ItemCode_Txt_Special.Focus();
                return false;
            }
            return true;
        }

        private void PanelAdd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
