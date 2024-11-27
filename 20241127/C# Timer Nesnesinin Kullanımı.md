# C# Timer Nesnesinin Kullanımı
- Timer kontrolü belirli zaman aralıklarıyla belirli işleri yapmamızı sağlar.

- Timer kontrolü sadece arka planda çalışan bir kontrol olduğundan dolayı projemize eklediğimizde form üstünde gözükmeyecektir.

- Interval özelliği,milisaniye cinsinden olup Timer kontrolünün zamanını ayarlayabiliriz.1000 milisaniye 1 saniyedir.Properties penceresinden ayarlanabilir.
- Projemize eklediğimiz timer1 adlı Timer kontrolümüzün kod kısmında Interval özelliğini ayarlayalım.

```C#
timer1.Interval = 1000;
```

## Metodları
- `timer1.Start();` = Timer’ın çalışması için başlatılması gerekiyor.Start() metoduyla Timer nesnesi çalıştırılabilir.
- `timer1.Stop();` = Timer nesnesini durdurmak için bu metod kullanılır.
- Timer nesnesi kendiliğinden çalışmaz.Yukarıdaki Start() metoduyla başlatılması gerekir.Stop() metoduylada durduruluyordu.Ancak bu işlevi gören farklı özellikler vardır.
- `timer1.Enabled = True;` = Timer nesnesini başlatır.
- `timer1.Enabled = False;` = Timer nesnesini durdurur.
## Olayları
- Timer nesnesinin bir tane olayı vardır o da Tick olayıdır.Intervalde belirlenen süre her geçtiğinde, Tick olayı otomatik olarak çalışır.Timer’ın her tetiklenmesinde çalışmasını istediğiniz kodlar bu olaya yazılır.