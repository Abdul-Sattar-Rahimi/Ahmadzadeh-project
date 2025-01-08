using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Project_Mohamad_Ahmadzade
{
    public partial class Form1 : Form
    {

        //  Access تعریف یک شیء اتصال به پایگاه داده
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Login_Pro.mdb");
        // SQL تعریف یک شیء برای اجرای دستورات 
        OleDbCommand cmd = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
            // برای رمز عبور TextBox تنظیم
            TxtPassword.PasswordChar = '●';
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlRegister.Height = PnlMain.Height; // تنظیم ارتفاع پنل ثبت‌نام به ارتفاع پنل اصلی یا نمایش فرم ثبت‌نام
            PnlMain.Location = new Point(5, 5); // تغییر موقعیت پنل اصلی به سمت چپ
            Pnl.Location = new Point(385, 5); // تنظیم موقعیت فرم مربوط به نمایش
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0; // کوچک کردن ارتفاع پنل ثبت‌نام یا پنهان کردن آن
            PnlMain.Location = new Point(315, 5); // بازگرداندن پنل اصلی به مکان اولیه
            Pnl.Location = new Point(5, 5);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // بررسی کامل بودن اطلاعات
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("!لطفاً تمام اطلاعات را وارد کنید");
                    return;
                }

                // بررسی تطابق پسورد و تأیید پسورد
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("!پسورد و تأیید پسورد مطابقت ندارند");
                    return;
                }

                //  INSERT اتصال به دیتابیس و اجرای دستور
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO SignUp_Login (UserName, Email, [Password]) VALUES (@UserName, @Email, @Password)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);

                // باز کردن اتصال به پایگاه داده و اجرای دستور
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // نمایش پیام موفقیت ثبت‌نام
                MessageBox.Show("!ثبت‌نام با موفقیت انجام شد");

                // هدایت به صفحه ورود
                PnlRegister.Height = 0;  // بستن پنل ثبت‌نام
                PnlMain.Location = new Point(315, 5);
                Pnl.Location = new Point(5, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا: " + ex.Message); // نمایش پیام خطا در صورت وجود خطا در ثبت‌نام
            }
            finally
            {
                con.Close(); // اطمینان از بسته شدن اتصال به پایگاه داده
            }

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // بررسی کامل بودن اطلاعات
                if (string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show("!لطفاً نام کاربری و رمز عبور را وارد کنید");
                    return;
                }

                // SELECT  اجرای دستور Access اتصال به دیتابیس
                cmd.Connection = con;
                cmd.CommandText = "SELECT COUNT(*) FROM SignUp_Login WHERE UserName = @UserName AND [Password] = @Password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text); // نام کاربری   
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text); // رمز عبور

                // باز کردن اتصال به پایگاه داده و اجرای دستور
                con.Open();
                int count = (int)cmd.ExecuteScalar(); // تعداد کاربرانی که اطلاعات ورودشان مطابقت دارد
                con.Close();

                if (count > 0)
                {
                    // اگر کاربری پیدا شود، پیام موفقیت ورود نمایش داده می‌شود
                    MessageBox.Show("!ورود موفقیت‌آمیز بود");

                    //  MainPage هدایت به فرم
                    MainPage mainPage = new MainPage(); 
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    // اگر کاربری پیدا شود، پیام موفقیت ورود نمایش داده می‌شود
                    MessageBox.Show("!نام کاربری یا رمز عبور اشتباه است");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("خطا: " + ex.Message); // نمایش پیام خطا در صورت وجود خطا در فرایند ورود
            }
            finally
            {
                con.Close(); // اطمینان از بسته شدن اتصال به پایگاه داده
            }
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();  // خروج از برنامه

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }


     }

 }
