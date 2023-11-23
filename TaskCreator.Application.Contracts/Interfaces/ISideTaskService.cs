using TaskCreator.DDD.Application.Contracts;

namespace TaskCreator.Application.Contracts;
public interface ISideTaskService :
     ICrudAppService<SideTaskDto, int, SideTaskCreateDto, SideTaskUpdateDto>

{
}
