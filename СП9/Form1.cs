using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace СП9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var screen in Screen.AllScreens)
            {
                listBox1.Items.Add("Имя устройства: " + screen.DeviceName);
                listBox1.Items.Add("Границы: " + screen.Bounds.ToString());
                listBox1.Items.Add("Тип: " + screen.GetType().ToString());
                listBox1.Items.Add("Рабочая область: " + screen.WorkingArea.ToString());
                listBox1.Items.Add("Главный экран: " + screen.Primary.ToString());
            }
        }
    }
}
