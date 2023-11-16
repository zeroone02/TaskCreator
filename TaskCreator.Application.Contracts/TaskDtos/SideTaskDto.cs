using TaskCreator.DDD;

namespace TaskCreator.Application.Contracts;
public class SideTaskDto : Entity<int>
{
    public int MainTaskId { get; set; }
    public MainTaskDto? MainTask { get; set; }
    public string Name { get;  set; }
    public string Description { get;  set; }
}
