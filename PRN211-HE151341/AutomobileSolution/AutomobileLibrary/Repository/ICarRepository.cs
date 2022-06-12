    using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int carID);
        void InsertCar(Car car);
        void DeleteCar(int carID);
        void UpdateCar(Car car);

    }
}   
