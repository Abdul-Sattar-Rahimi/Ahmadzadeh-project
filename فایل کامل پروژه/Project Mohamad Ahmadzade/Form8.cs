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
    public partial class Form8 : Form
    {

        private Timer timer; // تعریف یک تایمر
        private bool isPlaying = true; // متغیری برای تشخیص وضعیت پخش یا توقف

        public Form8()
        {
            InitializeComponent();

   


            // مقداردهی اولیه تایمر
            timer = new Timer();
            timer.Interval = 300; // تنظیم زمان به 300 میلی‌ثانیه یا 3 دهم ثانیه
            //  Media Player تنظیم لیست پخش اولیه برای
            InitializePlaylist();

        }

        private void InitializePlaylist()
        {
            // ایجاد یک لیست پخش جدید
            var playlist = axWindowsMediaPlayer1.newPlaylist("MyPlaylist", "");

            // اضافه کردن فایل‌ها به لیست پخش
            playlist.appendItem(axWindowsMediaPlayer1.newMedia(@"C:\Path\To\Your\File1.mp3"));
            playlist.appendItem(axWindowsMediaPlayer1.newMedia(@"C:\Path\To\Your\File2.mp4"));
            playlist.appendItem(axWindowsMediaPlayer1.newMedia(@"C:\Path\To\Your\File3.mp3"));

            // تنظیم لیست پخش برای مدیا پلیر
            axWindowsMediaPlayer1.currentPlaylist = playlist;
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // ایجاد یک دیالوگ باز کردن فایل
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // تنظیمات اولیه برای فیلتر کردن نوع فایل‌ها
            openFileDialog.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.wmv;*.avi|All Files|*.*";
            openFileDialog.Title = "انتخاب فایل رسانه‌ای";

            // اگر کاربر فایلی انتخاب کرد
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // مسیر فایل انتخابی را دریافت می‌کنیم
                string filePath = openFileDialog.FileName;

                // پخش فایل با استفاده از مدیا پلیر
                axWindowsMediaPlayer1.URL = filePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                //  Video3 توقف پخش و تغییر عکس به
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                Play.Image = Properties.Resources.Video3; //  PictureBox تغییر عکس 
                isPlaying = false; // تغییر وضعیت به متوقف
            }
            else
            {
                // Video2 شروع پخش و تغییر عکس به
                axWindowsMediaPlayer1.Ctlcontrols.play();
                Play.Image = Properties.Resources.Video2; //  PictureBox تغییر عکس  
                isPlaying = true; // تغییر وضعیت به در حال پخش
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  (Form8) بستن فرم فعلی 
            this.Close();

            //  Form2 باز کردن
            MainPage form2 = new MainPage();
            form2.Show();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                // Resources از Video7 تغییر تصویر به
                pictureBox2.Image = Properties.Resources.Video7;

                //  Video6 تایمر برای تغییر مجدد تصویر به
                Timer timer = new Timer();
                timer.Interval = 500; // نیم ثانیه
                timer.Tick += (s, args) =>
                {
                    pictureBox2.Image = Properties.Resources.Video6;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();

                // پخش ویدیو یا موزیک از ابتدا
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                // نمایش خطا
                MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayNextMedia()
        {
          
        }

       

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // Resources از Video4 تغییر تصویر به
                pictureBox3.Image = Properties.Resources.Video4;

                //  Video5 تایمر برای تغییر مجدد تصویر به
                Timer timer = new Timer();
                timer.Interval = 500; // نیم ثانیه
                timer.Tick += (s, args) =>
                {
                    pictureBox3.Image = Properties.Resources.Video5;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();

                // پخش ویدیو یا موزیک از ابتدا
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                //نمایش خطا
                MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }
}
