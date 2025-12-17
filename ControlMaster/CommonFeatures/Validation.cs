using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.ControlMaster.CommonFeatures
{
    public class Validation
    {
        Alerts A=new Alerts();
        public Boolean ValidDropDown(ComboBox[] ComboBox)
        {
            for (int i = 0; i < ComboBox.Length; i++)
            {
                if (ComboBox[i].SelectedIndex == -1)
                {
                    MessageBox.Show(A.Required(ComboBox[i].Tag.ToString()));
                    ComboBox[i].Focus();
                    return true;
                }
            }
            return false;
        }
        public Boolean ValidTexBox(TextBox[] TextBox)
        {
            for (int i = 0; i < TextBox.Length; i++)
            {
                if (string.IsNullOrEmpty(TextBox[i].Text.Trim()))
                {
                    MessageBox.Show(A.Required(TextBox[i].Tag.ToString()));
                    TextBox[i].Focus();
                    return true;
                }
            }
            return false;
        }

        public void AllClear(Control Parent)
        {
            Action<Control> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls.Controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = -1;
                    }
                    else
                        func(control);
            };
            func(Parent);
        }

        public int RequiredFields(Control Parent)
        {
            int a = 0;

            Action<Control> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls.Controls)
                    if (control is TextBox)
                    {
                        TextBox Txt = (TextBox)control;
                        if (string.IsNullOrWhiteSpace(Txt.Text) && Convert.ToString(Txt.Tag) != "")
                        {
                            MessageBox.Show(A.Required(Txt.Tag.ToString()));
                            Txt.Focus();
                            a = 1;
                            break;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox ComboBox = (ComboBox)control;
                        String Index = Convert.ToString(ComboBox.SelectedIndex);
                        String Tag = Convert.ToString(ComboBox.Tag);

                        if (Index == "-1" && Tag != "")
                        {
                            MessageBox.Show(A.Required(ComboBox.Tag.ToString()));
                            ComboBox.Focus();
                            a = 1;
                            break;
                        }
                    }
                    else
                        func(control);
            };
            func(Parent);
            return a;
        }
    }
}
