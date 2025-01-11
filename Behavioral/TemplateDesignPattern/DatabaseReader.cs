namespace TemplateDesignPattern;

public class DatabaseReader : DataReader
{
    protected override void Connect()
    {
        Console.WriteLine("Veritabanına bağlanılıyor...");
    }

    protected override void FetchData()
    {
        Console.WriteLine("Veritabanından veri okundu: 'SELECT * FROM Users'");
    }

    // Veritabanı özel bir kapatma işlemi gerektiriyor
    protected override void Disconnect()
    {
        Console.WriteLine("Veritabanı bağlantısı güvenli bir şekilde kapatıldı.");
    }
}