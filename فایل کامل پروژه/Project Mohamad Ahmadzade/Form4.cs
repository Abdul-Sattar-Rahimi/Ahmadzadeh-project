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
    public partial class Form4 : Form
    {
        private int score = 0;// متغیر برای ذخیره امتیاز که در اینجا استفاده نشده است

        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);// به فرم KeyDown اضافه کردن رویداد

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // pictureBox1 بررسی کلید فشرده‌شده و حرکت دادن 
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pictureBox1.Top -= 5; // حرکت به بالا
                    break;
                case Keys.Down:
                    pictureBox1.Top += 5; // حرکت به پایین
                    break;
                case Keys.Left:
                    pictureBox1.Left -= 5; // حرکت به چپ
                    break;
                case Keys.Right:
                    pictureBox1.Left += 5; // حرکت به راست
                    break;


            }

            // pictureBox2 با pictureBox1 بررسی برخورد
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("You won!"); // نمایش پیام پیروزی

                //  PictureBox بازنشانی موقعیت اولیه هر دو
                pictureBox1.Location = new Point(116, 116);
                pictureBox2.Location = new Point(336, 42);
            }

            // اگر فاصله بین دکمتر از 100 پیکسل باشد PictureBox اگر فاصله بین دو
            if (Math.Abs(pictureBox1.Location.X - pictureBox2.Location.X) < 100 &&
        Math.Abs(pictureBox1.Location.Y - pictureBox2.Location.Y) < 100)
            {
                Random rand = new Random();//  Random ایجاد شیء     
                int newX = rand.Next(0, this.ClientSize.Width - pictureBox2.Width);// جدید X مقدار
                int newY = rand.Next(0, this.ClientSize.Height - pictureBox2.Height);// جدید Y مقدار
                pictureBox2.Location = new Point(newX, newY);//  pictureBox2 تنظیم موقعیت جدید برای  
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // pictureBox1 به جایی نزدیک pictureBox2 تغییر موقعیت
            pictureBox2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 10, pictureBox1.Location.Y);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //  (Form7) بستن فرم فعلی
            this.Close();

            //  Form2 باز کردن   
            MainPage form2 = new MainPage();
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
