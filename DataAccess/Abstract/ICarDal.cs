using Entities.Concrete;

namespace DataAccess;

public interface ICarDal
{
    List<Car> GetAll();
    Car GetById(int Id);
    void Update(Car car);
    void Delete(Car car);
    void Add(Car car);

}
