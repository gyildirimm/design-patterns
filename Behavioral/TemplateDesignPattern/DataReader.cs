namespace TemplateDesignPattern;

public abstract class DataReader
{
    public void ReadData()
    {
        Connect();
        FetchData();
        Disconnect();
    }
    
    protected abstract void Connect();
    protected abstract void FetchData();
    
    protected virtual void Disconnect()
    {
        Console.WriteLine("Bağlantı kapatıldı.");
    }
}