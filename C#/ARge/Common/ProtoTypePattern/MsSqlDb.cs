﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class MsSqlDb:DatabasePrototypePattern
    {
        public MsSqlDb() {
            SetConnectionStr = "MsSqlDb";
        }

    }
}
