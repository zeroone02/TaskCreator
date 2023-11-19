namespace TaskCreator.DDD.Application.Contracts;
public interface ICreateAppService<TDto, TCreateDto>
{
    Task<TDto> CreateAsync(TCreateDto input);
}
