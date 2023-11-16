using TaskCreator.DDD;

namespace TaskCreator.Application.Contracts;
public class MainTaskDto : Entity<int>
{
    public string Name { get;  set; }
    public string Description { get;  set; }

}
