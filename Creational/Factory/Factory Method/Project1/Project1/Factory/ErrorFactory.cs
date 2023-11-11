﻿using Project1.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Factory
{
    public class ErrorFactory : LoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new ErrorLogger();
        }
    }
}
