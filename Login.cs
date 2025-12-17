using ERP.Purchase;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SiteMaster SM=new SiteMaster();
            SM.Show();
        }
    }
}
