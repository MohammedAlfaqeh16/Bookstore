# Bookstore

أداة بسيطة وغنية لبناء موقع بيع الكتب باستخدام **ASP.NET Core**.

##  وصف المشروع
هذا المشروع عبارة عن متجر كتب إلكتروني بني باستخدام أساسيات **ASP.NET Core**، ويهدف إلى تقديم نموذج عملي لطريقة بناء موقع لعرض الكتب وإدارتها (إضافة، تعديل، حذف، إلخ).

##  المميزات
- استخدام إطار **ASP.NET Core**.
- فصل هيكل المشروع إلى طبقات:
  - Controllers
  - Models
  - Views
  - ViewModels
  - Repository للاتصال بالبيانات
- وجود دعم لـ **Migrations** لتهيئة قواعد البيانات.
- ملفات إعدادات (مثل `appsettings.json` و `appsettings.Development.json`).
- بنية منظمة تدعم التوسع والتطوير مستقبلًا.

##  البدء السريع (Getting Started)
### المتطلبات
- .NET SDK (نسخة مناسبة مع المشروع)
- بيئة تطوير مثل Visual Studio أو VS Code

### خطوات التشغيل
1. استنِسخ المستودع:
   ```bash
   git clone https://github.com/MohammedAlfaqeh16/Bookstore.git

2.# Bookstore

أداة بسيطة وغنية لبناء موقع بيع الكتب باستخدام **ASP.NET Core**.

##  وصف المشروع
هذا المشروع عبارة عن متجر كتب إلكتروني بني باستخدام أساسيات **ASP.NET Core**، ويهدف إلى تقديم نموذج عملي لطريقة بناء موقع لعرض الكتب وإدارتها (إضافة، تعديل، حذف، إلخ).

##  المميزات
- استخدام إطار **ASP.NET Core**.
- فصل هيكل المشروع إلى طبقات:
  - Controllers
  - Models
  - Views
  - ViewModels
  - Repository للاتصال بالبيانات
- وجود دعم لـ **Migrations** لتهيئة قواعد البيانات.
- ملفات إعدادات (مثل `appsettings.json` و `appsettings.Development.json`).
- بنية منظمة تدعم التوسع والتطوير مستقبلًا.

##  البدء السريع (Getting Started)
### المتطلبات
- .NET SDK (نسخة مناسبة مع المشروع)
- بيئة تطوير مثل Visual Studio أو VS Code

### خطوات التشغيل
1. استنِسخ المستودع:
   ```bash
   git clone https://github.com/MohammedAlfaqeh16/Bookstore.git
2.# Bookstore

أداة بسيطة وغنية لبناء موقع بيع الكتب باستخدام **ASP.NET Core**.

##  وصف المشروع
هذا المشروع عبارة عن متجر كتب إلكتروني بني باستخدام أساسيات **ASP.NET Core**، ويهدف إلى تقديم نموذج عملي لطريقة بناء موقع لعرض الكتب وإدارتها (إضافة، تعديل، حذف، إلخ).

##  المميزات
- استخدام إطار **ASP.NET Core**.
- فصل هيكل المشروع إلى طبقات:
  - Controllers
  - Models
  - Views
  - ViewModels
  - Repository للاتصال بالبيانات
- وجود دعم لـ **Migrations** لتهيئة قواعد البيانات.
- ملفات إعدادات (مثل `appsettings.json` و `appsettings.Development.json`).
- بنية منظمة تدعم التوسع والتطوير مستقبلًا.

##  البدء السريع (Getting Started)
### المتطلبات
- .NET SDK (نسخة مناسبة مع المشروع)
- بيئة تطوير مثل Visual Studio أو VS Code

### خطوات التشغيل
1. استنِسخ المستودع:
   ```bash
   git clone https://github.com/MohammedAlfaqeh16/Bookstore.git
2.ادخل على المجلد:
cd Bookstore

3.شغّل الميجريشنز (إن وجدت) لإنشاء قاعدة البيانات:
dotnet ef database update
4.شغّل المشروع:
dotnet run

5.افتح المتصفح وزُر العنوان:
https://localhost:5001


###هيكلية المشروع (Project Structure)
Bookstore/
├── Controllers/       # منطق التحكم واستقبال الطلبات
├── Models/            # نماذج البيانات
├── viewModel/         # ViewModels لتجهيز البيانات للعرض
├── Views/             # صفحات Razor أو ملفات العرض
├── Repository/        # الطبقة المشتركة للوصول للبيانات
├── Migrations/        # ترحيلات إنشاء وتحديث قاعدة البيانات
├── wwwroot/           # الملفات الثابتة (CSS, JS, images)
├── appsettings.json   # إعدادات التطبيق الأساسية
├── appsettings.Development.json  # إعدادات التطوير
├── Program.cs         # نقطة البداية للتطبيق
├── Bookstore.csproj   # ملف المشروع
└── Bookstore.sln      # ملف الحل (Solution)



تحسينات مستقبلية (Future Enhancements)

إضافة نظام تسجيل دخول ومستخدمين.

دعم عمليات الدفع الإلكتروني.

نظام إدارة مخزون متقدم.

لوحة تحكم للإدارة (Admin Dashboard).

تصميم responsive وتحسين UI/UX.

المساهمة (Contributing)

المساهمات موضع ترحيب! إذا كنت ترغب بإضافة ميزة أو تعديل:

أنشئ فرعًا جديدًا.

أضف تغييراتك مع وصف واضح.

أرسل Pull Request للمراجعة.

الترخيص (License)

ما لم يُذكر خلاف ذلك، هذا المشروع مفتوح المصدر ويخضع لـ MIT License (أو أي ترخيص تختاره).

المؤلف

محمد الفقيه (Mohammed Alfaqeh)
للتواصل أو الاستفسار، يمكنك فتح Issue أو مراسلتي مباشرة على GitHub.
