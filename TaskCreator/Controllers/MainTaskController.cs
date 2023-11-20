using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskCreator.Application;
using TaskCreator.Application.Contracts;

namespace TaskCreator.Controllers;
[Route("api/mainTask")]
[ApiController]
public class MainTaskController : Controller
{
    private readonly IMainTaskService _mainTaskService;
    public MainTaskController(IMainTaskService mainTaskService)
    {
        _mainTaskService = mainTaskService;
    }
    //будет отображать все таски и также кнопки к ним,
    //создать, удалить, посмотреть на содержимое этой mainTask, посмотреть на все sideTask этого mainTask
    public async Task<IActionResult> MainTaskIndex()
    {
        var mainTaskDtos = await _mainTaskService.GetListAsync();
        return View();
    }
    //будет показывать поля для ввода maintask
    public async Task<IActionResult> MainTaskCreate()
    {
        return View();
    }
    //будет отвечать за создание maintask и сохранение её в бд 
    [HttpPost]
    public async Task<IActionResult> MainTaskCreate(MainTaskCreateDto mainTaskCreateDto)
    {
        return View();
    }
    public async Task<IActionResult> MainTaskDelete(int id)
    {
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> MainTaskDelete(MainTaskDto productDto)
    {
        

        return View();
    }
}
