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

namespace ERP.Purchase.Item.SubMaster
{
    public partial class MaterialOwnership : Form
    {
        ItemSubMaster_DTO I_DTO = new ItemSubMaster_DTO();
        ItemSubMaster_DAO I_DAO = new ItemSubMaster_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();
        public MaterialOwnership()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void MaterialOwnership_Load(object sender, EventArgs e)
        {
            
            GetData();
            Clear();
        }
        void GetData()
        {
            I_DTO.Id = 102;
            DS = I_DAO.ItemSubMasterDB(I_DTO);
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
                        I_DTO.Number = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["NumberColumn"].Value);
                        I_DTO.Id = 103;
                        DS = I_DAO.ItemSubMasterDB(I_DTO);
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
                I_DTO.Number = Num;
                I_DTO.Id = 104;
                DS = I_DAO.ItemSubMasterDB(I_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    Txt_Number.Text = DS.Tables[0].Rows[0]["Number"].ToString();
                    Txt_Title.Text = DS.Tables[0].Rows[0]["Ownership"].ToString();
                    Txt_Notes.Text = DS.Tables[0].Rows[0]["Notes"].ToString();

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
                    I_DTO.Title = Txt_Title.Text;
                    I_DTO.Notes = Txt_Notes.Text;
                    I_DTO.CreatorCode = 1;
                    I_DTO.Id = 101;
                    DS = I_DAO.ItemSubMasterDB(I_DTO);
                    MessageBox.Show(Alert.Save());
                    Clear();
                    GetData();
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
                    I_DTO.Number = Convert.ToInt32(Txt_Number.Text);
                    I_DTO.Title = Txt_Title.Text;
                    I_DTO.Notes = Txt_Notes.Text;
                    I_DTO.CreatorCode = 1;
                    I_DTO.Id = 105;
                    DS = I_DAO.ItemSubMasterDB(I_DTO);
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
            if (Number.Trim().Length > 0)
            {
                I_DTO.Number = Convert.ToInt32(Txt_Number.Text);
                I_DTO.Title = Txt_Title.Text;
                I_DTO.Id = 107;
                DS = I_DAO.ItemSubMasterDB(I_DTO);
            }
            else
            {
                I_DTO.Title = Txt_Title.Text;
                I_DTO.Id = 106;
                DS = I_DAO.ItemSubMasterDB(I_DTO);
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
