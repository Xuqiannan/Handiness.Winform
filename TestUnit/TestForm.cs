using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestUnit
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

        }

        private void Scutcheon1_Paint(Object sender, PaintEventArgs e)
        {
   
        }

        private void panel1_Paint(Object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(Object sender, EventArgs e)
        {
            //this.circleWaitIndicator1.IsRolled = !this.circleWaitIndicator1.IsRolled;
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void circleWaitIndicator1_Click(Object sender, EventArgs e)
        {

        }

        private void button2_Click(Object sender, EventArgs e)
        {

        }

        private void button3_Click(Object sender, EventArgs e)
        {

        }

        private void button2_DoubleClick(Object sender, EventArgs e)
        {
            this.button2.IsWaiting = !this.button2.IsWaiting;
            if (this.button2.IsWaiting)
            {
                this.button2.Text = "加载中...";
            }
            else
            {
                this.button2.Text = "完成";
            }
        }

        private void TestForm_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("fdf");
        }

        private void TestForm_DoubleClick(Object sender, EventArgs e)
        {
            MessageBox.Show("double ");
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void scutcheon3_Click(object sender, EventArgs e)
        {

        }
    }
    public interface ITest<out T> where T : class
    {
         
    }
}
