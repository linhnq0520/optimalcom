using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IRepository<Employee> employeeRepository, IMapper mapper) 
        { 
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            var response = new List<EmployeeModel>();
            var emps = await _employeeRepository.Table.ToListAsync();
            if(emps.Any())
            {
                response = _mapper.Map<List<EmployeeModel>>(emps);
            }
            return response;
        }
        public async Task<EmployeeModel> Create(EmployeeModel model)
        {
            var entity = _mapper.Map<Employee>(model);
            await _employeeRepository.AddAsync(entity);
            return model;
        }

        public async Task<EmployeeModel> GetById(int id)
        {
            var response = new EmployeeModel();
            var emp = await _employeeRepository.GetByIdAsync(id);
            if(emp != null)
            {
                response = _mapper.Map<EmployeeModel>(emp);
            }
            return response;
        }

        public async Task<EmployeeModel> GetByEmployeeId(string code)
        {
            var response = new EmployeeModel();
            var emp = await _employeeRepository.Table.Where(s=>s.EmployeeID==code).FirstOrDefaultAsync();
            if (emp != null)
            {
                response = _mapper.Map<EmployeeModel>(emp);
            }
            return response;
        }

        public async Task<EmployeeModel> Update(EmployeeUpdateModel model)
        {
            var emp = _employeeRepository.GetByIdAsync(model.Id);
            var entity = _mapper.Map<Employee>(model);
            if (emp != null)
                await _employeeRepository.UpdateAsync(entity);
            else await _employeeRepository.AddAsync(entity);
            return await GetByEmployeeId(model.EmployeeId);
        }
    }
}
