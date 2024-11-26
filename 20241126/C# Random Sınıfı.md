# C# Random Sınıfı

- Bu sınıf sayesinde istediğimiz aralıklarda sayılar üretebilir,bu üretilen sayıları istediğimiz işlemlerde kullanabiliriz.

```C#
Random otomatiksayi=new Random();
//otomatiksayi adında referans oluşturuyoruz.
otomatiksayi.Next();
/*Buradaki Next methodu ile 0-int değişkeninin son
değeri arasında sayı üretir.*/
otomatiksayi.Next(20);
//0 ile 20(20 hariç) arasında sayı üretir.
otomatiksayi.Next(10,230);
//10 ile 230(10 dahil 230 hariç) arasında sayı üretir.
otomatiksayi.NextDouble();
//0.0 ile 1.0 arasında double değerinde sayı üretir.
```