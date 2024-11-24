# C#-var ve object Değişkenleri
## var tipi değişken;
- var tipi değişken tanımlarsanız eğer değişkenin tipini siz değil derleyici tanımlayacaktır.Derleyicinin tanımladığı tipe göre o veri RAM üzerin de o tiple saklanacaktır.


- var değişken tipi,diller arası,databaseler arası entegrasyonu sağlarken veri tipleri uyuşmazlığını gidermek için oluşturulmuş bir tiptir.Yani C#’ta int ile tanımlanan bir değişken Delphi ‘de başka türlü tanımlanabilir.var değişken tipide bütün dillerde evrensellik özelliği taşımaktadır.Sizlere tavsiyem normal kodlamada verinizin tipine göre normal değişken tanımlayınız.

```C#
var a = 10.6; //a değişkeninin tipi double dır.
var b = 20; //b değişkeninin tipi int dir.
var c = "asd"; //c değişkeninin tipi string dir.
var d = true; //d değişkeninin tipi booldur.
```

## object tipi değişkenler
- object olarak tanımlanan değişken her tipteki veriyi içinde saklayablir.Fakat object tipteki değişkene atanan değer Boxing(Kutulama) işlemine uğrar.Yani,object tipiyle oluşturduğumuz bir string değişken,RAM’e string olarak değilde object olarak kaydedilir.Tanımlanan object değişkeni kullanmak istediğimiz de,içinde saklanan verinin tipini elde ederek kullanmalıyız.Bunun içinde Unboxing(Kutudan Çıkarma) işlemi yapılır.Bu işlem sonucunda object içindeki asıl tipini almış oluruz.

```C#
object o1 = "ali";
object o2 = 12.5f;
object o3 = 'c';
object o4 = true;
//Bu değişkenlere verilen değerlerin hiç biri RAM’e tipine göre isimlendirilerek kaydedilmemiştir.object olarak kaydedilmiştir.İşte bu işleme Boxing(Kutulama) denir.
```

```C#
object b=10; //Boxing
int a = (int)b; //Unboxing

object ahmet1 = "ahmet";//Boxing
string ahmet2 = (string)ahmet1;//Unboxing

//Son olarak object tipli değişkenler de,değişkenin içinde ki verinin tipini dinamik olarak öğrenmek istiyorsak aşağıdaki metod işimizi görecektir.
object dd="TİPİBİLİNMEYENBİRDEĞER";
dd.GetType();//Bu metod sayesinde dd isimli object değişkeninin içinde sakladığı değişkenin tipini öğrenebiliriz.
```

- object tipi C# mimarisinin türediği en temel tip olarak varsayılabilir.Haliyle tüm tipleri kapsamaktadır.Object veri tipiyle değişken tanımlanabilir ama object tanımlanan veriyi boxing edecektir.O veriyi kullanabilmek için unboxing işlemleri yaparız.Object veri tipi bu özelliğiyle bize oldukça kolaylık sağlamaktadır.Örneğin, tipini bilmediğimiz verileri object ile elde ederek sonra gerekli tiplere Convert edebiliriz

```C#
// double ya da int verilere cast işleminde invalid cast exception veriyor
Console.WriteLine("Bir değer");
        object deger = Console.ReadLine();
        Console.WriteLine("Dönüştürmek istediğiniz tip ( int double string )");
        string tip = Console.ReadLine();
        switch (tip)
        {
            case "int":
                int sayi = (int)deger;
                Console.WriteLine(sayi);
                break;

//Kullanıcıdan Console.ReadLine ile aldığınız veri string tipte elde edilmektedir ve 2. satırda objeye atarken dikkat ederseniz eğer o string veriyi direkt olarak boxing yapmaktasın. Dolayısıyla object içerisindeki veri hangi türde atıldıysa ancak o türde unboxing yapılabileceğinden dolayı int’e cast edilmeye çalışıldığında ilgili hata ile karşılaşmaktasınız.Yapacağınız kodu bu mantık çerçevesinde düzenlemenizi ve hangi tipe dönüştürmek istiyorsanız eğer öncelikle string tipte unboxing etmenizi ve ardından gerekli Convert işlemini gerçekleştirmenizi öneririm.
```