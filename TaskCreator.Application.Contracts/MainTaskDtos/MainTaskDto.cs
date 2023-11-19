using TaskCreator.DDD.Application.Contracts;

namespace TaskCreator.Application.Contracts;
public class MainTaskDto : EntityDto<int>
{
    public string Name { get;  set; }
    public string Description { get;  set; }

}
