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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();// مقداردهی اولیه کامپوننت‌های فرم

        }

        //  hand1 رویداد کلیک روی 
        private void hand1_Click(object sender, EventArgs e)
        {
            // ایجاد یک شیء Random برای تولید عدد تصادفی
            Random random = new Random();
            int index = random.Next(1, 4); // تولید عدد تصادفی بین 1 و 3

            // انتخاب عکس تصادفی از منابع
            switch (index)
            {
                case 1:
                    hand1.Image = Properties.Resources.h1;// برای حالت 1 h1 تنظیم تصویر
                    break;
                case 2:
                    hand1.Image = Properties.Resources.h2;// برای حالت 2 h2 تنظیم تصویر
                    break;
                case 3:
                    hand1.Image = Properties.Resources.h3;// برای حالت 3 h3 تنظیم تصویر
                    break;
            }

        }

        //  picturehand1 رویداد کلیک روی
        private void picturehand1_Click(object sender, EventArgs e)
        {
            hand1_Click(sender, e);// hand1 برای تنظیم تصویر تصادفی برای hand1_Click فراخوانی متد 

            SetHand2Image(Properties.Resources.ha3);// hand2 برای کنترل ha3 تنظیم تصویر


        }

        //  picturehand2 رویداد کلیک روی
        private void picturehand2_Click(object sender, EventArgs e)
        {
            hand1_Click(sender, e);// hand1 برای تنظیم تصویر تصادفی برای hand1_Click  فراخوانی متد
            SetHand2Image(Properties.Resources.ha2);// hand2 برای کنترل ha2 تنظیم تصویر

        }

        //  picturehand3 رویداد کلیک روی 
        private void picturehand3_Click(object sender, EventArgs e)
        {
            hand1_Click(sender, e);// hand1 برای تنظیم تصویر تصادفی برای hand1_Click فراخوانی متد 
            SetHand2Image(Properties.Resources.ha1);// hand2 برای کنترل ha1 تنظیم تصویر

        }

        private void hand2_Click(object sender, EventArgs e)
        {

        }

        //  hand2 متدی برای تنظیم تصویر کنترل
        private void SetHand2Image(System.Drawing.Image image)
        {
            // وجود دارد و سپس تنظیم تصویر hand2 بررسی اگر کنترل
            if (hand2 != null)
            {
                hand2.Image = image;//  hand2 اختصاص تصویر ارسال‌شده به
            }
            else
            {
                // مقداردهی نشده باشد hand2 نمایش پیام خطا اگر کنترل
                MessageBox.Show("Error: 'hand2' control is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //  (Form7) بستن فرم فعلی
            this.Close();

            //  Form2 باز کردن
            MainPage form2 = new MainPage();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
