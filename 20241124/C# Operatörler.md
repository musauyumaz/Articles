# C# Operatörler
## Aritmatik Operatörler
- Genellikle sayısal işlemlerin yapıldığı operatörlerdir.
- `+`  : Stringlerde birleştirme görevi görmektedir.Sayısal ifadelerde toplama işlemini gerçekleştirir.
- `–`  : Çıkarma,
- `*`  : Çarpma,
- `/`  : Bölme,
- `%`  : Mod Alma(Örn a%b , a sayısının b’ye göre modu)

## Karşılaştırma Operatörleri
- Karşılaştırma operatörleriyle yapılan işlemlerin sonu her zaman bize ya “True” ya da “False” olarak geri döner.Çünkü buradaki karşılaştırma mantığında bir soru sorma ve cevap alma yapısı vardır.
- `<`  : Küçük müdür?
- `>`  : Büyük müdür?
- `==` : Eşit midir?
- `<=` : Küçük eşit midir?
- `>=` : Büyük eşit midir?
- `!=` : Eşit değil midir?
- char tipindeki karakter ifadeler karşılaştırılırken, arka planda aslında ASCII kod karşılıkları karşılaştırılmaktadır.

## Mantıksal Operatörler
- Mantıksal oparatörlerde sadece “True” ve “False” değerleri ile işlem yaparız.Yani operandlar mantıksal değerde olmalıdır.İşlem sonucunda tekrardan “True” ya da “False” değerleri dönecektir.
- `&`  :KISA DEVRE VE,
- `&&` :VE,
- `|`  :KISA DEVRE VEYA,
- `||` :VEYA,
- `!`  :DEĞİL,
- `^`  :XOR ÖZEL VEYA,

```C#
//‘&’ ve ‘&&’ operatörlerinin ikisi de mantıksal değerleri işleme sokabilirler ve sonucunda “True” ya da “False” değeri üretirler.Fakat ‘&&’,eğer ‘&&’ işlemi dizisinde bir tane bile “False” görürse,diğerlerini kontrol etmeden sonucu “False” olarak direkt bildirir.Fakat ‘&’,dizidekilerin hepsini teker teker kontrol ettikten sonra sonucu bildirir.Bundan dolayı ‘&&’,’&’ den daha hızlı çalışır.
true&&true=true;
true&&false=false;
false&&true=false;
false&&false=false;

//Bu operatörlerde de durum yukardakilerle aynı.’||’ operatörü işlemde bir tane “True” buldumu sonucu “True” olarak gönderir.’|’ operatörü işlemde ki bütün dizileri teker teker kontrol ettikten sonra sonucu geri gönderir.
true||true=true;
true||false=true;
false||true=true;
false||false=false;

// ! Mantıksal değerin sonucunu ters çevirir.
!true=false;
!false=true;

bool b=false;
b=!b;
//Bu işlemde ne mi yaptık?false değerine sahip olan b değişkenine,b nin tam tersini yani true değerini atadık.Bundan sonra b=true dur.
```
## Arttırma Azaltma Operatörleri
- `++` : DEĞİŞKENİN DEĞERİNİ 1 ARTTIRIR.
- `--` : DEĞİŞKENİN DEĞERİNİ 1 AZALTIR.
- `-`  : SAYININ ÖNÜNE KONDUĞU ZAMAN NEGATİF YAPAR.

```C#
int sayi=1;
++sayi; //sayi değişkeni 1 artar.
sayi++; //sayi değişkeni 1 artar
//Demek oluyor ki operatörü sağa sola koymak değişmiyor. Fakat değişkeni tek kullandığımız zaman geçerli bu koşul.

--sayi;//Sayı 1 azalır.
sayi--;

sayi=-sayi;//Sayi değişkeni negatif yapılıp yeniden sayi değişkenine aktarıldı.

-sayi;//Böyle bir kullanım şekli yoktur.HATALIDIR.

int sayi=10;
sayi = sayi++; //sayı değişkenini yazdırırsak ekranda 10 yazısı görülecektir.
sayi = ++sayi; //sayı değişkenini yazdırırsak ekranda 11 yazısı görülecektir.
```

## Üzerine Ekleme-Yığma Operatörleri
- `+=` : ÜZERİNE EKLER
- `-=` : ÜZERİNDEN ÇIKARIR
- `*=` : YIĞMALI ÇARPAR
- `/=` : YIĞMALI BÖLER
- `%=` : MOD ALIR

```C#
int sayi=10;
sayi+=sayi++; //Bu işlemin sonucunda ekrana 20 yazılacaktır.
sayi+=++sayi; //Bu işlemin sonucunda ekrana 21 yazılacaktır.
```

- Matematiksel işlemlerdeki öncelik sırası bildiğimiz gibi parantezden başlar.