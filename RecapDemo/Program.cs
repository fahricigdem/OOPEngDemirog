// See https://aka.ms/new-console-template for more information

CustomerManager customerManager = new CustomerManager();
customerManager.Logger=new SmsLogger();
customerManager.Add();

class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine("Customer Added!");
    }
}

class DatabaseLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged in Database!");
    }
}

class FileLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged in File");
    }
}

class SmsLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged with Sms");
    }
}


interface ILogger
{
    void Log();
}
