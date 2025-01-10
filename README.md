<h3 align="left"> 💻 Project video:</h3>

![Description of your gif](https://github.com/Abdul-Sattar-Rahimi/Pro/blob/main/ARahimi_12345.gif)


# ساختار کلی پروژه:

- پروژه بر اساس **Windows Forms** و به زبان **C#** طراحی شده است.
- تمرکز پروژه بر تعامل گرافیکی با کاربر است، از جمله تغییر تصاویر، حرکت دادن اشیاء، و منطق‌های ساده برای بازی.
- استفاده از مفاهیم پایه‌ای برنامه‌نویسی شیءگرا (**OOP**) مانند متدها، کلاس‌ها، و مدیریت رویدادها.
- امکان جابجایی بین فرم‌های مختلف (فرم اصلی، بازی‌ها و بخش‌های دیگر).

-
# طراحی با Windows Forms:

تمامی فرم‌ها به صورت گرافیکی طراحی شده‌اند تا تجربه کاربری (User Experience) خوبی ارائه دهند.
استفاده از کنترل‌های مختلفی مانند دکمه‌ها، تصاویر، و فیلدهای ورودی برای تعامل آسان کاربران با برنامه.
تمرکز بر برنامه‌نویسی شیءگرا (OOP):

برای هر بخش از پروژه از کلاس‌ها و متدهای جداگانه استفاده شده است.
مفاهیمی مانند مدیریت رویدادها (Event Handling)، ارث‌بری (Inheritance)، و کپسوله‌سازی (Encapsulation) به‌خوبی در کدنویسی رعایت شده است.
# قابلیت جابه‌جایی بین فرم‌ها:

پروژه شامل چندین فرم است (مانند فرم اصلی، فرم بازی‌ها، فرم مدیریت رمز عبور).
از متدهایی برای جابه‌جایی بین فرم‌ها به صورت پویا و آسان استفاده شده است.

# مدیر رمز عبورPassword Manager
یکی از مهم‌ترین بخش‌های پروژه، مدیریت رمز عبور (Password Manager) است. این ابزار به کاربران کمک می‌کند تا رمزهای عبور خود را به صورت امن ذخیره و مدیریت کنند. ویژگی‌های کلیدی این بخش عبارتند از:

-ذخیره‌سازی امن:

رمزهای عبور در فایل یا پایگاه داده ذخیره می‌شوند و از الگوریتم‌های رمزنگاری (Encryption) برای افزایش امنیت اطلاعات استفاده شده است.
-ایجاد رمز عبور جدید:

کاربر می‌تواند رمز عبور قوی و پیچیده‌ای را با استفاده از قابلیت تولید خودکار رمز عبور در برنامه ایجاد کند.
-امکان جستجو و مدیریت رمزهای عبور:

کاربران می‌توانند به راحتی رمز عبور حساب‌های مختلف خود را جستجو کنند یا در صورت نیاز آن‌ها را به‌روزرسانی کنند.
-رابط کاربری کاربرپسند:

تمامی عملیات مدیریت رمز عبور از طریق یک رابط کاربری ساده و کاربرپسند قابل انجام است.
-بازی‌های کوچک در پروژه:
علاوه بر بخش مدیریت رمز عبور، این پروژه شامل چند بازی کوچک است که برای سرگرمی و یادگیری مفاهیم پایه‌ای طراحی و پیاده‌سازی شده‌اند. این بازی‌ها شامل ویژگی‌های زیر هستند:

-تعامل با کاربر:
حرکات ساده مانند کلیک کردن، کشیدن و رها کردن (Drag and Drop) و تغییر وضعیت اشیاء در بازی.
-یاده‌سازی منطق بازی:
از الگوریتم‌های ساده برای منطق بازی و تعامل استفاده شده است.


<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Social Links</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      text-align: center;
      background-color: #f4f4f9;
    }
    .container {
      display: flex;
      flex-direction: column;
      align-items: center;
      gap: 15px;
      margin-top: 50px;
    }
    .link-item {
      display: flex;
      align-items: center;
      gap: 10px;
      font-size: 18px;
    }
    .link-item img {
      width: 24px;
      height: 24px;
    }
    .link-item a {
      text-decoration: none;
      color: #0078d7;
      font-weight: bold;
      transition: color 0.3s;
    }
    .link-item a:hover {
      color: #0056a3;
    }
  </style>
</head>
<body>
  <h1>Follow Us</h1>
  <div class="container">
    <!-- ChatGPT -->
    <div class="link-item">
      <img src="https://upload.wikimedia.org/wikipedia/commons/0/04/ChatGPT_logo.svg" alt="ChatGPT Logo">
      <a href="https://chat.openai.com/" target="_blank">ChatGPT</a>
    </div>
    <!-- YouTube -->
    <div class="link-item">
      <img src="https://upload.wikimedia.org/wikipedia/commons/b/b8/YouTube_Logo_2017.svg" alt="YouTube Logo">
      <a href="https://www.youtube.com/" target="_blank">YouTube</a>
    </div>
    <!-- Aparat -->
    <div class="link-item">
      <img src="https://www.aparat.com/favicon.ico" alt="Aparat Logo">
      <a href="https://www.aparat.com/" target="_blank">Aparat</a>
    </div>
  </div>
</body>
</html>



