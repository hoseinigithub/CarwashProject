using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.Delete;

public class DeleteWorkerService : IDeleteWorkerService
{
    private IAppDbContext _context;
    public DeleteWorkerService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto> Execute(int id)
    {
        var worker = await _context.Workers.FindAsync(id);
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
            _context.Workers.Remove(worker);
            _context.SaveChanges();
        }


        return new ResultDto
        {
            IsSuccess = true,
            Message = "کارگر شما با موفقیت حذف شد",
            StatusCode = 200
        };


    }
}
