


// bir tane metot yazalım ve bu kalıtım yapısı içerisindeki her sınıf bu metoda parametre olarak geçebilsin!!


/*static void TasitMetot(Mercedes m){

}
static void TasitMetot(Bmw b){

}
*/
// Eğer metotlara parametre alacağınız sınıflar arasında bir kalıtım hiyerarşisi var ise, sınıfları tek tek 
// parametre almanıza gerek yoktur!!
// sadece base class'ı parametre aldığınız taktirde, ondan türeyen tüm sınıflar bu metota parametre olarak geçebilir!!!

// Mercedes sınıfını aşağıdaki metoda parametre olarak gönderelim



Mercedes m = new Mercedes();
TasitMetot(m);

/*Peugeot p = new Peugeot();
TasitMetot(p);

Bmw b = new Bmw();
TasitMetot(b);
*/

// bir sınıfın türediği sınıfı görmek için gerekli olan kod!!!
Console.WriteLine(typeof(Mercedes).Name);

static void TasitMetot(Tasit tasit)
{
    // türeyen sınıflar, tasit parametresi alan metoda, parametre olarak gönderilebilir
    // türeyen sınıfların türetilen sınıfların içerisinde parametre olarak geçilmesi aslında boxing gibi bir konudur
    // Dolayısıyla, Mercedes sınıfı bu metoda parametre olarak gönderildiğinde, tasit pointeri üzerinden mercedes nesnesine bakıldığjnda, sadece tasit sınıfına ait prop'lar görünür
    // mercedes nesnesine ait propları görmek için, tasit sınıfı, mercedes sınıfına cast(unboxing) yapmalıyız ? 
    Console.WriteLine(tasit.Enerji);
    // burada, metoda parametre gönderilen, türeyen sınıflara ait özellikleri görmek istersem ? 
    //Mercedes mercedes = (Mercedes)tasit;
    //Console.WriteLine(mercedes.Enerji);
    //Console.WriteLine(mercedes.Konfor)
    // is keyword'ü : iki tipi birbiri ile kıyaslar!! ve karşılaştırma aşamasında karşılaştırdıkları şeyler aynı ise 
    // true değeri döner!!
    //

    if(tasit is Mercedes){
        var mercedes = (Mercedes)tasit;
        Console.WriteLine(mercedes.Konfor);
    }
    else if(tasit is Peugeot){
        var peugeot = (Peugeot)tasit;
        Console.WriteLine(peugeot.Ekonomi);
    }
    else if(tasit is Bmw){
        var bmw = (Bmw)tasit;
        Console.WriteLine(bmw.Performans);
    }

}