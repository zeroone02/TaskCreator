using TaskCreator.DDD.Application.Contracts;

namespace TaskCreator.Application.Contracts;
public class SideTaskCreateDto : EntityDto<int>
{
    public int MainTaskId { get; set; }
    public MainTaskDto? MainTask { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
