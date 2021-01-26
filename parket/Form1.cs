using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace parket
{/// <summary>
/// 
/// </summary>
    public partial class Form1 : Form
    {    /// <summary>
    /// 
    /// </summary>
        double a, b, dl, sh, it;
        int q, w;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudHP_ValueChanged(object sender, EventArgs e)
        {

        }
/// <summary>
/// 
/// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            
            q = (int)numericUpDown1.Value;
            w = (int)numericUpDown2.Value;
            pic1.Visible = true;
            label8.Visible = true;
            pic2.Visible = false;
            label10.Visible = false;
            label7.Visible = true;
            label9.Visible = false;
            int g = (int)nudHP.Value;
            int h = (int)nudWP.Value;
            a = q / g;
            b = w / h;
            dl = q - (g * a);
            sh = w - (h * b);
            it = a * b;
            label8.Text = "По длине ".ToString() + a.ToString() + " штуки.\r\n По ширине ".ToString() + b + " \r\n Итого ".ToString() + it + "\r\n В остатке по длине ".ToString() + dl + "\r\n В остатке по ширине ".ToString() + sh;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            q = (int)numericUpDown1.Value;
            w = (int)numericUpDown2.Value;
            pic1.Visible = false;
            pic2.Visible = true;
            label8.Visible = false;
            label10.Visible = true;
            label7.Visible = false;
            label9.Visible = true;
            int g = (int)nudHP.Value;
            int h = (int)nudWP.Value;
            a = q / h;
            b = w / g;
            dl = q - (h * a);
            sh = w - (g * b);
            it = a * b;
            label10.Text = "По длине ".ToString() + a + " штуки.\r\n По ширине ".ToString() + b + " \r\n Итого ".ToString() + it + "\r\n В остатке по длине ".ToString() + dl + "\r\n В остатке по ширине ".ToString() + sh;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
