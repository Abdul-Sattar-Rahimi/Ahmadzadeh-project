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
using System.Drawing.Drawing2D;
using System.IO;


namespace Project_Mohamad_Ahmadzade
{
    public partial class MainPage : Form
    {
        // تعریف متغیری برای ذخیره نام کاربری وارد شده توسط کاربر
        private string LoggedInUserName;
        // Access رشته اتصال به دیتابیس 
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Ahmadzade pro\Project Mohamad Ahmadzade\Project Mohamad Ahmadzade\bin\Debug\PasswoedManagerAccess.mdb;";

        
        private string currentUser; // نام کاربری فعلی کاربر

        private string UserName = string.Empty; // تعریف و مقداردهی اولیه

        //Login_Pro.mdb تعریف اتصال به دیتابیس دیگر به صورت نمونه . برای دیتابیس 
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Login_Pro.mdb");
        OleDbCommand cmd = new OleDbCommand();


        // متغیری برای بررسی وضعیت نمایش یا عدم نمایش رمز عبور
        private bool isPasswordVisible = false;

        public event Action<Image> PictureChanged; // رویداد تغییر تصویر


        //  MainPage سازنده فرم

        public MainPage()
        {

            InitializeComponent();

            
            currentUser = UserName ?? string.Empty; // تخصیص مقدار
            TxtName.Text = "Telegram, Instagram...";
            TxtName.ForeColor = Color.LightGray;

            // اتصال رویدادها
            TxtName.Enter += TxtName_Enter;
            TxtName.Leave += TxtName_Leave;
            // نام کاربری که از فرم لاگین دریافت می‌شود


            // TxtName تنظیم متن پیش‌فرض برای
            TxtName.Text = "Telegram, Instagram...";
            TxtName.ForeColor = Color.LightGray;
            // اتصال رویدادها
            TxtName.Enter += TxtName_Enter;
            TxtName.Leave += TxtName_Leave;


            // TxtUser تنظیم متن پیش‌فرض برای
            TxtUser.Text = "Satar1381, Ali2025...";
            TxtUser.ForeColor = Color.LightGray;
            // اتصال رویدادها
            TxtUser.Enter += TxtUser_Enter;
            TxtUser.Leave += TxtUser_Leave;



            // TxtPassword تنظیم متن پیش‌فرض برای
            txtPassword.Text = "123...";
            txtPassword.ForeColor = Color.LightGray;
            // اتصال رویدادها
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;



            // TxtURI تنظیم متن پیش‌فرض برای 
            txtURI.Text = "ex. https://google.com";
            txtURI.ForeColor = Color.LightGray;
            // اتصال رویدادها
            txtURI.Enter += txtURI_Enter;
            txtURI.Leave += txtURI_Leave;




            // ● تنظیم کاراکتر پیش‌فرض برای رمز عبور به کاراکتر 
            txtPassword.PasswordChar = '●';
            //  PictureBox اتصال رویداد کلیک به 
            pictureEye.Click += pictureBox3_Click;


            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        // متد کلیک دکمه ورود . دکمه‌ای برای تغییر نمای فرم یا تغییر مکان فرم
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            txtPManager.Height = panel1.Height;
            txtPManager.Location = new Point(0, 0);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PnlPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PnlUserName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {


        }

        


        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (TxtName.Text == "Telegram, Instagram...")
            {
                TxtName.Text = ""; // پاک کردن متن پیش‌فرض
                TxtName.ForeColor = Color.DodgerBlue; //  DodgerBlue تغییر رنگ متن به
            }
        }

        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.Text = "Telegram, Instagram..."; // بازگرداندن متن پیش‌فرض
                TxtName.ForeColor = Color.LightGray; //  Gray تغییر رنگ متن به
            }
        }






        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Satar1381, Ali2025...")
            {
                TxtUser.Text = ""; // پاک کردن متن پیش‌فرض
                TxtUser.ForeColor = Color.DodgerBlue; //  DodgerBlue تغییر رنگ متن به      
            }
        }

        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUser.Text))
            {
                TxtUser.Text = "Satar1381, Ali2025..."; // بازگرداندن متن پیش‌فرض
                TxtUser.ForeColor = Color.LightGray; //  Gray تغییر رنگ متن به
            }
        }






        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123...")
            {
                txtPassword.Text = ""; // پاک کردن متن پیش‌فرض
                txtPassword.ForeColor = Color.DodgerBlue; //  DodgerBlue تغییر رنگ متن به
            }
        }

        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "123..."; // بازگرداندن متن پیش‌فرض
                txtPassword.ForeColor = Color.LightGray; //  Gray تغییر رنگ متن به
            }
        }






        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void txtURI_Enter(object sender, EventArgs e)
        {
            if (txtURI.Text == "ex. https://google.com")
            {
                txtURI.Text = ""; // پاک کردن متن پیش‌فرض
                txtURI.ForeColor = Color.DodgerBlue; //  DodgerBlue تغییر رنگ متن به
            }
        }

        // متن نمایشی هر قسمت به صورت زیر کدنویسی کردم
        private void txtURI_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURI.Text))
            {
                txtURI.Text = "ex. https://google.com"; // بازگرداندن متن پیش‌فرض
                txtURI.ForeColor = Color.LightGray; // Gray تغییر رنگ متن به 
            }
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (isPasswordVisible)
            {
                // اگر حالت نمایان است، به حالت مخفی تغییر می‌دهیم
                txtPassword.PasswordChar = '●'; // ● نمایش رمز به صورت 
                pictureEye.Image = Properties.Resources.eye2; //  یا چشم بسته eye1 تغییر تصویر به
                isPasswordVisible = false; // وضعیت به false تغییر می‌یابد
            }
            else
            {
                // اگر حالت مخفی است، به حالت نمایان تغییر می‌دهیم
                txtPassword.PasswordChar = '\0'; // نمایش رمز به صورت متن معمولی
                pictureEye.Image = Properties.Resources.eye1; // یا چشم باز eye2 تغییر تصویر به
                isPasswordVisible = true; // تغییر میابد true وضعیت به
            }

            //  PasswordChar دیباگ مقدار
            MessageBox.Show($"Password : {(txtPassword.PasswordChar == '●' ? "رمز مخفی شد" : "شما میتوانید رمز خود را ببینید.برای پنهان کردن مجدد ،تایید کنید")}");

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {



        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            {

                // خالی نباشد TextBox بررسی می‌کنیم که مقدار
                if (!string.IsNullOrWhiteSpace(TxtUser.Text))
                {



                    // را در کلیپ‌بورد کپی می‌کنیم txtUser مقدار موجود در
                    Clipboard.SetText(TxtUser.Text);


                    Clipboard.SetText(TxtUser.Text);
                    // پیامی نمایش می‌دهیم تا کاربر متوجه شود مقدار کپی شده است
                    MessageBox.Show("!متن با موفقیت کپی شد", "کپی متن", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // خالی باشد، پیام هشدار نمایش می‌دهیم TextBox اگر
                    MessageBox.Show("!لطفاً متنی وارد کنید تا کپی شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // خالی نباشد TextBox بررسی می‌کنیم که مقدار
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {



                // را در کلیپ‌بورد کپی می‌کنیم txtPassword مقدار موجود در
                Clipboard.SetText(txtPassword.Text);


                Clipboard.SetText(txtPassword.Text);
                // پیامی نمایش می‌دهیم تا کاربر متوجه شود مقدار کپی شده است
                MessageBox.Show("!متن با موفقیت کپی شد", "کپی متن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // خالی باشد، پیام هشدار نمایش می‌دهیم TextBox اگر
                MessageBox.Show("!لطفاً متنی وارد کنید تا کپی شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // خالی نباشد TextBox بررسی می‌کنیم که مقدار
            if (!string.IsNullOrWhiteSpace(txtURI.Text))
            {



                // را در کلیپ‌بورد کپی می‌کنیم txtURI مقدار موجود در
                Clipboard.SetText(txtURI.Text);


                Clipboard.SetText(txtURI.Text);
                // پیامی نمایش می‌دهیم تا کاربر متوجه شود مقدار کپی شده است
                MessageBox.Show("!متن با موفقیت کپی شد", "کپی متن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // خالی باشد، پیام هشدار نمایش می‌دهیم TextBox اگر
                MessageBox.Show("!لطفاً متنی وارد کنید تا کپی شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPManager_Paint(object sender, PaintEventArgs e)
        {
            txtPManager.Dock = DockStyle.Bottom;
            txtPManager.BringToFront(); // همیشه در جلو باشد


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtPManager.Height = 0;
            txtPManager.Location = new Point(0, 602);
            panel1.Location = new Point(304, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // اتصال به دیتابیس
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // دستور SQL برای افزودن اطلاعات به جدول
                    string query = "INSERT INTO TBLUser ([Name], [UserName], [Password], [URI1]) VALUES (@Name, @UserName, @Password, @URI1)";


                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // افزودن پارامترها
                        command.Parameters.AddWithValue("@Name", TxtName.Text);
                        command.Parameters.AddWithValue("@UserName", TxtUser.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@URI1", txtURI.Text);

                        // اجرای دستور
                        command.ExecuteNonQuery();
                    }

                    // بروز رسانی DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ذخیره اطلاعات: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                // اتصال به دیتابیس
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // دستور SQL برای دریافت اطلاعات
                    string query = "SELECT * FROM TBLUser";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // تنظیم DataGridView
                        dgvUser.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری اطلاعات: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // بارگذاری داده‌ها در DataGridView هنگام باز شدن فرم
            LoadData();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            try
            {
                // اتصال به دیتابیس
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // برای به‌روزرسانی اطلاعات در جدول SQL دستور
                    string query = "UPDATE TBLUser SET [Name] = @Name, [Password] = @Password, [URI1] = @URI1 WHERE [UserName] = @UserName";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // مقداردهی به پارامترها
                        command.Parameters.AddWithValue("@Name", TxtName.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@URI1", txtURI.Text);
                        command.Parameters.AddWithValue("@UserName", TxtUser.Text); // UserName بر اساس WHERE شرط

                        // اجرای دستور
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("!اطلاعات با موفقیت به‌روزرسانی شد");
                            LoadData(); //  DataGridView به‌روزرسانی
                        }
                        else
                        {
                            MessageBox.Show(".اطلاعاتی برای به‌روزرسانی یافت نشد");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در به‌روزرسانی اطلاعات: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // خالی نباشد UserName بررسی اینکه فیلد
                if (string.IsNullOrEmpty(TxtUser.Text))
                {
                    MessageBox.Show(".مدنظر خود را وارد کنید UserName لطفاً");
                    return;
                }

                // اتصال به دیتابیس
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // برای حذف رکورد SQL دستور
                    string deleteQuery = "DELETE FROM TBLUser WHERE [UserName] = @UserName";
                    using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@UserName", TxtUser.Text);

                        //  DELETE اجرای دستور
                        int rowsDeleted = deleteCommand.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("!اطلاعات با موفقیت حذف شد");

                            // پاک کردن فیلدها در فرم
                            TxtName.Text = "";
                            TxtUser.Text = "";
                            txtPassword.Text = "";
                            txtURI.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("یافت نشد UserName هیچ کاربری با این");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف اطلاعات: " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {

        }


        

        private void txtProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // بارگذاری تصویر اصلی
                Image originalImage = Image.FromFile(openFileDialog.FileName);

                // ایجاد تصویر دایره‌ای
                Image circularImage = CreateCircularImage(originalImage);

                //  pictureProfile تنظیم تصویر دایره‌ای در
                pictureProfile.Image = circularImage;
                pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;


                
                
            }
        }

        private Image CreateCircularImage(Image originalImage)
        {
            //  pictureProfile اندازه مورد نیاز برای دایره‌ای کردن تصویر براساس اندازه کنترل
            int diameter = Math.Min(pictureProfile.Width, pictureProfile.Height);
            Bitmap circularBitmap = new Bitmap(diameter, diameter);

            using (Graphics graphics = Graphics.FromImage(circularBitmap))
            {
                // ایجاد قلموهای کیفیت بالا
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // ساختن ماسک دایره‌ای
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, diameter, diameter);
                    graphics.SetClip(path);
                    graphics.DrawImage(originalImage, 0, 0, diameter, diameter);
                }
            }
            return circularBitmap;
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGame_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
    }
       
}
