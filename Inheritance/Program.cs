// See https://aka.ms/new-console-template for more information

using Inheritance;

// a child can have only one parent not many parents as interfaces.
// But after inheritance, Interfaces can be added : Person, IPerson, etc

Customer customer=new Customer();
customer.FirstName = "Ali";
Console.WriteLine(customer.FirstName);

Person[] people = new Person[] {
    new Person{ FirstName="Engin" },
    new Customer{ FirstName="Fahri"},
    new Student{ FirstName="Onur"},
};

foreach (Person person in people)
{
    Console.WriteLine(person.FirstName);
}