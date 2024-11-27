int sonuc = 1;
Console.Write("Sayı Giriniz : ");
int sayi = int.Parse(Console.ReadLine());
//Kullanıcının girdiği sayıyı sayı değişkenine atıyorum.
for (int i = 1; sayi >= i; sayi--)
{
    sonuc = sonuc * sayi; 
//sonuc değişkenine sayıların çarpımını atıyorum.
    if (i == sayi)
    {
        Console.Write(sayi + "=" + sonuc);
        //Burada son sayının sağına = işareti koyuyorum.Ve sonucu yazdırıyorum
    }
    else
    {
        Console.Write(sayi + "x");
        //Burada sayıların sonuna x işareti koyarak çarptırdığımı gösteriyorum.
    }
}