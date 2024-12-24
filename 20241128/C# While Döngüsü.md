# C# While Döngüsü
- Şart ifadesi “True” olduğu sürece döngü dönen bir yapıya sahiptir.While döngüsünde önemli nokta,şart ifadesinin içindeki değer döngü scopeları içerisinde sürekli olarak değiştirilmek zorundadır.Aksi taktirde sürekli “True” olduğundan dolayı döngü sonsuz dönecektir.

```C#
while (true)//True değerinde şart ifadesi
{
//Döngü çalıştıkça işlenecek kodlar.
}
```

- While-Do While arasındaki farklar ise,While döngüsü eğer şart “True” ise döngü döner.Do While döngüsü ise bir kere döner ve sonra şartı kontrol eder.Eğer “True” ise devam eder.Yani While döngüsünün çalışması için şartın “True” olması gerekiyor,Do While döngüsünde yüzdeyüz bir kere döngü çalışıyor sonra şart kontrol ediliyor.