using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace mail_name_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            tb.ForeColor = Color.Gray;
            tb.Text = "Введите почту..";
        }


        private void tb_Enter(object sender, EventArgs e)
        {
            if (tb.Text == "Введите почту..") {tb.ForeColor = Color.Black; tb.Text = ""; }
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            if (tb.Text == "") { tb.ForeColor = Color.Gray; tb.Text = "Введите почту.."; }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(tb.Text);

            if (match.Success)
            {
                grib.Rows.Add();
                grib.Rows[grib.Rows.Count - 2].Cells[0].Value = tb.Text;
                tb.Clear();
            }
            else { MessageBox.Show("Неверное значение"); }
        }
    }
}
