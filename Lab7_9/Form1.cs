using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Z = new int[35];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 35; i++)
            {
                Z[i] = random.Next(-10,10);
                listBox1.Items.Add("Z[" + Convert.ToString(i + 1) + "] = " + Z[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int S = 0;
            int P = 1;
            int R = 0;
            for (int i = 0; i < 35; i++)
            {
                if ((Z[i] < 3) && (Z[i] % 2 == 0))
                {
                    S = S + Z[i];
                }
                if ((Z[i] > 1) && (Z[i] % 2 != 0))
                {
                    P = P * Z[i];
                }
            }
            R = P + S;
            listBox2.Items.Add("S = " + S.ToString());
            listBox2.Items.Add("P = " + P.ToString());
            listBox2.Items.Add("R = " + R.ToString());
        }
    }
}
