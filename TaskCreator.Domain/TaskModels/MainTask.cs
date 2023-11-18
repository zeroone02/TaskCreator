using TaskCreator.DDD;

namespace TaskCreator.Domain;
 public  class MainTask : AggregateRoot<int>
{
    public MainTask(MainTask mainTask)
    {
        Name = mainTask.Name;
        Description = mainTask.Description;
    }
    public MainTask(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public string Name { get; protected set; }
    public string Description { get; protected set; }

}
