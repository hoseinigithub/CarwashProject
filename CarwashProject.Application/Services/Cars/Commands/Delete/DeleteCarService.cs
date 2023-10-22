using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Delete;

public class DeleteCarService : IDeleteCarService
{
    private readonly IAppDbContext _context;
    public DeleteCarService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto> Execute(int id)
    {
        var car = await _context.Cars.FindAsync(id);
        if (car == null)
        {
            return new ResultDto()
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        return new ResultDto()
        {
            IsSuccess = true,
            Message = "با موفقیت حذف شد",
            StatusCode = 200
        };
    }
}
