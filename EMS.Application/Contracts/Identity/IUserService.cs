using EMS.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Contracts.Identity
{
    public interface IUserService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(string userId);
    }
}
