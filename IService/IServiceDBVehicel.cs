using Domain.OutPutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IServiceDBVehicel
    {
        List<OutPutCar> GetVehicel();
    }
}
