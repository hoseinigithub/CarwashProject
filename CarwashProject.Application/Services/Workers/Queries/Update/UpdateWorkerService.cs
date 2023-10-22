using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.Update;

public class UpdateWorkerService : IUpdateWorkerService
{
    private IAppDbContext _context;
    public UpdateWorkerService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<UpdateWorkerDto>> Execute(UpdateWorkerDto updateWorkerDto)
    {
        var worker = await _context.Workers.FindAsync(updateWorkerDto.Id);
        if (worker == null)
        {
            new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            worker.FirstName = updateWorkerDto.FirstName;
            worker.LastName = updateWorkerDto.LastName;
            worker.Age = updateWorkerDto.Age;
            worker.Bonus = updateWorkerDto.Bonus;
            worker.Salary = updateWorkerDto.Salary;
        }

        _context.SaveChanges();
        return new ResultDto<UpdateWorkerDto>
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = updateWorkerDto
        };
    }
}
