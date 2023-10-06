using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployee();
        Task<EmployeeModel> Create(EmployeeModel model);
        Task<Employee?> Update(EmployeeUpdateModel model);
        Task<Employee?> GetById(int id);
        Task<Employee?> GetByEmployeeId(string employeeId);
        Task Delete(int id);
    }
}
