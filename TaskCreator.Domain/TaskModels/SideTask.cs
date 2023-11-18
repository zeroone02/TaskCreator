using System.ComponentModel.DataAnnotations.Schema;
using TaskCreator.DDD;

namespace TaskCreator.Domain;
public class SideTask : Entity<int>
{
    public SideTask(SideTask sideTask)
    {
        MainTaskId = sideTask.MainTaskId;
        Name = sideTask.Name;
        Description = sideTask.Description;
    }
    public SideTask(int mainTaskId,string name,string description)
    {
        MainTaskId = mainTaskId;
        Name = name;
        Description = description;
    }
    public int MainTaskId { get; protected set; }
    [ForeignKey("MainTaskId")]
    public MainTask MainTask { get; protected set; }
    public string Name { get; protected set; }
    public string Description { get; protected set; }
}
