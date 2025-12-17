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

namespace ERP.Procurement
{
    public partial class GRNNumber : Form
    {
        GRNNumber_DTO G_DTO = new GRNNumber_DTO();
        GRNNumber_DAO G_DAO = new GRNNumber_DAO();

        Alerts Alert = new Alerts();
        Events Eve = new Events();
        Validation Va = new Validation();

        DataSet DS = new DataSet();

        MonthCalendar myCal = new MonthCalendar();
        PictureBox PBox = new PictureBox();

        MonthCalendar P_myCal = new MonthCalendar();
        PictureBox P_PBox = new PictureBox();

        MonthCalendar S_myCal = new MonthCalendar();
        PictureBox S_PBox = new PictureBox();

        Rectangle Rect = new Rectangle();


        public GRNNumber()
        {
            InitializeComponent();
            Eve.FormController(this);

            myCal.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);
            myCal.Leave += new EventHandler(MonthCalendar_Leave);

            PBox.Click += new EventHandler(PBox_Click);

            PBox.Visible = false;
            myCal.Visible = false;

            GV_Reset.Controls.Add(PBox);
            GV_Reset.Controls.Add(myCal);



            P_myCal.DateSelected += new DateRangeEventHandler(G_MonthCalendar_DateSelected);
            P_myCal.Leave += new EventHandler(G_MonthCalendar_Leave);

            P_PBox.Click += new EventHandler(G_PBox_Click);

            P_PBox.Visible = false;
            P_myCal.Visible = false;

            GV_Prefix.Controls.Add(P_PBox);
            GV_Prefix.Controls.Add(P_myCal);



            S_myCal.DateSelected += new DateRangeEventHandler(S_MonthCalendar_DateSelected);
            S_myCal.Leave += new EventHandler(S_MonthCalendar_Leave);

            S_PBox.Click += new EventHandler(S_PBox_Click);

            S_PBox.Visible = false;
            S_myCal.Visible = false;

            GV_Suffix.Controls.Add(S_PBox);
            GV_Suffix.Controls.Add(S_myCal);
        }
        private void GRNNumber_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        void OnLoad()
        {
            GRNMethod_Cmbx.Focus();
            GRNPanel.Visible = false;
            G_DTO.Id = 1;
            DS = G_DAO.GRNNumberDB(G_DTO);

            GRNMethod_Cmbx.DataSource = DS.Tables[0];
            GRNMethod_Cmbx.DisplayMember = "Method";
            GRNMethod_Cmbx.ValueMember = "Number";
            GRNMethod_Cmbx.SelectedIndex = -1;

            R_Prefil_Cmbx.DataSource = DS.Tables[2];
            R_Prefil_Cmbx.DisplayMember = "Transporter";
            R_Prefil_Cmbx.ValueMember = "Number";

            R_Frequency_Cmbx.DataSource = DS.Tables[3];
            R_Frequency_Cmbx.DisplayMember = "Frequency";
            R_Frequency_Cmbx.ValueMember = "Number";

            if (DS.Tables[4].Rows.Count > 0)
            {
                GRNNumber_Txt.Text = DS.Tables[4].Rows[0]["Number"].ToString();
                GRNMethod_Cmbx.SelectedValue = DS.Tables[4].Rows[0]["GRNMethod"].ToString();

                GV_Reset.DataSource = DS.Tables[5];
                GV_Prefix.DataSource = DS.Tables[6];
                GV_Suffix.DataSource = DS.Tables[7];

                if (DS.Tables[4].Rows[0]["GRNMethod"].ToString() == "2")
                {
                    GRNPanel.Visible = true;
                }
                else
                {
                    GRNMethod_Cmbx.SelectedValue = 3;
                    GRNMethod_Cmbx.Enabled = false;
                    GRNPanel.Enabled = false;
                }
            }
        }

