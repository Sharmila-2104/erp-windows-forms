using ERP.ControlMaster.CommonFeatures;
using ERP_DAO;
using ERP_DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP.Purchase.Tax.Master
{
    public partial class UoM : Form
    {
        UoM_DTO U_DTO = new UoM_DTO();
        UoM_DAO U_DAO = new UoM_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        public UoM()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();           
        }
        void GetData()
        {
            U_DTO.Id = 2;
            DS = U_DAO.UoMDB(U_DTO);
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
                        U_DTO.UnitNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_UnitNumber"].Value);
                        U_DTO.Id =3;
                        DS = U_DAO.UoMDB(U_DTO);
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
                U_DTO.UnitNumber = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["GV_UnitNumber"].Value);
                U_DTO.Id =4;
                DS = U_DAO.UoMDB(U_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    UnitNumber_Txt.Text = DS.Tables[0].Rows[0]["UnitNumber"].ToString();
                    UnitCode_Txt_Char.Text = DS.Tables[0].Rows[0]["UnitCode"].ToString();
                    UnitDescription_Txt_Special.Text = DS.Tables[0].Rows[0]["UnitDescription"].ToString();
                    DecimalPlaces_Txt_Digit.Text = DS.Tables[0].Rows[0]["DecimalPlaces"].ToString();
                    
                    UnitCode_Txt_Char.Focus();

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
                    U_DTO.UnitCode = UnitCode_Txt_Char.Text;
                    U_DTO.UnitDescription = UnitDescription_Txt_Special.Text;
                    U_DTO.DecimalPlaces = Convert.ToInt64(DecimalPlaces_Txt_Digit.Text);
                    U_DTO.CreatorCode = 1;
                    U_DTO.Rights = 1;
                    U_DTO.Id = 1;
                    DS = U_DAO.UoMDB(U_DTO);
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

            UnitCode_Txt_Char.Focus();

            Btn_Save.Visible = true;
            Btn_Update.Visible = false;
            Btn_Clear.Visible = true;
            Btn_Clear.Text = Btn_Clear.Tag.ToString();
        }

        private void Btn_Update_Click (object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (Duplicate(UnitNumber_Txt.Text))
                {
                    U_DTO.UnitNumber = Convert.ToInt32(UnitNumber_Txt.Text);
                    U_DTO.UnitCode = UnitCode_Txt_Char.Text;
                    U_DTO.UnitDescription = UnitDescription_Txt_Special.Text;
                    U_DTO.DecimalPlaces = Convert.ToInt64(DecimalPlaces_Txt_Digit.Text);
                    U_DTO.CreatorCode = 1;
                    U_DTO.Rights = 1;
                    U_DTO.Id =5;
                    DS = U_DAO.UoMDB(U_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }              
            }
        }

        private void UnitCode_Txt_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(UnitNumber_Txt.Text));
        }
        Boolean Duplicate(String UnitNumber)
        {
            if (UnitNumber.Trim().Length > 0)
            {
                U_DTO.UnitNumber = Convert.ToInt32(UnitNumber_Txt.Text);
                U_DTO.UnitCode = UnitCode_Txt_Char.Text;
                U_DTO.Id = 7;
                DS = U_DAO.UoMDB(U_DTO);
            }
            else
            {
                U_DTO.UnitCode = UnitCode_Txt_Char.Text;
                U_DTO.Id = 6;
                DS = U_DAO.UoMDB(U_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                UnitCode_Txt_Char.Focus();
                return false;
            }
            return true;
        }
    }
}
