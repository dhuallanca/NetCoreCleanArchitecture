using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Interface that handle interaction with the repository from Infraestructure
namespace Domain.Interfaces
{
    public interface IModelRepository : IRepositoryBase<Model>
    {
        Task<Model> CreateModel();
        Task<IList<Model>> GetModels();
    }
}
