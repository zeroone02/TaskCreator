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
    public async Task<IActionResult> SideTaskIndex(int id)
    {
        var sideTaskDtos = await _sideTaskService.GetListAsync();
        var res = sideTaskDtos.Where(x => x.Id == id);
        return View(res);
    }
    public async Task<IActionResult> SideTaskCreate(int id)
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
