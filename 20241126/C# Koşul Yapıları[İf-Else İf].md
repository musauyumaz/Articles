# C# Koşul Yapıları[İf-Else İf]
- Buradaki önemli nokta if ifadesinin şartının “True” ya da “False” olmasıdır.Eğer “True” ise İf scope’u devreye girecektir.”False” ise else if ya da else scope’u çalıştırılacaktır.Şart ifadesi kısmına ne yazılırsa yazılsın sonucu “True” ya da “False” olmalıdır.

```C#
if (true mu false mı)
{
//Şart true olduğunda burası çalışır.
 
}
else
{
//Şart false olduğunda burası.
 
}

if (true mu false mı)
{
//Eğer bu ifin şartı true ise burası çalışacaktır.
}
else if (true mu false mı)
{
//Yukarıdaki false ise bura denetlenecektir.True ise işlev burada olacaktır.
}
else
{
//Yukardakilerden hiçbiri değil ise burada işlev olacaktır.
}
```