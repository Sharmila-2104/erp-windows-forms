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

namespace ERP.Purchase.Tax
{
    public partial class WithholdTaxCategory : Form
    {
        TaxSubMaster_DTO T_DTO = new TaxSubMaster_DTO();
        TaxSubMaster_DAO T_DAO = new TaxSubMaster_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public WithholdTaxCategory()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void WithHoldTaxCategory_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            T_DTO.Id = 2;
            DS = T_DAO.TaxSubMasterDB(T_DTO);
            GV_List.DataSource = DS.Tables[0];
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
                        T_DTO.Number = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["NumberColumn"].Value);
                        T_DTO.Id = 3;
                        DS = T_DAO.TaxSubMasterDB(T_DTO);
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
                Int64 Num = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["NumberColumn"].Value);
                T_DTO.Number = Num;
                T_DTO.Id = 4;
                DS = T_DAO.TaxSubMasterDB(T_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    Txt_Title.Text = DS.Tables[0].Rows[0]["Category"].ToString();
                    Txt_Notes.Text = DS.Tables[0].Rows[0]["Notes"].ToString();
                    Txt_Number.Text = DS.Tables[0].Rows[0]["Number"].ToString();

                    Txt_Title.Focus();

                    Btn_Save.Visible = false;
                    Btn_Update.Visible = true;
                    Btn_Clear.Visible = true;
                    Btn_Clear.Text = "Cancel";
                }
                else
                {
                    MessageBox.Show(Alert.Record());
                    Clear();
                    GetData();
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
                    T_DTO.Title = Txt_Title.Text;
                    T_DTO.Notes = Txt_Notes.Text;
                    T_DTO.CreatorCode = 1;
                    T_DTO.Id = 1;
                    DS = T_DAO.TaxSubMasterDB(T_DTO);
                    Clear();
                    GetData();
                }
                else
                {
                    MessageBox.Show(Alert.Duplicate());
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

            Txt_Title.Focus();

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
                if (Duplicate(Txt_Number.Text))
                {
                    T_DTO.Number = Convert.ToInt32(Txt_Number.Text);
                    T_DTO.Title = Txt_Title.Text;
                    T_DTO.Notes = Txt_Notes.Text;
                    T_DTO.CreatorCode = 1;
                    T_DTO.Id = 5;
                    DS = T_DAO.TaxSubMasterDB(T_DTO);
                    MessageBox.Show(Alert.Edit());
                    Clear();
                    GetData();
                }
            }
        }

        private void Txt_Title_Leave(object sender, EventArgs e)
        {
            String Number = Convert.ToString(Txt_Number.Text);
            Duplicate(Number);
        }
        Boolean Duplicate(String Number)
        {
            if (Number.Length > 0)
            {
                T_DTO.Number = Convert.ToInt32(Txt_Number.Text);
                T_DTO.Title = Txt_Title.Text;
                T_DTO.Id = 7;
                DS = T_DAO.TaxSubMasterDB(T_DTO);
            }
            else
            {
                T_DTO.Title = Txt_Title.Text;
                T_DTO.Id = 6;
                DS = T_DAO.TaxSubMasterDB(T_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                Txt_Title.Focus();
                return false;
            }
            return true;
        }
    }
}
