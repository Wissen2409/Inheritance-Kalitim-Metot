
namespace MercedesAraclar{
public class Mercedes:Tasit{
    public string Konfor { get; set; }

        // kalıtım ile bana gelen metotların davranışlarını değiştirelim!!!

        // override keyword'ü bir metodu ezmek (yani davranışını değiştirmek) için kullanılmaktadır!!!
        public override string ToString()
        {
            //return "bu metot mercedes sınıfında değiştirilmiştir.!!!";
            return base.ToString();
        }
    }
}