        private void GRNMethod_Cmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (GRNMethod_Cmbx.SelectedValue.ToString() == "2")
            {
                GRNPanel.Visible = true;

                G_DTO.GRNOrderMethod = Convert.ToInt64(GRNMethod_Cmbx.SelectedValue);
                G_DTO.Id = 12;
                DS = G_DAO.GRNNumberDB(G_DTO);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    GRNNumber_Txt.Text = DS.Tables[0].Rows[0]["Number"].ToString();
                    GRNMethod_Cmbx.SelectedValue = DS.Tables[0].Rows[0]["GRNMethod"].ToString();

                    GV_Reset.DataSource = DS.Tables[1];
                    GV_Prefix.DataSource = DS.Tables[2];
                    GV_Suffix.DataSource = DS.Tables[3];
                }
            }
            else
            {
                GRNMethod_Cmbx.SelectedValue = 3;
                GRNPanel.Enabled = false;
            }
        }


        //GV_Reset
        private void GV_Reset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (GV_Reset.Columns[e.ColumnIndex].Name)
                {
                    case "R_Date_dt":
                        Rect = GV_Reset.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        myCal.Left = Rect.Left;
                        myCal.Top = Rect.Bottom + 5;

                        PBox.Image = Properties.Resources.calender;
                        PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        PBox.Size = new Size(25, Rect.Height);
                        PBox.Visible = true;
                        break;
                }
            }
            catch { }

            if (GV_Reset.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GV_Reset.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_Reset_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (GV_Reset.Columns[e.ColumnIndex].Name)
            {
                case "R_Date_dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GV_Reset.Rows[e.RowIndex].Cells["R_Date_dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GV_Reset.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GV_Reset.CurrentCell.Value = "";
                        MessageBox.Show("Date Correct Format");
                    }
                    break;
            }
        }
        private void PBox_Click(object sender, EventArgs e)
        {
            myCal.Visible = !myCal.Visible;
            myCal.Focus();
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            int rowIndex = GV_Reset.CurrentCell.RowIndex;
            int columnIndex = GV_Reset.CurrentCell.ColumnIndex;

            GV_Reset.Rows[rowIndex].Cells["R_Date_dt"].Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            GV_Reset.Focus();

            int columnIndexs = GV_Reset.Rows[rowIndex].Cells["R_Date_dt"].ColumnIndex + 1;
            GV_Reset.CurrentCell = GV_Reset.Rows[rowIndex].Cells[columnIndexs];

            myCal.Visible = false;
        }
        private void MonthCalendar_Leave(object sender, EventArgs e)
        {
            myCal.Visible = false;
        }
        private void GV_Reset_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        //GV_Prefix
        private void GV_Prefix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (GV_Prefix.Columns[e.ColumnIndex].Name)
                {
                    case "P_Date_dt":
                        Rect = GV_Prefix.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        P_myCal.Left = Rect.Left;
                        P_myCal.Top = Rect.Bottom + 5;

                        P_PBox.Image = Properties.Resources.calender;
                        P_PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        P_PBox.Size = new Size(25, Rect.Height);
                        P_PBox.Visible = true;
                        break;
                }
            }
            catch { }

            if (GV_Prefix.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GV_Prefix.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_Prefix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (GV_Prefix.Columns[e.ColumnIndex].Name)
            {
                case "G_Date_dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GV_Prefix.Rows[e.RowIndex].Cells["G_Date_dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GV_Prefix.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GV_Prefix.CurrentCell.Value = "";
                        MessageBox.Show("Date Correct Format");
                    }
                    break;
            }
        }
        private void G_PBox_Click(object sender, EventArgs e)
        {
            P_myCal.Visible = !P_myCal.Visible;
            P_myCal.Focus();
        }
        private void G_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            int rowIndex = GV_Prefix.CurrentCell.RowIndex;
            int columnIndex = GV_Prefix.CurrentCell.ColumnIndex;

            GV_Prefix.Rows[rowIndex].Cells["G_Date_dt"].Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            GV_Prefix.Focus();

            int columnIndexs = GV_Prefix.Rows[rowIndex].Cells["G_Date_dt"].ColumnIndex + 1;
            GV_Prefix.CurrentCell = GV_Prefix.Rows[rowIndex].Cells[columnIndexs];

            P_myCal.Visible = false;
        }
        private void G_MonthCalendar_Leave(object sender, EventArgs e)
        {
            P_myCal.Visible = false;
        }
        private void GV_Prefix_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        //GV_Suffix
        private void GV_Suffix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (GV_Suffix.Columns[e.ColumnIndex].Name)
                {
                    case "S_Date_dt":
                        Rect = GV_Suffix.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        S_myCal.Left = Rect.Left;
                        S_myCal.Top = Rect.Bottom + 5;

                        S_PBox.Image = Properties.Resources.calender;
                        S_PBox.Location = new Point(Rect.Right - 25, Rect.Y);
                        S_PBox.Size = new Size(25, Rect.Height);
                        S_PBox.Visible = true;
                        break;
                }
            }
            catch { }

            if (GV_Suffix.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    GV_Suffix.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void GV_Suffix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (GV_Suffix.Columns[e.ColumnIndex].Name)
            {
                case "S_Date_dt":
                    try
                    {
                        String Date = Convert.ToDateTime(GV_Suffix.Rows[e.RowIndex].Cells["S_Date_dt"].Value.ToString()).ToString("dd-MM-yyyy");
                        GV_Suffix.CurrentCell.Value = Date;
                    }
                    catch
                    {
                        GV_Suffix.CurrentCell.Value = "";
                        MessageBox.Show("Date Correct Format");
                    }
                    break;
            }
        }
        private void S_PBox_Click(object sender, EventArgs e)
        {
            S_myCal.Visible = !S_myCal.Visible;
            S_myCal.Focus();
        }
        private void S_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            int rowIndex = GV_Suffix.CurrentCell.RowIndex;
            int columnIndex = GV_Suffix.CurrentCell.ColumnIndex;

            GV_Suffix.Rows[rowIndex].Cells["S_Date_dt"].Value = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            GV_Suffix.Focus();

            int columnIndexs = GV_Suffix.Rows[rowIndex].Cells["S_Date_dt"].ColumnIndex + 1;
            GV_Suffix.CurrentCell = GV_Suffix.Rows[rowIndex].Cells[columnIndexs];

            S_myCal.Visible = false;
        }
        private void S_MonthCalendar_Leave(object sender, EventArgs e)
        {
            S_myCal.Visible = false;
        }
        private void GV_Suffix_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Va.RequiredFields(this) == 1)
            {
            }
            else
            {
                if (GRNMethod_Cmbx.SelectedValue.ToString() == "3")
                {
                    G_DTO.GRNOrderMethod = Convert.ToInt64(GRNMethod_Cmbx.SelectedValue);
                    G_DTO.CreatorCode = 1;
                    G_DTO.Id = 9;
                    DS = G_DAO.GRNNumberDB(G_DTO);
                    MessageBox.Show(Alert.Save());
                    OnLoad();
                }
                else if (GRNMethod_Cmbx.SelectedValue.ToString() == "2")
                {
                    var Reset = new List<String>();
                    var Prefix = new List<String>();
                    var Suffix = new List<String>();

                    Int32 Acc = 1;
                    if (Acc == 1)
                    {
                        for (int i = 0; i < GV_Reset.Rows.Count - 1; i++)
                        {
                            String Date = Convert.ToString(GV_Reset.Rows[i].Cells["R_Date_dt"].Value);
                            String StartingNumber = Convert.ToString(GV_Reset.Rows[i].Cells["R_StartingNumber_Txt"].Value);
                            String Digits = Convert.ToString(GV_Reset.Rows[i].Cells["R_Digits_Txt"].Value);
                            String Prefil = Convert.ToString(GV_Reset.Rows[i].Cells["R_Prefil_Cmbx"].Value);
                            String Frequency = Convert.ToString(GV_Reset.Rows[i].Cells["R_Frequency_Cmbx"].Value);

                            if (Date.Trim().Length < 10)
                            {
                                Acc = 0;
                                MessageBox.Show("Reset Date is Required");
                                break;
                            }
                            else if (StartingNumber.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Reset StartingNumber is Required");
                                break;
                            }
                            else if (Digits.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Reset Number of Digits is Required");
                                break;
                            }
                            else if (Prefil.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Reset Prefil Zero is Required");
                                break;
                            }
                            else if (Frequency.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Reset Frequency is Required");
                                break;
                            }

                            String Code = "";
                            if (GV_Reset.Rows[i].Cells["R_Number"].Value != null && GV_Reset.Rows[i].Cells["R_Number"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(GV_Reset.Rows[i].Cells["R_Number"].Value.ToString());
                            }
                            Reset.Add(Code);
                        }
                        for (int i = 0; i < GV_Prefix.Rows.Count - 1; i++)
                        {
                            String Date = Convert.ToString(GV_Prefix.Rows[i].Cells["G_Date_dt"].Value);
                            String Frequency = Convert.ToString(GV_Prefix.Rows[i].Cells["G_Frequency_Txt"].Value);

                            if (Date.Trim().Length < 10)
                            {
                                Acc = 0;
                                MessageBox.Show("Prefix Date is Required");
                                break;
                            }
                            else if (Frequency.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Prefix Frequency is Required");
                                break;
                            }

                            String Code = "";
                            if (GV_Prefix.Rows[i].Cells["G_Number"].Value != null && GV_Prefix.Rows[i].Cells["G_Number"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(GV_Prefix.Rows[i].Cells["G_Number"].Value.ToString());
                            }
                            Prefix.Add(Code);
                        }
                        for (int i = 0; i < GV_Suffix.Rows.Count - 1; i++)
                        {
                            String Date = Convert.ToString(GV_Suffix.Rows[i].Cells["S_Date_dt"].Value);
                            String Frequency = Convert.ToString(GV_Suffix.Rows[i].Cells["S_Frequency_Txt"].Value);

                            if (Date.Trim().Length < 10)
                            {
                                Acc = 0;
                                MessageBox.Show("Suffix Date is Required");
                                break;
                            }
                            else if (Frequency.Trim().Length < 1)
                            {
                                Acc = 0;
                                MessageBox.Show("Suffix Frequency is Required");
                                break;
                            }

                            String Code = "";
                            if (GV_Suffix.Rows[i].Cells["S_Number"].Value != null && GV_Suffix.Rows[i].Cells["S_Number"].Value != System.DBNull.Value)
                            {
                                Code = Convert.ToString(GV_Suffix.Rows[i].Cells["S_Number"].Value.ToString());
                            }
                            Suffix.Add(Code);
                        }
                        if (Acc == 1)
                        {
                            G_DTO.GRNOrderMethod = Convert.ToInt64(GRNMethod_Cmbx.SelectedValue);
                            G_DTO.CreatorCode = 1;
                            if (GRNNumber_Txt.Text == "")
                            {
                                G_DTO.Id = 2;
                            }
                            else
                            {
                                G_DTO.Number = Convert.ToInt64(GRNNumber_Txt.Text);
                                G_DTO.Id = 11;
                            }
                            DS = G_DAO.GRNNumberDB(G_DTO);

                            if (GRNNumber_Txt.Text != "")
                            {
                                G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                            }

                            G_DTO.Frequency = String.Join(",", Reset);
                            G_DTO.Id = 13;
                            G_DAO.GRNNumberDB(G_DTO);
                            for (int i = 0; i < GV_Reset.Rows.Count - 1; i++)
                            {
                                G_DTO.Date = Convert.ToInt32(Convert.ToDateTime(GV_Reset.Rows[i].Cells["R_Date_dt"].Value).ToString("yyyyMMdd"));
                                G_DTO.StartingNumber = Convert.ToInt32(GV_Reset.Rows[i].Cells["R_StartingNumber_Txt"].Value.ToString());
                                G_DTO.NumberofDigits = Convert.ToInt32(GV_Reset.Rows[i].Cells["R_Digits_Txt"].Value.ToString());
                                G_DTO.PrefilZero = Convert.ToInt32(GV_Reset.Rows[i].Cells["R_Prefil_Cmbx"].Value.ToString());
                                G_DTO.FrequencyNumber = Convert.ToInt64(GV_Reset.Rows[i].Cells["R_Frequency_Cmbx"].Value.ToString());

                                if (GRNNumber_Txt.Text == "")
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                                }
                                else
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                                }

                                if (GV_Reset.Rows[i].Cells["R_Number"].Value != null && GV_Reset.Rows[i].Cells["R_Number"].Value != System.DBNull.Value)
                                {
                                    G_DTO.Number = Convert.ToInt32(GV_Reset.Rows[i].Cells["R_Number"].Value.ToString());
                                    G_DTO.Id = 4;
                                }
                                else
                                {
                                    G_DTO.Id = 3;
                                }
                                G_DAO.GRNNumberDB(G_DTO);
                            }


                            if (GRNNumber_Txt.Text != "")
                            {
                                G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                            }
                            G_DTO.Frequency = String.Join(",", Prefix);
                            G_DTO.Id = 14;
                            G_DAO.GRNNumberDB(G_DTO);
                            for (int i = 0; i < GV_Prefix.Rows.Count - 1; i++)
                            {
                                G_DTO.Frequency = Convert.ToString(GV_Prefix.Rows[i].Cells["G_Frequency_Txt"].Value.ToString());
                                G_DTO.Date = Convert.ToInt32(Convert.ToDateTime(GV_Prefix.Rows[i].Cells["G_Date_dt"].Value).ToString("yyyyMMdd"));

                                if (GRNNumber_Txt.Text == "")
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                                }
                                else
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                                }

                                if (GV_Prefix.Rows[i].Cells["G_Number"].Value != null && GV_Prefix.Rows[i].Cells["G_Number"].Value != System.DBNull.Value)
                                {
                                    G_DTO.Number = Convert.ToInt32(GV_Prefix.Rows[i].Cells["G_Number"].Value.ToString());
                                    G_DTO.Id = 6;
                                }
                                else
                                {
                                    G_DTO.Id = 5;
                                }
                                G_DAO.GRNNumberDB(G_DTO);
                            }


                            if (GRNNumber_Txt.Text != "")
                            {
                                G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                            }
                            G_DTO.Frequency = String.Join(",", Suffix);
                            G_DTO.Id = 15;
                            G_DAO.GRNNumberDB(G_DTO);
                            for (int i = 0; i < GV_Suffix.Rows.Count - 1; i++)
                            {
                                G_DTO.Frequency = Convert.ToString(GV_Suffix.Rows[i].Cells["S_Frequency_Txt"].Value.ToString());
                                G_DTO.Date = Convert.ToInt32(Convert.ToDateTime(GV_Suffix.Rows[i].Cells["S_Date_dt"].Value).ToString("yyyyMMdd"));

                                if (GRNNumber_Txt.Text == "")
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                                }
                                else
                                {
                                    G_DTO.GRNNumber = Convert.ToInt64(GRNNumber_Txt.Text);
                                }

                                if (GV_Suffix.Rows[i].Cells["S_Number"].Value != null && GV_Suffix.Rows[i].Cells["S_Number"].Value != System.DBNull.Value)
                                {
                                    G_DTO.Number = Convert.ToInt32(GV_Suffix.Rows[i].Cells["S_Number"].Value.ToString());
                                    G_DTO.Id = 8;
                                }
                                else
                                {
                                    G_DTO.Id = 7;
                                }
                                G_DAO.GRNNumberDB(G_DTO);
                            }

                            MessageBox.Show(Alert.Save());
                        }
                    }
                    OnLoad();
                }
            }
        }
    }
}
