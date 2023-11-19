using AutoMapper;
using TaskCreator.Application.Contracts;
using TaskCreator.Domain;

namespace TaskCreator.Application;
public class TaskCreatorApplicationObjectMapper : Profile
{
    public TaskCreatorApplicationObjectMapper()
    {
        MapTasks();
    }

    private void MapTasks()
    {
        CreateMap<MainTask, MainTaskDto>().ReverseMap();
        CreateMap<MainTask, MainTaskCreateDto>().ReverseMap();
            //.Ignore(x => x.Id);

        CreateMap<MainTask, MainTaskUpdateDto>().ReverseMap();
            //.Ignore(x => x.Id);
    }

}
