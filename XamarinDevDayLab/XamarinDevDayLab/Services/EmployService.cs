using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee = XamarinDevDayLab.Models.Employee;

namespace XamarinDevDayLab.Services
{
    public class EmployService
    {
        public List<Employee> GetAllEmployees()
        {
            var result = new List<Employee>();
            result.Add(new Employee() { Name = "Ian", Age = 22, Phone = "123456789" });
            result.Add(new Employee() { Name = "Andy", Age = 27, Phone = "888866666" });
            result.Add(new Employee() { Name = "Joe", Age = 30, Phone = "112233445566" });

            return result;
        }
    }
}
