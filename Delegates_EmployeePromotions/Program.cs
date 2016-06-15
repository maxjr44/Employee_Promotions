using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EmployeePromotions
{
    class Program
    {
        public static void Main()
        {
            List<EE> empList = new List<EE>();

            empList.Add(new EE() { ID = 101, Name = "Marry", Salary = 5000, Experiense = 5 });
            empList.Add(new EE() { ID = 101, Name = "Mike", Salary = 4000, Experiense = 4 });
            empList.Add(new EE() { ID = 101, Name = "John", Salary = 6000, Experiense = 6 });
            empList.Add(new EE() { ID = 101, Name = "Todd", Salary = 3000, Experiense = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);


            EE.PromoteEE(empList, isPromotable);
        }

        public static bool Promote(EE emp)
        {
            if(emp.Experiense>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(EE empl);

    class EE
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experiense { get; set; }

        public static void PromoteEE(List<EE> eeList, IsPromotable IsEligibleToPromote)
        {
            foreach(EE employee in eeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " to be promoted");
                    Console.ReadKey();  
                }

            }

        }
    } 
}
