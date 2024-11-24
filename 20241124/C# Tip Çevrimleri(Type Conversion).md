# C# Tip Çevrimleri(Type Conversion)
## String verileri sayısala çevirme
- Label,textbox gibi kontrollerin bazılarında .Text özelliği içerisindeki veri string özellik taşımaktadır.Aşağıdaki örnekte int değişkenine textbox kontrolünün text özelliği atılmak isteniyor.Ancak textbox.Text özelliği string bir değer taşıdığı için,int tipindeki değişkene atılınca derleyiciden hata alıyoruz.textbox.Text özelliği içindeki string veriyi int tipine çevirmemiz lazım.

```C#
int a;
a =Convert.ToInt32(textBox1.Text)

//Ek olarak Parse metodundan bahsetmek istiyorum.Bu metod sadece string veriler üzerinde dönüştürme yaparken geçerlidir.
double b;
b = double.Parse(textBox1.Text); //Parse metodunu bu şekilde kullanıyoruz. Dikkat edilmesi gereken nokta sadece string tipleri başka tiplere dönüştürürken kullanılır.
```

## Sayısal verileri string’e çevirme
- MessageBox,label,textbox gibi bazı kontrollerin yazı özellikleri string olduğu için,bazı matematiksel hesaplama gibi benzer olayların sonuclarını bu kontrollerde gösterirken string tipine çevirmemiz gerekiyor.Elimizdeki int tipindeki sonucu,string özelliği gösteren bir kontrolde göstermek istiyorsak mecburen o int stringe convert edilmedilidir.

```C#
int a = 10;
textBox1.Text = Convert.ToString(a);

// int tipindeki a değişkenini textbox.Text özelliğine atarken string tipine dönüştürülerek atılmış.Bunun sebebini artık biliyorsunuz.string tipine dönüştürmenin farklı kalıpları vardır.Biri yukarda gösterdiğimiz klasik biçimdir. 
//Bir diğeri ise,

double a = 10;
textBox1.Text = a.ToString(); //Buradaki ToString() metodu sayesinde double tipinde ki a değişkenini stringe çevirmiş oldum.

double a;
a = 10;
textBox1.Text = a + "";//Buradaki +"" bir nevi string tipine convert işlemidir.Şöylede düşünülebilir.String ile int toplamı stringtir.
```