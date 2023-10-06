using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployee();
        Task<EmployeeModel> Create(EmployeeModel model);
    }
}
