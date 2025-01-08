using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mohamad_Ahmadzade
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // بستن فرم فعلی (Form5)
            this.Close();

            // باز کردن Form2
            MainPage form2 = new MainPage();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
