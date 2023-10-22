using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Update;

public class UpdateCarService : IUpdateCarService
{
    private readonly IAppDbContext _context;
    public UpdateCarService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<CarDto>> Execute(CarDto carDto)
    {
        var car = await _context.Cars.FindAsync(carDto.Id);
        if (car == null)
        {
            return new ResultDto<CarDto>()
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            car.Name = carDto.Name;
            _context.SaveChanges();
        }
        return new ResultDto<CarDto>()
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = carDto
        };
    }
}
