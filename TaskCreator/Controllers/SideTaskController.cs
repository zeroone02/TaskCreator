using Microsoft.AspNetCore.Mvc;
using TaskCreator.Application;
using TaskCreator.Application.Contracts;

namespace TaskCreator.Controllers;
public class SideTaskController : Controller
{
    private readonly ISideTaskService _sideTaskService;
    public SideTaskController(ISideTaskService sideTaskService)
    {
        _sideTaskService = sideTaskService;
    }
    [HttpGet]
    public async Task<IActionResult> SideTaskIndex(int id)
    {
        var sideTaskDtos = await _sideTaskService.GetListAsync();
        var res = sideTaskDtos.Where(x => x.Id == id);
        if (sideTaskDtos.Count != 0)
        {
            return View(res);
        }
        else 
        { 
            return RedirectToAction("CreateFirstSideTask",id);
        }
    }
    [HttpGet]
    public async Task<IActionResult> CreateFirstSideTask(int id)
    {
        var sideTask = new SideTaskCreateDto { Id = id,Name = "waddaw" };
        return View(sideTask);
    }

    public async Task<IActionResult> SideTaskCreate()
    {
        return View();
    }
    //будет отвечать за создание maintask и сохранение её в бд 
    [HttpPost]
    public async Task<IActionResult> SideTaskCreate(SideTaskCreateDto sideTaskCreateDto)
    {
        var sideTaskCreate = await _sideTaskService.CreateAsync(sideTaskCreateDto);
        return RedirectToAction(nameof(SideTaskIndex));
    }
    public async Task<IActionResult> SideTaskDelete(int id)
    {
        return View();
    }
}
