using ERP.ControlMaster.Theme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.ControlMaster.CommonFeatures
{
    public class Events
    {
        ThemeColor Theme = new ThemeColor();
        public void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.BackColor = Theme.Dark();
            textBox.ForeColor = Theme.White();
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
        }

        public void Textbox_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.BackColor = Theme.White();
            textBox.ForeColor = Theme.Dark();
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            textBox.Text = textBox.Text.TrimEnd();

            if (string.IsNullOrWhiteSpace(textBox.Text) && Convert.ToString(textBox.Tag) != "")
            {
                textBox.Focus();
            }
        }

        public void ComboBox_Enter(object sender, EventArgs e)
        {
            var Com = (ComboBox)sender;
            Com.BackColor = Theme.Dark();
            Com.ForeColor = Theme.White();
            Com.Font = new Font(Com.Font, FontStyle.Bold);
        }
        public void ComboBox_Leave(object sender, EventArgs e)
        {
            var Com = (ComboBox)sender;
            Com.BackColor = Theme.White();
            Com.ForeColor = Theme.Dark();
            Com.Font = new Font(Com.Font, FontStyle.Regular);

            String Index = Convert.ToString(Com.SelectedIndex);
            String Tag = Convert.ToString(Com.Tag);

            if (Index == "-1" && Tag != "")
            {
                Com.Focus();
            }
        }

        public void TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.Text = textBox.Text.TrimStart();
            textBox.Text = textBox.Text.Replace("  ", " ");
            textBox.SelectionStart = textBox.TextLength;


            var cursorPosition = textBox.SelectionStart;

            if (textBox.Name.Contains("Char"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, "[^a-zA-Z]", "");
                textBox.SelectionStart = cursorPosition;
            }
            else if (textBox.Name.Contains("Digit"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, "[^0-9]", "");
                textBox.SelectionStart = cursorPosition;
            }
            else if (textBox.Name.Contains("Decimal"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, "[^0-9.]", "");
                textBox.SelectionStart = cursorPosition;
            }
            else if (textBox.Name.Contains("AlphaNum"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, "[^0-9a-zA-Z]", "");
                textBox.SelectionStart = cursorPosition;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private const string Special = @"~`!@#$%^*()+={}[]|'<>?";
        public void SpecialKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            e.Handled = Special.Contains(e.KeyChar);
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void FormController(Control Parent)
        {
            foreach (Control Con in Parent.Controls)
            {
                if (Con.GetType() == typeof(TextBox))
                {
                    TextBox Txt = (TextBox)Con;
                    Txt.TextChanged += TextChanged;
                    Txt.Enter += TextBox_Enter;
                    Txt.Leave += Textbox_Leave;
                    Txt.KeyDown += KeyDown;

                    if (Txt.Name.Contains("Special"))
                    {
                        Txt.KeyPress += SpecialKeyPressEvent;
                    }
                }
                else if (Con.GetType() == typeof(ComboBox))
                {
                    ComboBox Com = (ComboBox)Con;
                    Com.Enter += ComboBox_Enter;
                    Com.Leave += ComboBox_Leave;
                }
                else if (Con.GetType() == typeof(Button))
                {
                    Button Button = (Button)Con;
                    if (Button.Text == "Clear")
                    {
                        //Button.FlatStyle = FlatStyle.System;
                        ////Button.FlatAppearance.BorderSize = 0;
                        //Button.BackColor = Theme.Primary();
                        //Button.ForeColor = Theme.White();
                        //Button.Height = 35;
                        ////Button.Width = 70;
                        //Button.Padding = new Padding(0);
                        //Button.Margin = new Padding(0);
                    }
                    else
                    {
                        //Button.FlatStyle = FlatStyle.Standard;
                        ////Button.FlatAppearance.BorderSize = 0;
                        //Button.BackColor = Theme.Success();
                        //Button.ForeColor = Theme.White();
                        //Button.Height = 35;
                        ////Button.Width = 70;
                        //Button.Padding = new Padding(0);
                        //Button.Margin=new Padding(0);   
                    }
                }
                else
                {
                    FormController(Con);
                }
            }
        }
    }
}
