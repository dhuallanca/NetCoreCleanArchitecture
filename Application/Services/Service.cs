using Application.Dtos;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    /// <summary>
    /// use cases, business logic
    /// </summary>
    public class Service : IService
    {
        private readonly IModelRepository _repository;

        public Service(IModelRepository repository)
        {
            _repository = repository;
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModelDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ModelDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ModelDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ModelDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertById(ModelDto entity)
        {
            throw new NotImplementedException();
        }

        public void InsertByIdAsync(ModelDto entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(ModelDto entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateByIdAsync(ModelDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
