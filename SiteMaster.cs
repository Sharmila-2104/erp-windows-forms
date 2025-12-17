using ERP.ControlMaster.FontFamily;
using ERP.GeneralLedger.Master;
using ERP.Inventory.Submaster;
using ERP.Procurement;
using ERP.Purchase.COA.Master;
using ERP.Purchase.COA.SubMaster;
using ERP.Purchase.Item;
using ERP.Purchase.Item.Master;
using ERP.Purchase.Item.SubMaster;
using ERP.Purchase.Tax;
using ERP.Purchase.Tax.Master;
using ERP.Purchase.Vendor;
using ERP.Purchase.Vendor.Master;
using ERP.Taxation.Submaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class SiteMaster : Form
    {
        //reference
        Fonts F = new Fonts();

        //fileds
        public Form activeForm;
        string[] General = { "NatureOfGroup", "COA_LedgerGroup", "COA_Ledger", "Currency"};
        string[] Procu = { "NatureofAssessee", "PaymentBase", "AssesseeTerritory", "RegistrationType", "VendorCategory", "VendorGroup", "Vendor", "PurchaseOrderCreate", "GRNAdd", "PurchaseList", "PurchaseNumber" };
        string[] Inven = { "MaterialClassification", "MaterialOwnership", "WarehouseCategory", "Warehouse", "ExpenseCode", "UoM", "ItemSubcategory", "ItemCategory", "ItemGroup" , "MaterialSegregation" , "Item" };
        string[] Taxa = { "WithHoldTaxType", "WithHoldTaxCategory", "TaxType", "TaxCategory", "SAC", "HSN", "WithholdTax", "TaxElement", "WithHoldTaxAssign", "TaxSetup", "TaxDesign", "TaxCluster", "TaxImpact" };

        public SiteMaster()
        {
            InitializeComponent();
            AppSetup();
        }
        void AppSetup()
        {
            PanelProcurement.Visible = true;
            PanelProcurement.Dock = DockStyle.Fill;
            PanelInventory.Dock = DockStyle.Fill;
            PanelLedger.Dock = DockStyle.Fill;
            PanelTaxation.Dock = DockStyle.Fill;

            Int32 PWid = PanelProcurement.Width;
            Int32 PWidOne = (PanelProcurement.Width / 3);

            ProLeft.Size = new Size(PWidOne, PanelProcurement.Height);
            ProCenter.Size = new Size(PWidOne, PanelProcurement.Height);
            ProRight.Size = new Size(PWidOne, PanelProcurement.Height);

            InvLeft.Size = new Size(PWidOne, PanelProcurement.Height);
            InvCenter.Size = new Size(PWidOne, PanelProcurement.Height);
            InvRight.Size = new Size(PWidOne, PanelProcurement.Height);

            LedLeft.Size = new Size(PWidOne, PanelProcurement.Height);
            LedCenter.Size = new Size(PWidOne, PanelProcurement.Height);
            LedRight.Size = new Size(PWidOne, PanelProcurement.Height);

            TaxLeft.Size = new Size(PWidOne, PanelProcurement.Height);
            TaxCenter.Size = new Size(PWidOne, PanelProcurement.Height);
            TaxRight.Size = new Size(PWidOne, PanelProcurement.Height);

            PanelProcurement.Visible = false;
            PanelInventory.Visible = false;
            PanelLedger.Visible = false;
            PanelTaxation.Visible = false;
            ChildPanel.Visible = false;
            CloseButton.Visible = false;
        }

        private void SiteMaster_Load(object sender, EventArgs e)
        {
            LoginMenu.BackColor = Color.WhiteSmoke;
        }

        private void Procurement_Click(object sender, EventArgs e)
        {
            AppSetup();

            if (activeForm != null)
            {
                activeForm.Close();
            }
            PanelProcurement.Visible = true;
            PageTitle.Text = "Procurement";
        }
        private void Inventory_Click(object sender, EventArgs e)
        {
            AppSetup();

            if (activeForm != null)
            {
                activeForm.Close();
            }
            PanelInventory.Visible = true;
            PageTitle.Text = "Inventory";
        }
        private void GeneralLedger_Click(object sender, EventArgs e)
        {
            AppSetup();

            if (activeForm != null)
            {
                activeForm.Close();
            }
            PanelLedger.Visible = true;
            PageTitle.Text = "General Ledger";
        }
        private void Taxation_Click(object sender, EventArgs e)
        {
            AppSetup();

            if (activeForm != null)
            {
                activeForm.Close();
            }
            PanelTaxation.Visible = true;
            PageTitle.Text = "Taxation";
        }

        //Form Load
        public void OpenChildForm(Form childForm)
        {
            ChildPanel.Visible= true;
            ChildPanel.Dock = DockStyle.Fill;

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;

            try
            {
                childForm.BringToFront();
                childForm.Show();
            }
            catch
            {

            }

            PageTitle.Text = childForm.Text;

            CloseButton.Visible = true;
        }


        //Procurement Master
        private void Vendor_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new Vendor());
        }
        private void VendorGroup_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new VendorGroup());
        }
        private void VendorCat_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new VendorCategory());
        }

        //Procurement Submaster
        private void RegistrationType_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new RegistrationType());
        }
        private void AssesseeTerritory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new AssesseeTerritory());
        }
        private void PaymentBase_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new PaymentBase());
        }
        private void NatureofAssessee_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new NatureofAssessee());
        }

        //Procurement Transaction
        private void PurchaseOrder_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new PurchaseOrderCreate());
        }
        private void PurchaseInvoice_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new GRNAdd());
        }
        
        //Procurement Settings
        private void PurchaseOrderNumber_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new PurchaseNumber());
        }

        private void GRN_Number_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new GRNNumber());
        }

        //Procurement Report
        private void PurchaseOrderRegister_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new PurchaseRegister());
            //PurchaseList()
        }

        //Inventory master
        private void Item_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new Item());
        }
        private void ItemGroup_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new ItemGroup());
        }
        private void ItemCategory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new ItemCategory());
        }
        private void ItemSubcategory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new ItemSubCategory());
        }
        private void UoM_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new UoM());
        }
        private void Warehouse_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new Warehouse());
        }
        private void ExpenseCode_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new ExpenseCode());
        }

        //Inventory Submaster
        private void MaterialClassification_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new MaterialClassification());
        }
        private void MaterialOwnership_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new MaterialOwnership());
        }
        private void WarehouseCategory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new WarehouseCategory());
        }
        private void MaterialSegregation_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new MaterialSegregation());
        }

        //General Ledger master
        private void Currency_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new Currency());
        }
        private void COALedger_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new COA_Ledger());
        }
        private void COAGroup_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new COA_LedgerGroup());
        }
        
        //General Ledger Submaster
        private void NatureofCOAGroup_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new NatureOfGroup());
        }

        //Taxation Master
        private void HSN_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new HSN());
        }
        private void SAC_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new SAC());
        }
        private void WithholdTax_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new WithholdTax());
        }
        private void WithholdTaxAssign_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new WithHoldTaxAssign());
        }
        private void TaxElement_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxElement());
        }
        private void TaxCluster_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxCluster());
        }
        private void TaxSetup_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxSetup());
        }
        private void TaxDesign_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxDesign());
        }

        //Taxation SubMaster
        private void TaxCategory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxCategory());
        }
        private void TaxType_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxType());
        }
        private void WithholdTaxCategory_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new WithholdTaxCategory());
        }
        private void WithholdTaxType_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new WithholdTaxType());
        }
        private void TaxImpact_Click(object sender, EventArgs e)
        {
            CollapseMenu(1);
            AppSetup();
            OpenChildForm(new TaxImpact());
        }

        void CollapseMenu(Int32 Menu)
        {
            if (this.SidePanel.Width > 200 || Menu==1)
            {
                SidePanel.Width = 40;
                MenuCollapse.Dock = DockStyle.Fill;
                MenuCollapse.Image = Properties.Resources.chevron_right;

                foreach (Label MenuLabel in MenuPanel.Controls.OfType<Label>())
                {
                    MenuLabel.Text = "";
                    MenuLabel.ImageAlign = ContentAlignment.MiddleCenter;
                    MenuLabel.Padding = new Padding(0);
                }
            }
            else
            {
                SidePanel.Width = 300;
                MenuCollapse.Dock = DockStyle.None;
                MenuCollapse.Image = Properties.Resources.chevron_left;

                foreach (Label MenuLabel in MenuPanel.Controls.OfType<Label>())
                {
                    MenuLabel.Text = MenuLabel.Tag.ToString();
                    MenuLabel.ImageAlign = ContentAlignment.MiddleLeft;
                    MenuLabel.Padding = new Padding(0);
                }
            }
        }
        private void MenuCollapse_Click(object sender, EventArgs e)
        {
            CollapseMenu(0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ForChange();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ForChange();
            }
        }
        void ForChange()
        {
            PanelProcurement.Visible = false;
            PanelInventory.Visible = false;
            PanelLedger.Visible = false;
            ChildPanel.Visible = false;
            CloseButton.Visible = false;

            string GeneralArray = Array.Find(General, name => name.ToLower() == activeForm.Name.ToLower());
            if (GeneralArray != null)
            {
                activeForm.Close();
                PanelLedger.Visible = true;
                PageTitle.Text = "General Ledger";
            }
            string ProcuArray = Array.Find(Procu, name => name.ToLower() == activeForm.Name.ToLower());
            if (ProcuArray != null)
            {
                activeForm.Close();
                PanelProcurement.Visible = true;
                PageTitle.Text = "Procurement";
            }
            string InvenArray = Array.Find(Inven, name => name.ToLower() == activeForm.Name.ToLower());
            if (InvenArray != null)
            {
                activeForm.Close();
                PanelInventory.Visible = true;
                PageTitle.Text = "Inventory";
            }
            string TaxaArray = Array.Find(Taxa, name => name.ToLower() == activeForm.Name.ToLower());
            if (TaxaArray != null)
            {
                activeForm.Close();
                PanelTaxation.Visible = true;
                PageTitle.Text = "Taxation";
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                ForChange();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
