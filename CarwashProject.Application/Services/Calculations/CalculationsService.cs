using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Calculations;

public class CalculationsService : ICalculations
{
    private readonly IAppDbContext _context;
    public CalculationsService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto> Execute(int id)
    {
        var worker =await _context.Workers.FindAsync(id);
        if (worker == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            worker.Salary = worker.Salary * 0.3m + worker.Bonus;
        }
        return new ResultDto
        {
            IsSuccess = true,
            Message = "عملیات با موفقیت انجام شد",
            StatusCode = 200
        };
    }
}
