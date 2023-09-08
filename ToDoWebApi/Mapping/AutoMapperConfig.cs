using AutoMapper;
using DtoLayer.Dtos.ToDoDto;
using ToDo.EntityLayer.Concrete;

namespace ToDoWebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ToDoAddDto, todo>();
            CreateMap<todo,ToDoAddDto>();

            CreateMap<UpdateToDoDto, todo>().ReverseMap();
            
        }
    }
}
