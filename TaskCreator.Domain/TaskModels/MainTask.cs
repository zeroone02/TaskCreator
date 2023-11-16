using TaskCreator.DDD;

namespace TaskCreator.Domain;
 public class MainTask : AggregateRoot<int>
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }

}
