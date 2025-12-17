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

namespace ERP.Purchase.Tax.Master
{
    public partial class HSN : Form
    {
        HSN_DTO HSN_DTO = new HSN_DTO();
        HSN_DAO HSN_DAO = new HSN_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        public HSN()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        void GetData()
        {
            HSN_DTO.Id = 2;
            DS = HSN_DAO.HSNDB(HSN_DTO);
            GV_List.DataSource = DS.Tables[0];
        }
        private void HSN_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }

        private void GV_List_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        HSN_DTO.HSN_Number = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_HSN_Number"].Value);
                        HSN_DTO.Id = 3;
                        DS = HSN_DAO.HSNDB(HSN_DTO);
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
                HSN_DTO.HSN_Number = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_HSN_Number"].Value);
                HSN_DTO.Id = 4;
                DS = HSN_DAO.HSNDB(HSN_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    HSN_Number.Text = DS.Tables[0].Rows[0]["HSN_Number"].ToString();
                    HSN_Code_Txt_Digit.Text = DS.Tables[0].Rows[0]["HSN_Code"].ToString();
                    Description_Txt_Special.Text = DS.Tables[0].Rows[0]["Description"].ToString();

                    HSN_Code_Txt_Digit.Focus();

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
                    HSN_DTO.HSN_Code = HSN_Code_Txt_Digit.Text;
                    HSN_DTO.Description = Description_Txt_Special.Text;
                    HSN_DTO.CreatorCode = 1;
                    HSN_DTO.Rights = 1;
                    HSN_DTO.Id = 1;
                    DS = HSN_DAO.HSNDB(HSN_DTO);
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

            HSN_Code_Txt_Digit.Focus();

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
                if (Duplicate(HSN_Number.Text))
                {
                    HSN_DTO.HSN_Number = Convert.ToInt32(HSN_Number.Text);
                    HSN_DTO.HSN_Code = HSN_Code_Txt_Digit.Text;
                    HSN_DTO.Description = Description_Txt_Special.Text;
                    HSN_DTO.CreatorCode = 1;
                    HSN_DTO.Rights = 1;
                    HSN_DTO.Id = 5;
                    DS = HSN_DAO.HSNDB(HSN_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }
        private void HSN_Code_Txt_Digit_Leave(object sender, EventArgs e)
        {
            String Number = Convert.ToString(HSN_Number.Text);
            Duplicate(Number);
        }        
        Boolean Duplicate(String Number)
        {
            if (Number.Length > 0)
            {
                HSN_DTO.HSN_Number = Convert.ToInt32(HSN_Number.Text);
                HSN_DTO.HSN_Code = HSN_Code_Txt_Digit.Text;
                HSN_DTO.Id = 7;
                DS = HSN_DAO.HSNDB(HSN_DTO);
            }
            else
            {
                HSN_DTO.HSN_Code = HSN_Code_Txt_Digit.Text;
                HSN_DTO.Id = 6;
                DS = HSN_DAO.HSNDB(HSN_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                HSN_Code_Txt_Digit.Focus();
                return false;
            }
            return true;
        }

        
    }
}
