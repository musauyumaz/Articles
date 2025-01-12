# C# Break,Continue,Return Komutları
- Bazen yazsakta bazı komutların okunmamasını isteriz,bazen döngüyü 100 e kadar saydırır ama yarısında durmasını isteriz.Bazende o metoddan arkamıza bakmadan çıkıp gitmek isteriz.İşte bu durumlarda break,continue ve return komutları imdadımıza yetişecektir.

## Break komutu;
- Bu komut koşulları bilenlere pekte yabancı gelmeyecektir.Switch Case koşul yapılarında kullandığımız bir ifadedir.Hemen örnek verelimde anımsayınız;
```C#
switch (Değişken)
            {
               case buysa:
                    Bu olsun;
                    break;
                case Yok efendim bu ise:
                    Bu olsun;
                    break;
            }
```

- Break,genel anlamda döngü ya da switch koşulunun scope’u dışına çıkmamızı sağlar.Yukarıda da gördüğünüz gibi değişken case yapılarıyla kontrol edildikten sonra doğru olan kodlar çalıştırılacaktır.Diğer caseler kontrol edilmemesi için break komutuyla switch in scopelarından çıkılacaktır.

- Break komutunu döngü blogları ve switch kontrolünden başka yerde kullanamayız.

```C#
for (int i = 1; i <= 5; i++)
            {
                if (i==3)
                {
                    break;
                }
                Console.Write(i);
            }
}
/*i üç olduğunda döngüden çıktığı için
saymaya devam etmeyecektir.Çıktı olarak "12" gösterecektir.*/
```

## Continue komutu;
- Bu komuttan sonra yazılan komutlar çalıştırılmaz. 

- Bu komut yazılan kodu atlatır burada bekleme yapma devam et ticari gibi...

```C#
for (int i = 1; i >= 5; i++)
             {
                if (i < 3)
                {
                    continue;
                }
                Console.Write(i);
            }
            Console.Read();
/*i 3 ten küçük olduğu sürece continue den sonraki
ifadeler okunmayacaktır.i 3 e eşit ve büyük olduğu
sürece,continueden sonraki ifadelerde okunacaktır.
Ekrana 345 olarak yazılacaktır.*/
```

- continue komutu,break komutu gibi döngülerden başka yerlerde kullanılmıyor.

## Return
- return komutu, döngünün süslü parantezinden tut taaa metodun süslü parantezine kadar hepsinden çıkar ve ondan sonraki komutlar işlenmez… Aslında return komutu işlendiği o satırda oluşturalan akış son bulur ve algoritmanın devamı(geri kalanı) ve diğer algoritmik durumlar çalıştırılmaz.