using TaskCreator.DDD.Application.Contracts;

namespace TaskCreator.Application.Contracts;
public interface IMainTaskService :
     ICrudAppService<MainTaskDto, int, MainTaskCreateDto, MainTaskUpdateDto>
{
}
