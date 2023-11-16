namespace TaskCreator.DDD;
public interface IEntity<TKey>
{
    TKey Id { get; set; }
}
