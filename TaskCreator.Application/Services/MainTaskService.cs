using AutoMapper;
using TaskCreator.Application.Contracts;
using TaskCreator.DDD;
using TaskCreator.Domain;

namespace TaskCreator.Application;
public class MainTaskService : CrudAppService<MainTask, MainTaskDto, int, MainTaskCreateDto, MainTaskUpdateDto>
    , IMainTaskService
{
    private readonly IRepository<MainTask, int> _repository;
    private readonly UnitOfWork _unitOfWork;
    public MainTaskService(IServiceProvider serviceProvider, IMapper mapper, 
        IRepository<MainTask, int> repository, UnitOfWork unitOfWork) : base(serviceProvider, mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async override Task<MainTaskDto> CreateAsync(MainTaskCreateDto input)
    {
        MainTask mainTask = ObjectMapper.Map<MainTaskCreateDto, MainTask>(input);
        await _repository.InsertAsync(mainTask);
        await _unitOfWork.SaveChangesAsync();
        return ObjectMapper.Map<MainTask, MainTaskDto>(mainTask);
    }

    public async override Task DeleteAsync(int id)
    {
        var mainTask = await _repository.GetAsync(id);
        await _repository.DeleteAsync(mainTask);
        await _unitOfWork.SaveChangesAsync();
    }

    public async override Task<MainTaskDto> GetAsync(int id)
    {
        MainTask mainTask = await _repository.GetAsync(id);
        return ObjectMapper.Map<MainTask, MainTaskDto>(mainTask);
    }

    public async override Task<List<MainTaskDto>> GetListAsync()
    {
        List<MainTask> mainTasks = await _repository.GetListAsync();
        var result = ObjectMapper.Map<List<MainTask>, List<MainTaskDto>>(mainTasks);
        return result;
    }

    public async override Task<MainTaskDto> UpdateAsync(MainTaskUpdateDto input)
    {
        MainTask mainTask = ObjectMapper.Map<MainTaskUpdateDto, MainTask>(input);
        await _repository.UpdateAsync(mainTask);
        await _unitOfWork.SaveChangesAsync();
        return ObjectMapper.Map<MainTask, MainTaskDto>(mainTask);
    }
}
