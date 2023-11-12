using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pact3_Ivan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetResult1_Click(object sender, EventArgs e)
        {
            ABCNumbers abcNumbers = new ABCNumbers((int)nudA.Value, (int)nudB.Value, (int)nudC.Value);
            MessageBox.Show($"Результат: {abcNumbers.GetResult()}");
        }

        private void btnGetResult2_Click(object sender, EventArgs e)
        {
            try
            {
                ABNumbers abNumbers = new ABNumbers((int)nudA2.Value, (int)nudB2.Value);
                MessageBox.Show($"Результат: {abNumbers.GetResult()}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
