Bu layihə ASP.NET MVC tətbiqidir və vakansiyaların idarə olunması ilə bağlıdır.
Layihədə adminə və istifadəçilərə aid olan menyular göstərilmişdir(All Applies (Admin), Active Vacancies (Guest) şəklində.)

All Applies (Admin): Vakansiyalara müraciət edən şəxslərin məlumatları, quiz nəticələri, faiz dərəcəsi göstərilmişdir.
Active Vacancies (Admin): Admin tərəfindən əlavə edilmiş aktiv vakansiyaların siyahısı mövcuddur.
Add Vacancy (Admin): Yeni vakansiya və tələblərin əlavə olunması.
Active Vacancies (Guest): Namizədlər aktiv vakansiyalara baxıb müraciət edə bilərlər. Daha sonra əsas məlumatlarını doldurduqdan sonra quiz səhifəsinə yönləndirilir.

 Configurasiya üçün:
 -Context.cs faylında line = 60 və appsettings.json faylında lazimi database connection string vermək lazımdır.
 -Verilən connection string-dəki database name-ə uyğun bazada həmin adda database yaradılmalıdır.
 -package manager console  - update-database commandı execute edilmelidir.
 -multiple startup project seçilib, VacancyManagement.API və VacancyManagement.Web eyni anda başladılmalıdır. 

Əlavə qeyd:
- Adminin və İstifadəçinin görməli olduğu menyular ayrı olmalıdır admin panel şəklində;
- bəzi validasiyalar, imtahan suallarının admin tərəfindən idarəsi, error mesajlarının error page-də görünməsi kimi bəzi detallar vaxt məhdudiyyətinə görə əlavə edilə bilmədi.
