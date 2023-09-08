using AutoMapper;
using ToDo.EntityLayer.Concrete;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.ToDoDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultToDoDto,todo>().ReverseMap();
            CreateMap<CreateToDoDto,todo>().ReverseMap();
            CreateMap<UpdateToDoDto,todo>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
