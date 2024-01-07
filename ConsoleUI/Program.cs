

using Business.Concrete;
using DataAccess;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    System.Console.WriteLine(car.Description);
}
