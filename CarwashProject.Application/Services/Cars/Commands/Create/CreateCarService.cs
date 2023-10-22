using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Create;

public class CreateCarService : ICreateCarService
{
    private readonly IAppDbContext _context;
    public CreateCarService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<CarDto>> Execute(CarDto carDto)
    {
        Car car = new Car()
        {
            Name = carDto.Name
        };
        await _context.Cars.AddAsync(car);
        _context.SaveChanges();

        return new ResultDto<CarDto>
        {
            IsSuccess = true,
            Message = "ماشین با موفقیت اضافه شد",
        };
    }
}
