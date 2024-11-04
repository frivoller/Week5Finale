# Araba Fabrikası Konsol Uygulaması
Bu proje, bir araba fabrikasında üretilen arabaları konsol ekranı üzerinden yönetmek için geliştirilmiştir. Kullanıcıya araba üretmek isteyip istemediği sorulur, eğer isterse araba bilgilerini girerek yeni bir araba oluşturur ve oluşan arabalar bir listede saklanır.

## Özellikler
- Araba sınıfı, Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı gibi özelliklere sahiptir.
- Üretim Tarihi, araba oluşturulduğunda otomatik olarak atanır.
- Kullanıcı, sınırsız sayıda araba oluşturabilir.
- Kullanıcı geçersiz giriş yaparsa uyarı mesajı verilir ve yeniden giriş yapması istenir.
- Program sonunda üretilen tüm arabaların Seri Numarası ve Markası listelenir.

## Kullanım
Program çalıştırıldığında, araba üretmek isteyip istemediğiniz sorulacaktır.
e veya E: Evet, araba üret.
h veya H: Hayır, programı sonlandır.
Eğer araba üretmek isterseniz, sırasıyla araba özelliklerini girin:
Seri Numarası, Marka, Model, Renk
Kapı Sayısı: Sayısal bir değer girilmelidir.
Başka bir araba üretmek istenirse, aynı adımlar tekrarlanabilir.
Programı sonlandırmak için h veya H yanıtını verin.
Tüm üretilen arabalar, seri numaraları ve markaları ile birlikte ekrana yazdırılacaktır.

----

# Car Factory Console Application
This project is developed to manage cars produced in a car factory through a console application. The user is asked whether they want to produce a car; if so, they enter the car information, create a new car, and the cars are stored in a list.

## Features
- The Car class has properties like Production Date, Serial Number, Brand, Model, Color, and Door Count.
- Production Date is automatically set when a car is created.
- The user can create an unlimited number of cars.
- If the user enters an invalid input, a warning message is displayed, and the user is prompted to re-enter.
- At the end of the program, the Serial Number and Brand of all created cars are listed.

## Usage
When the program starts, you will be asked if you want to produce a car.
e or E: Yes, produce a car.
h or H: No, terminate the program.
If you choose to produce a car, enter the car properties sequentially:
Serial Number, Brand, Model, Color
Door Count: A numeric value must be entered.
If you want to create another car, repeat the steps.
To terminate the program, respond with h or H.
All created cars will be displayed with their serial numbers and brands.