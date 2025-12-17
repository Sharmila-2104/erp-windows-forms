using ERP.ControlMaster.CommonFeatures;
using ERP.ControlMaster.Theme;
using ERP.Purchase.Item.Master;
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
using Telerik.WinControls.UI;
using static System.Net.WebRequestMethods;

namespace ERP.Purchase.Tax.Master
{
    public partial class TaxCluster : Form
    {
        TaxCluster_DTO TC_DTO = new TaxCluster_DTO();
        TaxCluster_DAO TC_DAO = new TaxCluster_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        public TaxCluster()
        {
            InitializeComponent();
            Eve.FormController(this);

            RGV_DetailsList.Click += RGV_DetailsList_Click;
            RGV_DetailsList.ValueChanged += RGV_DetailsList_ValueChanged;
            RGV_DetailsList.CellValidated += new CellValidatedEventHandler(RGV_DetailsList_CellValidated);
        }

        private void GV_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show(Alert.DeleteConfirm(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    try
                    {
                        TC_DTO.TaxClusterNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxClusterNumber"].Value);
                        TC_DTO.Id = 7;
                        DS = TC_DAO.TaxClusterDB(TC_DTO);
                        MessageBox.Show(Alert.Delete());
                        Clear();
                        GetData();
                    }
                    catch
                    {
                        MessageBox.Show(Alert.DeleteReference());
                    }
                }
            }

            else if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Int64 Num = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_TaxClusterNumber"].Value);

