﻿using Domain;
using Domain.OutPutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IServiceDB
    {
        string Login(InputLogin model);
    }
}
