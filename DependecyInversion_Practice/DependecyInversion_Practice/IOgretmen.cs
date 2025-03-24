using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion_Practice;

public interface IOgretmen
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();
}