                TC_DTO.TaxClusterNumber = Num;
                TC_DTO.CreatorCode = 1;
                TC_DTO.Id = 5;
                DS = TC_DAO.TaxClusterDB(TC_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    TaxCategory_Cmbx.DataSource = DS.Tables[1];
                    TaxCategory_Cmbx.ValueMember = "Number";
                    TaxCategory_Cmbx.DisplayMember = "Category";

                    TaxType_Cmbx.DataSource = DS.Tables[2];
                    TaxType_Cmbx.ValueMember = "Number";
                    TaxType_Cmbx.DisplayMember = "Type";

                    TaxElement_Cmbx.DataSource = DS.Tables[3];
                    TaxElement_Cmbx.ValueMember = "TaxElementNumber";
                    TaxElement_Cmbx.DisplayMember = "TaxElement";

                    TaxCategory_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxCategory"].ToString();
                    TaxType_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["TaxType"].ToString();
                    TaxClusterNumber_Txt.Text = DS.Tables[0].Rows[0]["TaxClusterNumber"].ToString();
                    TaxCluster_Txt_Special.Text = DS.Tables[0].Rows[0]["TaxCluster"].ToString();
                    ClusterDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["ClusterDescription"].ToString();

                    GV_DetailsList.DataSource = DS.Tables[4];

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Text = "Cancel";
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                }
            }
        }

        void GetData()
        {
            TC_DTO.Id = 2;
            DS = TC_DAO.TaxClusterDB(TC_DTO);
            GV_List.DataSource = DS.Tables[0];
            RGV_List.DataSource = DS.Tables[0];

            TaxCategory_Cmbx.DataSource = DS.Tables[1];
            TaxCategory_Cmbx.ValueMember = "Number";
            TaxCategory_Cmbx.DisplayMember = "Category";
            TaxCategory_Cmbx.SelectedIndex = -1;

            TaxType_Cmbx.DataSource = DS.Tables[2];
            TaxType_Cmbx.ValueMember = "Number";
            TaxType_Cmbx.DisplayMember = "Type";
            TaxType_Cmbx.SelectedIndex = -1;

            TaxElement_Cmbx.DataSource = DS.Tables[3];
            TaxElement_Cmbx.ValueMember = "TaxElementNumber";
            TaxElement_Cmbx.DisplayMember = "TaxElement";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                Int32 Acc = 1;
                if (GV_DetailsList.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        String TaxElement = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value);
                        if (TaxElement.Trim().Length > 0)
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
                else
                {
                    Acc = 0;
                    MessageBox.Show("enter required fields");
                }
                if (Acc == 1)
                {
                    TC_DTO.TaxCluster = TaxCluster_Txt_Special.Text;
                    TC_DTO.ClusterDescription = ClusterDescription_Txt_Special.Text;
                    TC_DTO.TaxCategory = Convert.ToInt64(TaxCategory_Cmbx.SelectedValue);
                    TC_DTO.TaxType = Convert.ToInt64(TaxType_Cmbx.SelectedValue);
                    TC_DTO.CreatorCode = 1;
                    TC_DTO.Id = 1;
                    DS = TC_DAO.TaxClusterDB(TC_DTO);
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        if (GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value.ToString() != null)
                        {
                            TC_DTO.TaxElement = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value.ToString());
                            TC_DTO.Id = 4;
                            DS = TC_DAO.TaxClusterDB(TC_DTO);
                        }
                    }
                    Clear();
                    MessageBox.Show(Alert.Save());
                }
            }
        }
        void Clear()
        {
            Va.AllClear(this);

            while (GV_DetailsList.Rows.Count > 1)
            {
                GV_DetailsList.Rows.RemoveAt(0);
            }
            if (Btn_Clear.Text == "Cancel")
            {
                Btn_Clear.Text = Btn_Clear.Tag.ToString();
            }
            else
            {
                Btn_Clear.Text = Btn_Clear.Tag.ToString();
            }

            GetData();


            TaxCluster_Txt_Special.Focus();

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
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
                if (GV_DetailsList.Rows.Count > 1)
                {
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        String TaxElement = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value);
                        if (TaxElement.Trim().Length > 0)
                        {
                            String Code = "";
                            if (GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value != null && GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value.ToString());
                            }
                            list.Add(Code);
                        }
                        else
                        {
                            Acc = 0;
                            MessageBox.Show("enter required fields");
                            break;
                        }
                    }
                }
                else
                {
                    Acc = 0;
                    MessageBox.Show("enter required fields");
                }
                if (Acc == 1)
                {
                    TC_DTO.TaxClusterNumber = Convert.ToInt64(TaxClusterNumber_Txt.Text);
                    TC_DTO.TaxCategory = Convert.ToInt64(TaxCategory_Cmbx.SelectedValue);
                    TC_DTO.TaxType = Convert.ToInt64(TaxType_Cmbx.SelectedValue);
                    TC_DTO.TaxCluster = TaxCluster_Txt_Special.Text;
                    TC_DTO.ClusterDescription = ClusterDescription_Txt_Special.Text;

                    TC_DTO.Search = String.Join(",", list);
                    TC_DTO.Id = 8;
                    DS = TC_DAO.TaxClusterDB(TC_DTO);

                    String Code = "";
                    for (int i = 0; i < GV_DetailsList.Rows.Count - 1; i++)
                    {
                        if (GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value.ToString() != null)
                        {
                            if (GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value != null)
                            {
                                Code = Convert.ToString(GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value.ToString());
                            }
                            TC_DTO.TaxElement = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxElement_Cmbx"].Value.ToString());

                            if (Code == null || Code == "")
                            {
                                TC_DTO.Id = 9;
                            }
                            else
                            {
                                TC_DTO.TaxClusterDetailsNumber = Convert.ToInt64(GV_DetailsList.Rows[i].Cells["TaxClusterDetailsNumber_Txt"].Value.ToString());
                                TC_DTO.Id = 6;
                            }
                            DS = TC_DAO.TaxClusterDB(TC_DTO);
                        }
                    }
                    MessageBox.Show(Alert.Edit());
                    Clear();
                }
            }
        }

        private void TaxCluster_Load(object sender, EventArgs e)
        {
            GetData();
            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
            TaxCategory_Cmbx.Focus();
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

        private void GV_DetailsList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GV_DetailsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String a = Convert.ToString(TaxElement_Cmbx.Index);
            if (e.RowIndex >= 0)
            {
                String selectedValue = Convert.ToString(GV_DetailsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (selectedValue != "")
                {
                    TC_DTO.TaxElement = Convert.ToInt64(selectedValue);
                    TC_DTO.Id = 3;
                    DS = TC_DAO.TaxClusterDB(TC_DTO);
                    GV_DetailsList.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = DS.Tables[0].Rows[0]["ElementDescription"].ToString();
                }
            }
        }

        private void GV_DetailsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GV_DetailsList_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow DataRow in GV_DetailsList.Rows)
            {
                if (DataRow.Index == GV_DetailsList.CurrentCell.RowIndex)
                {
                    continue;
                }
                if (GV_DetailsList.CurrentCell.Value == null)
                {
                    continue;
                }
                if (DataRow.Cells["TaxElement_Cmbx"].Value != null && DataRow.Cells["TaxElement_Cmbx"].Value.ToString() == GV_DetailsList.CurrentCell.Value.ToString())
                {
                    MessageBox.Show("Already Exists");
                    //MessageBox.Show(e.RowIndex.ToString());
                    //MessageBox.Show(GV_DetailsList.CurrentCell.RowIndex.ToString());
                    try
                    {
                        GV_DetailsList.CurrentCell.Value = DBNull.Value;
                        GV_DetailsList.Rows.RemoveAt(e.RowIndex);
                    }
                    catch { }
                }
            }
        }

        private void TaxCluster_Txt_Special_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(TaxClusterNumber_Txt.Text));
        }

        Boolean Duplicate(String TaxClusterNumber)
        {
            if (TaxClusterNumber.Trim().Length > 0)
            {
                TC_DTO.TaxClusterNumber = Convert.ToInt32(TaxClusterNumber);
                TC_DTO.TaxCluster = TaxCluster_Txt_Special.Text;
                TC_DTO.Id = 12;
                DS = TC_DAO.TaxClusterDB(TC_DTO);
            }
            else
            {
                TC_DTO.TaxCluster = TaxCluster_Txt_Special.Text;
                TC_DTO.Id = 11;
                DS = TC_DAO.TaxClusterDB(TC_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                TaxCluster_Txt_Special.Clear();
                TaxCluster_Txt_Special.Focus();
                return false;
            }
            return true;
        }


        private void RGV_DetailsList_Click(object sender, EventArgs e)
        {
            if (TaxCategory_Cmbx.SelectedValue != null && TaxType_Cmbx.SelectedValue != null)
            {

                TC_DTO.TaxCategory = Convert.ToInt64(TaxCategory_Cmbx.SelectedValue);
                TC_DTO.TaxType = Convert.ToInt64(TaxType_Cmbx.SelectedValue);
                TC_DTO.Id = 13;
                DS = TC_DAO.TaxClusterDB(TC_DTO);

                GridViewComboBoxColumn GV_TaxElement_Cmbx = (GridViewComboBoxColumn)RGV_DetailsList.Columns["TaxElement_Cmbx"];
                GV_TaxElement_Cmbx.DataSource = DS.Tables[0];
                GV_TaxElement_Cmbx.DisplayMember = "TaxElement";
                GV_TaxElement_Cmbx.ValueMember = "TaxElementNumber";
            }
        }
        private void RGV_DetailsList_ValueChanged(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = RGV_DetailsList.CurrentRow;

            if (this.RGV_DetailsList.ActiveEditor is RadDropDownListEditor dropDownListEditor)
            {
                RadDropDownListEditorElement RRR = (RadDropDownListEditorElement)dropDownListEditor.EditorElement;
                GridComboBoxCellElement RRE = (GridComboBoxCellElement)RRR.Parent;
                GridViewComboBoxColumn GCB = (GridViewComboBoxColumn)RRE.Data;

                if (Convert.ToString(this.RGV_DetailsList.ActiveEditor.Value) != "" && GCB.Name == "TaxElement_Cmbx")
                {
                    String TaxElement = Convert.ToString(this.RGV_DetailsList.ActiveEditor.Value);
                    if (TaxElement != null)
                    {
                        TC_DTO.TaxElement = Convert.ToInt64(TaxElement);
                        TC_DTO.Id = 3;
                        DS = TC_DAO.TaxClusterDB(TC_DTO);
                        currentRow.Cells["ElementDescription_Txt"].Value = DS.Tables[0].Rows[0]["ElementDescription"].ToString();
                    }
                }
            }

            string currentValue = Convert.ToString(RGV_DetailsList.ActiveEditor.Value);

            foreach (GridViewRowInfo dataRow in RGV_DetailsList.Rows)
            {
                if (dataRow.Index == currentRow.Index)
                {
                    continue;
                }

                if (dataRow.Cells["TaxElement_Cmbx"].Value == null)
                {
                    continue;
                }

                if (dataRow.Cells["TaxElement_Cmbx"].Value.ToString() == currentValue)
                {
                    MessageBox.Show("Already Exists");
                    RGV_DetailsList.Rows.Remove(currentRow);
                    //try
                    //{
                    //    foreach (GridViewCellInfo cell in currentRow.Cells)
                    //    {
                    //        cell.Value = DBNull.Value;
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("An error occurred: " + ex.Message);
                    //}
                    break; 
                }
            }
        }
        private void RGV_DetailsList_CellValidated(object sender, CellValidatedEventArgs e)
        {
            //GridViewRowInfo currentRow = RGV_DetailsList.CurrentRow;

            //foreach (GridViewRowInfo DataRow in RGV_DetailsList.Rows)
            //{
            //    if (DataRow.Index == RGV_DetailsList.CurrentCell.RowIndex)
            //    {
            //        continue;
            //    }
            //    if (RGV_DetailsList.CurrentCell.Value == null)
            //    {
            //        continue;
            //    }
            //    if (DataRow.Cells["TaxElement_Cmbx"].Value != null && DataRow.Cells["TaxElement_Cmbx"].Value.ToString() == RGV_DetailsList.CurrentCell.Value.ToString())
            //    {
            //        MessageBox.Show("Already Exists");
            //        try
            //        {
            //            RGV_DetailsList.CurrentCell.Value = DBNull.Value;
            //            RGV_DetailsList.Rows.RemoveAt(0);
            //        }
            //        catch { }
            //    }
            //}
        }
    }
}
