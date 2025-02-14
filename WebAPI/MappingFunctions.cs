using Application.Dtos;
using Domain.Entities;
using Mapster;

namespace WebAPI
{
    public static class MappingFunctions
    {
        public static ModelDto MapModelToDto(Model model)
        {
            return model.Adapt<ModelDto>();
        }
        public static Model MapDtoToModel(ModelDto model)
        {
            return model.Adapt<Model>();
        }
    }
}
