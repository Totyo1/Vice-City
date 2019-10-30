using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string line);

        void Write(string line);
      
    }
}
