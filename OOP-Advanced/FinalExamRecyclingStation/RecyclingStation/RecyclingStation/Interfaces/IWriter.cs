﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.Interfaces
{
    public interface IWriter
    {
        void Write(string output);

        void WriteLine(string output);
    }
}
