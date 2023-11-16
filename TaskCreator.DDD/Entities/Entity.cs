namespace TaskCreator.DDD;
public abstract class Entity<T> : IEntity<T>
{
    public Entity() { }
    public Entity(T id)
    {
        Id = id;
    }
    public T Id { get; set; }
}
