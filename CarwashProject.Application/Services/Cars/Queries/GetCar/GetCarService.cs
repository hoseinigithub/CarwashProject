using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Queries.GetCar;

public class GetCarService : IGetCarService
{
    private readonly IAppDbContext _context;
    public GetCarService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<List<Car>>> Execute()
    {
        var carlist = await _context.Cars.ToListAsync();
        return new ResultDto<List<Car>>()
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = carlist
        };
    }
}
