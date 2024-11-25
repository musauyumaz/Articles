# C# Switch-Case Kullanımı
- Switch() parantezin içine yazılan ifade,değeri kontrol edilecek olan ifadedir.Case’den sonra bu ifadenin alabileceği bir değer yazılır.Eğer ifade bu değere sahipse “Case-Break” arası çalışır.Burada “Case-Break” arası bir nevi Scope arasına benzer.Eğer hiç bir ifade hiç bir case deki değerleri uymuyorsa,”Default-Break” arası çalışır.Default-break komutunuda bir nevi Else’ye benzetebiliriz.

```C#
int sayi = 3;
switch (sayi)//Burada kontrol edilecek değeri giriyoruz.
{
case 3://Eğer değerimiz 3 ise Mbox da 3 değerini yazacaktır.
MessageBox.Show("3");
break;//case ve break komutları arasında işlem yaptırılır.
case 4:
MessageBox.Show("4");
break;
case 5:
MessageBox.Show("5");
break;
case 6:
case 7:
case 8:
case 9:
case 10:/*Eğer 6,7,8,9,10 değerlerinden biriyse Mbox a alttaki
değer yazdırılır.*/
MessageBox.Show("6,7,8,9,10");
break;//Peşpeşe yazılan case ler veya anlamına gelmektedir.
default:
//Yukarıdakilerden hiçbiri değilse buradaki komutlar çalıştırılır.
break;
}
```

- Bunların dışında goto case deyimi ile bir durumda diğer durumların komutlarını çalıştırabiliyoruz.

```C#
switch (sayi)
{
case 1: sonuc = "10"; break;
case 2: sonuc = "20"; break;
case 3: sonuc = "30"; break;
case 4: goto case 1; //sonuc değeri 10 olacak
}
```