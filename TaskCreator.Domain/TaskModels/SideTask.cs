using System.ComponentModel.DataAnnotations.Schema;
using TaskCreator.DDD;

namespace TaskCreator.Domain;
public class SideTask : Entity<int>
{
    public int MainTaskId { get; set; }
    [ForeignKey("MainTaskId")]
    public MainTask MainTask { get; set; }
    public string Name { get; protected set; }
    public string Description { get; protected set; }
}
