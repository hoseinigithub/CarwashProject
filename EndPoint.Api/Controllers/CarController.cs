using CarwashProject.Application.Services.Cars.Commands.Create;
using CarwashProject.Application.Services.Cars.Commands.Delete;
using CarwashProject.Application.Services.Cars.Commands.Update;
using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Application.Services.Cars.Queries.GetCarById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IGetCarService _getCar;
    private readonly IGetCarByIdService _getCarById;
    private readonly ICreateCarService _createCar;
    private readonly IDeleteCarService _deleteCar;
    private readonly IUpdateCarService _updateCar;

    public CarController(IGetCarService getCar, IGetCarByIdService getCarById, ICreateCarService createCar, IDeleteCarService deleteCar, IUpdateCarService updateCar)
    {
        _getCar = getCar;
        _getCarById = getCarById;
        _createCar = createCar;
        _deleteCar = deleteCar;
        _updateCar = updateCar;
    }

    [HttpGet]

    public async Task<IActionResult> GetCar()
    {
        var car = await _getCar.Execute();
        return StatusCode(car.StatusCode, car);
    }

    [HttpGet]

    public async Task<IActionResult> GetCarById(int id)
    {
        var car = await _getCarById.Execute(id);
        return StatusCode(car.StatusCode, car);
    }

    [HttpPost]

    public async Task<IActionResult> CreateCar(CarDto carDto)
    {
        var car = await _createCar.Execute(carDto);
        return StatusCode(car.StatusCode, car);
    }

    [HttpDelete]

    public async Task<IActionResult> DeleteCar(int id)
    {
        var car = await _deleteCar.Execute(id);
        return StatusCode(car.StatusCode, car);
    }

    [HttpPut]

    public async Task<IActionResult> UpdateCar(CarDto carDto)
    {
        var car = await _updateCar.Execute(carDto);
        return StatusCode(car.StatusCode, car);
    }
}
