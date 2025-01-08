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
    public partial class Form7 : Form
    {


        public Form7()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // خالی است، کاری انجام نده textBox2 اگر متن داخل
            if (string.IsNullOrWhiteSpace(textBox2.Text))
                return;

            //  textBox2 دریافت متن جدید از
            string newText = textBox2.Text.Trim();

            // به رنگ آبی textBox1 و textBox3 تغییر رنگ متن در
            textBox1.ForeColor = Color.Blue;
            textBox3.ForeColor = Color.Blue;

            // با فاصله textBox1 اضافه کردن متن جدید به
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.AppendText(Environment.NewLine + Environment.NewLine);
            textBox1.AppendText(newText);

            // با فاصله textBox3 اضافه کردن متن جدید به
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
                textBox3.AppendText(Environment.NewLine + Environment.NewLine);
            textBox3.AppendText(newText);

            //  textBox2 پاک کردن
            textBox2.Clear();



        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // اگر متن داخل textBox2 خالی است، کاری انجام نده
            if (string.IsNullOrWhiteSpace(textBox4.Text))
                return;

            // دریافت متن جدید از textBox2
            string newText = textBox4.Text.Trim();

            // به رنگ قرمز textBox1 و textBox3 تغییر رنگ متن در
            textBox1.ForeColor = Color.Red;
            textBox3.ForeColor = Color.Red;

            // با فاصله textBox1 اضافه کردن متن جدید به
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.AppendText(Environment.NewLine + Environment.NewLine);
            textBox1.AppendText(newText);

            // با فاصله textBox3 اضافه کردن متن جدید به
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
                textBox3.AppendText(Environment.NewLine + Environment.NewLine);
            textBox3.AppendText(newText);

            //  textBox2 پاک کردن 
            textBox4.Clear();







        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //  (Form7) بستن فرم فعلی 
            this.Close();

            //  Form2 باز کردن 
            MainPage form2 = new MainPage();
            form2.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // نمایش دیالوگ انتخاب فایل
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // بارگذاری تصویر اصلی از مسیر انتخاب شده
                    Image originalImage = Image.FromFile(openFileDialog.FileName);

                    // ایجاد تصویر دایره‌ای از تصویر اصلی
                    Image circularImage = CreateCircularImage(originalImage);

                    // تنظیم تصویر دایره‌ای در pictureBox1
                    pictureBox1.Image = circularImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در بارگذاری تصویر: " + ex.Message);
                }
            }
        }

        // متد برای ایجاد تصویر دایره‌ای
        private Image CreateCircularImage(Image originalImage)
        {
            // اندازه تصویر نهایی دایره‌ای
            int diameter = Math.Min(originalImage.Width, originalImage.Height);

            // ایجاد یک بیت‌مپ جدید با اندازه دایره
            Bitmap circularBitmap = new Bitmap(diameter, diameter);

            using (Graphics g = Graphics.FromImage(circularBitmap))
            {
                // فعال کردن حالت‌های گرافیکی برای کیفیت بهتر
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // پس‌زمینه شفاف
                g.Clear(Color.Transparent);

                // ترسیم تصویر در داخل یک دایره
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, diameter, diameter);
                    g.SetClip(path);
                    g.DrawImage(originalImage, 0, 0, diameter, diameter);
                }
            }

            return circularBitmap;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // نمایش دیالوگ انتخاب فایل
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // بارگذاری تصویر اصلی از مسیر انتخاب شده
                    Image originalImage = Image.FromFile(openFileDialog.FileName);

                    // ایجاد تصویر دایره‌ای از تصویر اصلی
                    Image circularImage = CreateCircularImagee(originalImage);

                    // تنظیم تصویر دایره‌ای در pictureProfile
                    pictureProfile.Image = circularImage;
                    pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در بارگذاری تصویر: " + ex.Message);
                }
            }
        }

        // متد برای ایجاد تصویر دایره‌ای , همان متد قبلی
        private Image CreateCircularImagee(Image originalImage)
        {
            // اندازه تصویر نهایی دایره‌ای
            int diameter = Math.Min(originalImage.Width, originalImage.Height);

            // ایجاد یک بیت‌مپ جدید با اندازه دایره
            Bitmap circularBitmap = new Bitmap(diameter, diameter);

            using (Graphics g = Graphics.FromImage(circularBitmap))
            {
                // فعال کردن حالت‌های گرافیکی برای کیفیت بهتر
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // پس‌زمینه شفاف
                g.Clear(Color.Transparent);

                // ترسیم تصویر در داخل یک دایره
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, diameter, diameter);
                    g.SetClip(path);
                    g.DrawImage(originalImage, 0, 0, diameter, diameter);
                }
            }

            return circularBitmap;
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
