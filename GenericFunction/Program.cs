using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunction
{

    class Program
    {
        static void Main(string[] args)
        {
            Staff emp = GetInstance<Staff>(Importance.Staff);

            Teacher tch = GetInstance<Teacher>(Importance.Teacher);
        }

        public static T GetInstance<T>(Importance objType)
        {
            if (objType == Importance.Staff)
                return (T)Convert.ChangeType((new Staff()), typeof(T));
            else
                return (T)Convert.ChangeType((new Teacher()), typeof(T));

            //if (objType == Importance.Employee)
            //    return new Employee();
            //else
            //    return new Teacher();
        }
    }

    public class Staff
    {
        string ID = "";
        string OfficeName = "";
    }

    public class Teacher
    {
        string ID = "";
        string SchoolName = "";
    }

    enum Importance
    {
        Staff,
        Teacher
    };
}
