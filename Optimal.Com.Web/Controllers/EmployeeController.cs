using Microsoft.AspNetCore.Mvc;
using Optimal.Com.Web.Framework.Controller;
using Optimal.Com.Web.Models.RequestModels;
using Optimal.Com.Web.Services;

namespace Optimal.Com.Web.Controllers
{
    public class EmployeeController:BaseController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewEmployee(EmployeeModel model)
        {
            var response = await _employeeService.Create(model);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var response = await _employeeService.GetAllEmployee();
            return Ok(response);
        }
    }
}
