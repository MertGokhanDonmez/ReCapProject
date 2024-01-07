using Entities.Concrete;

namespace DataAccess;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;
    public InMemoryCarDal()
    {
        _cars = new List<Car> {
            new Car{Id=1, BrandId=1, ColorId=3, ModelYear=new DateTime(1990), DailyPrice=100, Description="Mercedes"},
            new Car{Id=2, BrandId=1, ColorId=2, ModelYear=new DateTime(2010), DailyPrice=200, Description="BMW"},
            new Car{Id=3, BrandId=2, ColorId=5, ModelYear=new DateTime(2015), DailyPrice=250, Description="Fiat"},
            new Car{Id=4, BrandId=3, ColorId=2, ModelYear=new DateTime(2023), DailyPrice=400, Description="Renault"},
            new Car{Id=5, BrandId=2, ColorId=1, ModelYear=new DateTime(2004), DailyPrice=300, Description="Toyota"}
        };
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        // _cars.Delete(car);
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car GetById(int Id)
    {
        return _cars.First(c => c.Id == Id);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.First(c => c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.Description = car.Description;
    }
}
