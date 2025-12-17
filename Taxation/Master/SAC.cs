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
    public partial class SAC : Form
    {
        SAC_DTO SA_DTO = new SAC_DTO();
        SAC_DAO SAC_DAO = new SAC_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public SAC()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void SAC_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            SA_DTO.Id = 2;
            DS = SAC_DAO.SACDB(SA_DTO);
            GV_List.DataSource =DS.Tables[0];
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
                        SA_DTO.SAC_Number = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_SAC_Number"].Value);
                        SA_DTO.Id = 3;
                        DS = SAC_DAO.SACDB(SA_DTO);
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
                SA_DTO.SAC_Number = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_SAC_Number"].Value);
                SA_DTO.Id = 4;
                DS = SAC_DAO.SACDB(SA_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    SAC_Number_Txt.Text = DS.Tables[0].Rows[0]["SAC_Number"].ToString();
                    SAC_Code_Txt_Digit.Text = DS.Tables[0].Rows[0]["SAC_Code"].ToString();
                    Description_Txt_Special.Text = DS.Tables[0].Rows[0]["Description"].ToString();

                    SAC_Code_Txt_Digit.Focus();

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
                    SA_DTO.SAC_Code = SAC_Code_Txt_Digit.Text;
                    SA_DTO.Description = Description_Txt_Special.Text;
                    SA_DTO.CreatorCode = 1;
                    SA_DTO.Rights = 1;
                    SA_DTO.Id = 1;
                    DS = SAC_DAO.SACDB(SA_DTO);
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

            SAC_Code_Txt_Digit.Focus();

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
                if (Duplicate(SAC_Number_Txt.Text))
                {
                    SA_DTO.SAC_Number = Convert.ToInt32(SAC_Number_Txt.Text);
                    SA_DTO.SAC_Code = SAC_Code_Txt_Digit.Text;
                    SA_DTO.Description = Description_Txt_Special.Text;
                    SA_DTO.CreatorCode = 1;
                    SA_DTO.Rights = 1;
                    SA_DTO.Id = 5;
                    DS = SAC_DAO.SACDB(SA_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();                   
                }
            }
        }
        private void SAC_Code_Txt_Digit_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(SAC_Number_Txt.Text));
        }        
        Boolean Duplicate(String SAC_Number)
        {
            if (SAC_Number.Length > 0)
            {
                SA_DTO.SAC_Number = Convert.ToInt32(SAC_Number);
                SA_DTO.SAC_Code = SAC_Code_Txt_Digit.Text;
                SA_DTO.Id = 7;
                DS = SAC_DAO.SACDB(SA_DTO);
            }
            else
            {
                SA_DTO.SAC_Code = SAC_Code_Txt_Digit.Text;
                SA_DTO.Id = 6;
                DS = SAC_DAO.SACDB(SA_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                SAC_Code_Txt_Digit.Focus();
                return false;
            }
            return true;
        }

        
    }
}
