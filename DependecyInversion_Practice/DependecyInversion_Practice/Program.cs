
using System;
using DependecyInversion_Practice;

namespace DependencyInversion_Practice
{
  
    
    class Program
    {
        static void Main(string[] args)
        {
            IOgretmen teacher = new Teacher("John", "Doe");
            ClassRoom classRoom = new ClassRoom(teacher);

            Console.WriteLine(classRoom.GetTeacherInfo());
        }
    }
}
