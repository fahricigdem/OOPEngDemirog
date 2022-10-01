// See https://aka.ms/new-console-template for more information

using Inheritance;

// a child can have only one parent not many parents as interfaces.
// But after inheritance, Interfaces can be added : Person, IPerson, etc

Customer customer=new Customer();
customer.FirstName = "Ali";
//Console.WriteLine(customer.FirstName);

Person[] people = new Person[] {
    new Person{ FirstName="Engin" },
    new Customer{ FirstName="Fahri"},
    new Student{ FirstName="Onur"},
};

foreach (Person person in people)
{
    //Console.WriteLine(person.FirstName);
}

List<Person> people2 = new List<Person>();
Student student1 = new Student { Id = 1, FirstName = "Onur", LastName = "Cigdem", Department = "Computer" };
Customer customer1 = new Customer { Id = 1, FirstName = "Onur", LastName = "Cigdem",City="Tokat" };
Ekle(customer1);
Ekle(student1);
Sil(customer1);
void Ekle(Person person)
{
    people2.Add(person);
}
void Sil(Person person)
{
    people2.Remove(person);
}


foreach (var person in people2)
{
    Console.WriteLine(person.FirstName);
    if (person is Student) Console.WriteLine(((Student)person).Department);
}