// See https://aka.ms/new-console-template for more information
using LearnOOPEngDemirog;

//InterfacesIntro();

//Demo();

// Polymorphism is implemented

ICustomerDal[] customerDals = new ICustomerDal[] {
    new SqlServerCustomerDal(), 
    new OracleServerCustomerDal(),
    new MySqlServerCustomerDal(),
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}


static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
    customerManager.Add(new OracleServerCustomerDal());
}

static void InterfacesIntro()
{
    PersonManager personManager = new();
    personManager.Add(new Customer { Id = 1, FirstName = "Fahri", LastName = "Cigdem", Address = "Hannover" });
    personManager.Add(new Student { Id = 2, FirstName = "Onur", LastName = "Cigdem", Department = "IT" });
    personManager.Add(new Worker { Id = 3, FirstName = "Sezai", LastName = "Cigdem", Department = "IT" });
}
interface IPerson
{
   int Id { get; set; }
   string FirstName { get; set; }
   string LastName { get; set; }

}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName + " is added in DB");
    }
}