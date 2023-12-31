﻿using Business.Abstract;
using DataAccess;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;
    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }
}
