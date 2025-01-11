using TemplateDesignPattern;

Console.WriteLine("Configuration Dosyasından Veri Okuma:");
DataReader configReader = new ConfigFileReader();
configReader.ReadData();

Console.WriteLine("\nVeritabanından Veri Okuma:");
DataReader dbReader = new DatabaseReader();
dbReader.ReadData();