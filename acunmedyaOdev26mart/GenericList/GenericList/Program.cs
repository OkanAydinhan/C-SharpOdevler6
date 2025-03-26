using GenericList;

public class Program
{
    public static void Main()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5, 5000),
            new Araba("BMW", "X5", 9.0, 5000),
            new Araba("Mercedes", "C180", 8.2, 5000)
        };

        foreach (var araba in arabalar)
        {
            Console.WriteLine("Marka: " + araba.marka + ", Model: " + araba.model + ", 100 km'de Yaktığı Yakıt: " + araba.yakitTuketimi + " litre, Toplam Yakıt Tüketimi: " + araba.ToplamYakitTuketimiHesapla() + " litre");
        }
    }
}