
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = getCustomKey();
        var laptop = new Laptop();
        var model = laptop.getModel();
        var modelBrand = laptop.GetBrand();
        return Ok($"modelo: {model} e marca {modelBrand}");
    }
}
