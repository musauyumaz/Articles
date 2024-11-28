# C# For Döngüsü
- Genel anlamda yapısından For döngüsü ile bir olayı istediğimiz kadar gerçekleştirebiliriz. For döngüsü üç parametreye sahiptir.İlk parametrede başlangıç değeri,ikincisinde döngü şartı ve üçüncüsün de ise artış azalış işlemleri yapılır.

```C#
for(Başlangıç; Koşul; Artış)
{
//koşul doğru olduğu sürece yapılacaklar
}

//Mantık şu şekilde işlemektedir;
for(int k=0; k<10; k++) { Consol.Write("MUSA UYUMAZ"); } //Ekrana ard arda 10 kere "MUSA UYUMAZ" yazacaktır. 

//k başlangıç değeri kontrol edilir.Sonra koşul bölümü kontrol edilir.Eğer true ise döngü çalıştırılır.Bundan sonra başlangıç değeri değil k nın bir arttırılmış hali koşulda dikkate alınacaktır.Eğer ne zaman k 10dan büyük olursa o zaman döngü sona erecektir.
```

- Başlangıç kısmında bir değişken tanımlayabilir ya da dışarıdaki bir değişkeni referans alabiliriz.Sonuçta iki türlüde ilk parametrede başlangıç değerini tanımlamış oluyoruz.Ama iki işlem arasında ufak bir fark vardır.

```C#
for(int i=0; i<10; i++) { ... } 
//Yukarıdaki örnekte başlangıç değeri olarak i değişkeni tanımlanmış ve 0 değeri değişkene atanmıştır.Bu şekilde,bu i değişkenini for scope'u dışında kullanamıyoruz.A

int i=0 for(i; i<10; i++) { ... }
//Ancak, üsteki şekildeki gibi değişkeni dışarda tanımlayıp for döngüsünde başlangıç değeri olarak kullanırsak,bu değişkeni diğer alanlardada kullanabiliyoruz. Döngünün çalışması sona ermeden döngüden sonraki komutların çalışmayacaktır. İç içe döngülerde,içteki döngünün çalışması bitmeden,dıştaki döngü devam etmez. 
```