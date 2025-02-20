using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    /// <summary>
    /// Repository implement IRepository
    /// Works with Data access
    /// </summary>
    public class ModelRepository : IModelRepository, IDisposable
    {
        //private readonly ModelDbContext _dbContext;
        //public ModelRepository(ModelDbContext context)
        //{
        //    _dbContext = context;
        //}
        private readonly ModelDbContext _dbContext;
        public ModelRepository(ModelDbContext context) => _dbContext = context;

        public Task<Model> CreateModel()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Model>> GetModels()
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Model> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Model GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Model> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Model entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateByIdAsync(Model entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertById(Model entity)
        {
            throw new NotImplementedException();
        }

        public void InsertByIdAsync(Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
