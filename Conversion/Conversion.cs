using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBinary.Text = stringToBinary(txtInput.Text);
            txtHex.Text = StringToHex(txtInput.Text);
        }

        private string StringToHex(string input)
        {
            string output = string.Empty;
            char[] value = input.ToCharArray();
            foreach(char L in value)
            {
                int v = Convert.ToInt32(L);
                output +=string.Format("{0:x}", v);

            }
            return output;

        }

        private string stringToBinary(string data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in data.ToCharArray())
                stringBuilder.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return stringBuilder.ToString();

        }
    }
}
