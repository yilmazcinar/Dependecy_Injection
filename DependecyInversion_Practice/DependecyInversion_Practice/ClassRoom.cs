using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion_Practice;

public class ClassRoom
{
    public IOgretmen Teacher { get; set; }

    public ClassRoom(IOgretmen teacher)
    {
        Teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return Teacher.GetInfo();
    }
}
