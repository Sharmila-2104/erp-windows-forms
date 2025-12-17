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

namespace ERP.Purchase.Tax
{
    public partial class WithHoldTaxAssign : Form
    {
        WithHoldTaxAssign_DTO WTA_DTO = new WithHoldTaxAssign_DTO();
        WithHoldTaxAssign_DAO WTA_DAO = new WithHoldTaxAssign_DAO();
        DataSet DS = new DataSet();

        public WithHoldTaxAssign()
        {
            InitializeComponent();
        }

        private void WithHoldTaxAssign_Load(object sender, EventArgs e)
        {
            WTA_DTO.Id = 11;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
            GV_List.DataSource = DS.Tables[0];
        }

        private void GV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult Confirm = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirm == DialogResult.Yes)
                {
                    WTA_DTO.Number = Convert.ToInt32(GV_List.Rows[e.RowIndex].Cells["NumberColumn"].Value);
                    WTA_DTO.AssignNumber = WTA_DTO.Number;
                    WTA_DTO.Id = 12;
                    DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
                    MessageBox.Show("Deleted Successfully");
                }
            }
            WTA_DTO.Id = 11;
            DS = WTA_DAO.WHTaxAssignDB(WTA_DTO);
            GV_List.DataSource = DS.Tables[0];

            if (GV_List.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Int64 Code = Convert.ToInt64(GV_List.Rows[e.RowIndex].Cells["NumberColumn"].Value);
                Hide();
                WithHoldTaxAssignAdd WTA = new WithHoldTaxAssignAdd(Code);
                WTA.ShowDialog();
            }
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            Hide();
            WithHoldTaxAssignAdd WTA = new WithHoldTaxAssignAdd();
            WTA.ShowDialog();
        }
    }
}
