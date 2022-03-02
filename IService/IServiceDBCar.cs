using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IServiceDBCar
    {
        int AddCarmaintain(CarMaintain carmaintain);
        int AddCarinsurance(CarInsurance carInsurance);
        int AddCarservice(CarService carService);
        int AddCarbreak(CarBreak carBreak);
    }
}
