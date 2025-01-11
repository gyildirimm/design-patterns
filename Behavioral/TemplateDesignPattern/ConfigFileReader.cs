namespace TemplateDesignPattern;

public class ConfigFileReader : DataReader
{
    protected override void Connect()
    {
        Console.WriteLine("Configuration dosyasına bağlanılıyor...");
    }

    protected override void FetchData()
    {
        Console.WriteLine("Configuration dosyasından veri okundu: 'AppSettings:ApiKey=12345'");
    }
}