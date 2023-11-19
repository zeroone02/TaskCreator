using TaskCreator.DDD.Application.Contracts;

namespace TaskCreator.Application.Contracts;
public class MainTaskUpdateDto : EntityDto<int>
{
    public string Name { get;  set; }
    public string Description { get;  set; }

}
