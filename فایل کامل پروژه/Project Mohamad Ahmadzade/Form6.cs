using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mohamad_Ahmadzade
{
    public partial class Form6 : Form
    {
        List<ListFile> listFiles = new List<ListFile>();

        int pictureNumber = 1; // متغیری برای ذخیره شماره تصویر فعلی
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

       

      

        private void pictureViewer_Click(object sender, EventArgs e)
        {

        }

        private void lblinfo_Click(object sender, EventArgs e)
        {

        }

        // رویداد کلیک روی دکمه GoBack رویداد کلیک روی دکمه
        private void GoBack_Click(object sender, EventArgs e)
        {
            pictureNumber -= 1; // شماره تصویر را یکی کم می‌کند

            if (pictureNumber < 1) // اگر شماره تصویر کمتر از 1 شد
            {
                pictureNumber = 16; // آن را به 16 (آخرین تصویر) تغییر می‌دهد
            }

            ChangePictures(pictureNumber);
        }

        // تغییر تصویر بر اساس شماره تصویر
        private void ChangePictures(int picNum)
        {

            switch (picNum)
            {
                case 1:
                    pictureViewer.Image = Properties.Resources._01;// تنظیم تصویر  شماره 1
                    lblinfo.Text = "باغ سرسبز شازده ماهان در دل کویر از زیباترین جاهای دیدنی کرمان و یکی از ۹ باغ ایرانی و مشهور جهان است";// تنظیم توضیحات برای شماره 1   
                    break;
                case 2:
                    pictureViewer.Image = Properties.Resources._02;
                    lblinfo.Text = "گنبد سلطانیه یکی از شاهکار های معماری ایران در دوره ایلخانی است";
                    break;
                case 3:
                    pictureViewer.Image = Properties.Resources._03;
                    lblinfo.Text = "کاخ کَلستان با معماری و تزیینات منحصر به فرد و محلی مناسب برای عکاسی و ثبت تصاویر فوق العاده زیبا در بافت قدیمی شهر تهران است";
                    break;
                case 4:
                    pictureViewer.Image = Properties.Resources._04;
                    lblinfo.Text = "فیروزآباد یکی از شهرهای باستانی و بسیار کهن ایران با قدمتی از دوره ساسانیان است که با نام های شهر کَور یااردشیرخوره نیز شناختخه می شود";
                    break;
                case 5:
                    pictureViewer.Image = Properties.Resources._05;
                    lblinfo.Text = "تخت جمشید نمادی از شکوه و عظمت در ایران باستان یکی از مهم ترین اسناد تاریخ تمدن در جهان و یادکَاری از پادشاهان هخامنشی است";
                    break;
                case 6:
                    pictureViewer.Image = Properties.Resources._06;
                    lblinfo.Text = "برج یا میل کَنبد قاووس بلندترین برج تمام آجری جهان و جزو ابنیه تاریخی مربوط به سده چهارم هجری است";
                    break;
                case 7:
                    pictureViewer.Image = Properties.Resources._07;
                    lblinfo.Text = "چغازنبیل اولین اثر تارزیخی ایران است که در فهرست میراث جهانی یونسکو به ثبت رسده است";
                    break;
                case 8:
                    pictureViewer.Image = Properties.Resources._08;
                    lblinfo.Text = "مجموعه خانقاه و بقعه شیخ صفی الدین اردبیلی نمونه ای شاهکار از هنر و معماری ایرانی به شمار می رود که محل دفن شیخ صفی شاه اسماعیل و تعدادی از صاحب منصبان دوره صفوی است";
                    break;
                case 9:
                    pictureViewer.Image = Properties.Resources._09;
                    lblinfo.Text = "مجموعه تاریخی و صنعتی و اقتصادی آسیاب های آبی شوش در مجاورت بافت تاریخی شوشتر قرار دارد";
                    break;
                case 10:
                    pictureViewer.Image = Properties.Resources._10;
                    lblinfo.Text = "اورامانات نام منطقه ای در بخش اورامان شهرستان سروآباد در غرب استان کردستان است و جاده ای به طول ۷۵ کیلومتر آن را به مروان وصل می کند";
                    break;
                case 11:
                    pictureViewer.Image = Properties.Resources._11;
                    lblinfo.Text = "میدان نقش جهان یا میدان امام از زیبا ترین جاهای دیدنی اصفهان با طول بیش از ۵۰۰ متر و عرض ۱۶۰ متر است";
                    break;
                case 12:
                    pictureViewer.Image = Properties.Resources._12;
                    lblinfo.Text = "قدیمی ترین بنای تاریخی اصفهان مسجد جامع یا مسجد جمعه است که چهره امروزی آن مربوط به اقدامات دوره سلجوقی می باشد";
                    break;
                case 13:
                    pictureViewer.Image = Properties.Resources._13;
                    lblinfo.Text = " مجموعه بیستون با وسعت ۱.۶۵۰ هستار دارای تعداد زیادی آثار تاریخی مانند نقش برجسته مهرداد اشکانی است که در فهرست میراث جهانی یونسکو قرار دارد";
                    break;
                case 14:
                    pictureViewer.Image = Properties.Resources._14;
                    lblinfo.Text = "روستای میمند کرمان به دلیل داشتن معماری صخره ای و شکَفت انکَیز مشهور است.معماری آن بکَونه ای است که مانند یک عایق حرارتی عمل میکند و باد و باران به داخل آن نفوذ نمی کند";
                    break;
                case 15:
                    pictureViewer.Image = Properties.Resources._15;
                    lblinfo.Text = "ارکَ بم یکی از معروف ترین جاذبه های استان کرمان است که در جنوب شرقی حاشیه کویر لوت قرار دارد";
                    break;
                case 16:
                    pictureViewer.Image = Properties.Resources._16;
                    lblinfo.Text = "ساخت بنای مجموعه باستانی پاسارکَارد شیراز از دوره حکومت کورش هخامنشی آغاز و در دوره های شاهان دیکَر این سلسله با افزودن کاخ ها و بماهای دیکَر تکمیل شده است";
                    break;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // بستن فرم فعلی (Form7)
            this.Close();

            // باز کردن Form2
            MainPage form2 = new MainPage();
            form2.Show();
        }

        // برای نمایش تصویر بعدی GoNext رویداد کلیک روی دکمه
        private void GoNext_Click_1(object sender, EventArgs e)
        {
            pictureNumber += 1; // شماره تصویر را یکی زیاد می‌کند

            if (pictureNumber > 16) // اگر شماره تصویر بیشتر از 5 شد
            {
                pictureNumber = 1; // آن را به 1 تغییر می‌دهد
            }

            ChangePictures(pictureNumber); // تغییر تصویر بر اساس شماره تصویر
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // خروج از برنامه
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Height = panel1.Height; // قرار می‌دهد (panel1) را برابر با ارتفاع پنل (txtSearch) ارتفاع کادر جستجو
            txtSearch.Location = new Point(0, 0); // موقعیت کادر جستجو را به گوشه بالا و سمت چپ (0,0) منتقل می‌کند
        }


        // کلیک شود pictureBox6 زمانی که روی
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtSearch.Height = 0;// ارتفاع کادر جستجو را صفر می‌کند تا از دید کاربر پنهان شود
            txtSearch.Location = new Point(0, 602); // مکان کادر جستجو را به پایین صفحه (در مختصات 602) منتقل می‌کند
            panel1.Location = new Point(304, 0); // مکان پنل (304, 0) تغییر می‌دهد (panel1) مکان پنل
        }

        

        private void txtSearch_Paint(object sender, PaintEventArgs e)
        {
            LoadFiles();
        }


        // متدی که فایل‌ها و دایرکتوری‌ها را بارگذاری می‌کند
        void LoadFiles()
        {
            // را با استفاده از جستجوی همه‌جانبه پیدا می‌کند (Pictures) همه دایرکتوری‌ها در مسیر مشخص
            var directories = Directory.GetDirectories(@"C:\Users\kaleng\Pictures", "*.*", SearchOption.AllDirectories);


            // برای هر دایرکتوری پیدا شده
            foreach (var d in directories)
            {
                var directory = new DirectoryInfo(d); // اطلاعات دایرکتوری را به دست می‌آورد

                var files = directory.GetFiles(); // فایل‌های موجود در دایرکتوری را دریافت می‌کند


                // برای هر فایل موجود در لیست فایل‌ها
                foreach (var file in files)
                {
                    // ضافه می‌کند listFiles فایل را به لیستی به نام
                    listFiles.Add(new ListFile { Name = file.Name, Path = file.FullName });
                }
            }


            // نمایش می‌دهد DataGridView را در listFiles فایل‌های موجود در
            foreach (var file in listFiles)
            {
                g.Rows.Add(file.Name, file.Path);
            }
        }

        private void g_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
