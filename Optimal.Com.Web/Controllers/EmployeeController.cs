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
        public async Task<IActionResult> AddEmployee(EmployeeModel model)
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

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateModel model)
        {
            var respone = await _employeeService.Update(model);
            return Ok(respone);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _employeeService.GetById(id);
            if (response != null)
                return Ok(response);
            else
                return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetByEmployeeId(string employeeId)
        {
            var response = await _employeeService.GetByEmployeeId(employeeId);
            if (response != null)
                return Ok(response);
            else
                return NotFound();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int id)
        {
            var emp = await _employeeService.GetById(id);
            if(emp != null)
            {
                await _employeeService.Delete(id);
                return Ok();
            }
            else return NotFound();
        }
    }
}
