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

        public async Task<Employee?> GetById(int id)
        {
            var emp = await _employeeRepository.GetByIdAsync(id)??null;
            return emp;
        }

        public async Task<Employee?> GetByEmployeeId(string employeeId)
        {
            var emp = await _employeeRepository.Table.Where(s => s.EmployeeID == employeeId).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<Employee?> Update(EmployeeUpdateModel model)
        {
            var emp = await _employeeRepository.GetByIdAsync(model.Id);

            if (emp != null)
            {
                var updatedEntity = _mapper.Map(model, emp);
                await _employeeRepository.UpdateAsync(updatedEntity);
            }
            else
            {
                var enity = _mapper.Map<Employee>(model);
                await _employeeRepository.AddAsync(enity);
            }

            return await GetById(model.Id);
        }

        public async Task Delete(int id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

    }
}
