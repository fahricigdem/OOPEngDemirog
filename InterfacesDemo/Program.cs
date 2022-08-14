// See https://aka.ms/new-console-template for more information


using InterfacesDemo;

// SOLID, Interface segragetion is implemented

IWorker[] workers = new IWorker[3]
{
    new Worker(),
    new Manager(),
    new Robot(),
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2] 
{ 
    new Worker(),
    new Manager(),
};

foreach (var eat in eats)
{
    eat.Eat();
}