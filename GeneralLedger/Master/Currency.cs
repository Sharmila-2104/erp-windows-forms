using ERP.ControlMaster.CommonFeatures;
using ERP.Purchase.Tax.Master;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ERP.Purchase.COA.Master
{
    public partial class Currency : Form
    {
        Currency_DAO C_DAO = new Currency_DAO();
        Currency_DTO C_DTO = new Currency_DTO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        String Loc;

        DataSet DS = new DataSet();

        public Currency()
        {
            InitializeComponent();
            Eve.FormController(this);
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            GetData();
            Clear();
        }
        void GetData()
        {
            C_DTO.Id = 2;
            DS = C_DAO.CurrencyDB(C_DTO);
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
                        C_DTO.CurrencyNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_CurrencyNumber"].Value);
                        C_DTO.Id = 3;
                        DS = C_DAO.CurrencyDB(C_DTO);
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
                C_DTO.CurrencyNumber = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["GV_CurrencyNumber"].Value);
                C_DTO.Id = 4;
                DS = C_DAO.CurrencyDB(C_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    CurrencyNumber_Txt.Text = DS.Tables[0].Rows[0]["CurrencyNumber"].ToString();
                    CurrencyCode_Txt_Char.Text = DS.Tables[0].Rows[0]["CurrencyCode"].ToString();
                    FormalName_Txt_Char.Text = DS.Tables[0].Rows[0]["FormalName"].ToString();
                    DecimalPlaces_Txt_Digit.Text = DS.Tables[0].Rows[0]["DecimalPlaces"].ToString();
                    DecimalPortionName_Txt_Special.Text = DS.Tables[0].Rows[0]["DecimalPortionName"].ToString();
                    Loc = DS.Tables[0].Rows[0]["CurrencyLocation"].ToString();
                    if (Loc == "1")
                    {
                        LocalCurrency_Rbtn.Checked = true;
                    }
                    else if (Loc == "2")
                    {
                        ForeignCurrency_Rbtn.Checked = true;
                    }
                    Symbol_Txt.Text = DS.Tables[0].Rows[0]["Symbol"].ToString();

                    CurrencyCode_Txt_Char.Focus();

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
                    C_DTO.CurrencyCode = CurrencyCode_Txt_Char.Text;
                    C_DTO.FormalName = FormalName_Txt_Char.Text;
                    C_DTO.Symbol = Symbol_Txt.Text;
                    C_DTO.DecimalPlaces = Convert.ToInt32(DecimalPlaces_Txt_Digit.Text);
                    if (LocalCurrency_Rbtn.Checked == true)
                    {
                        C_DTO.CurrencyLocation = 1;
                    }
                    else if (ForeignCurrency_Rbtn.Checked == true)
                    {
                        C_DTO.CurrencyLocation = 2;
                    }
                    C_DTO.DecimalPortionName = DecimalPortionName_Txt_Special.Text;
                    C_DTO.CreatorCode = 1;
                    C_DTO.Rights = 1;
                    C_DTO.Id = 1;
                    DS = C_DAO.CurrencyDB(C_DTO);
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
            LocalCurrency_Rbtn.Checked = false;
            ForeignCurrency_Rbtn.Checked = false;

            CurrencyCode_Txt_Char.Focus();

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
                if (Duplicate(CurrencyNumber_Txt.Text))
                {
                    C_DTO.CurrencyNumber = Convert.ToInt32(CurrencyNumber_Txt.Text);
                    C_DTO.CurrencyCode = CurrencyCode_Txt_Char.Text;
                    C_DTO.FormalName = FormalName_Txt_Char.Text;
                    C_DTO.Symbol = Symbol_Txt.Text;
                    C_DTO.DecimalPlaces = Convert.ToInt32(DecimalPlaces_Txt_Digit.Text);
                    C_DTO.DecimalPortionName = DecimalPortionName_Txt_Special.Text;
                    if (LocalCurrency_Rbtn.Checked == true)
                    {
                        C_DTO.CurrencyLocation = 1;
                    }
                    else if (ForeignCurrency_Rbtn.Checked == true)
                    {
                        C_DTO.CurrencyLocation = 2;
                    }
                    C_DTO.CreatorCode = 1;
                    C_DTO.Rights = 1;
                    C_DTO.Id = 5;
                    DS = C_DAO.CurrencyDB(C_DTO);
                    MessageBox.Show(Alert.Edit());
                    GetData();
                    Clear();
                }
            }
        }        
        private void CurrencyCode_Txt_Char_Leave(object sender, EventArgs e)
        {
            Duplicate(Convert.ToString(CurrencyNumber_Txt.Text));
        }
        Boolean Duplicate(String CurrencyNumber)
        {
            if (CurrencyNumber.Length > 0) 
            {
                C_DTO.CurrencyNumber = Convert.ToInt32(CurrencyNumber);
                C_DTO.CurrencyCode = CurrencyCode_Txt_Char.Text;
                C_DTO.Id = 7;
                DS = C_DAO.CurrencyDB(C_DTO);
            }
            else
            {
                C_DTO.CurrencyCode = CurrencyCode_Txt_Char.Text;
                C_DTO.Id = 6;
                DS = C_DAO.CurrencyDB(C_DTO);
            }

            if (DS.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show(Alert.Duplicate());
                CurrencyCode_Txt_Char.Focus();
                return false;
            }
            return true;
        }

        
    }
}
