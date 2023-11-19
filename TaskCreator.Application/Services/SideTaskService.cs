using AutoMapper;
using TaskCreator.Application.Contracts;
using TaskCreator.DDD;
using TaskCreator.Domain;

namespace TaskCreator.Application;
public class SideTaskService : CrudAppService<SideTask, SideTaskDto, int, SideTaskCreateDto, SideTaskUpdateDto>
    , ISideTaskService
{
    private readonly IRepository<SideTask, int> _repository;
    private readonly UnitOfWork _unitOfWork;
    public SideTaskService(IServiceProvider serviceProvider, IMapper mapper, 
        IRepository<SideTask, int> repository, UnitOfWork unitOfWork) : base(serviceProvider, mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async override Task<SideTaskDto> CreateAsync(SideTaskCreateDto input)
    {
        SideTask sideTask = ObjectMapper.Map<SideTaskCreateDto, SideTask>(input);
        await _repository.InsertAsync(sideTask);
        await _unitOfWork.SaveChangesAsync();
        return ObjectMapper.Map<SideTask, SideTaskDto>(sideTask);
    }

    public async override Task DeleteAsync(int id)
    {
        var sideTask = await _repository.GetAsync(id);
        await _repository.DeleteAsync(sideTask);
        await _unitOfWork.SaveChangesAsync();
    }

    public async override Task<SideTaskDto> GetAsync(int id)
    {
        SideTask sideTask = await _repository.GetAsync(id);
        return ObjectMapper.Map<SideTask, SideTaskDto>(sideTask);
    }

    public async override Task<List<SideTaskDto>> GetListAsync()
    {
        List<SideTask> sideTasks = await _repository.GetListAsync();
        var result = ObjectMapper.Map<List<SideTask>, List<SideTaskDto>>(sideTasks);
        return result;
    }

    public async override Task<SideTaskDto> UpdateAsync(SideTaskUpdateDto input)
    {
        SideTask sideTask = ObjectMapper.Map<SideTaskUpdateDto, SideTask>(input);
        await _repository.UpdateAsync(sideTask);
        await _unitOfWork.SaveChangesAsync();
        return ObjectMapper.Map<SideTask, SideTaskDto>(sideTask);
    }
}
