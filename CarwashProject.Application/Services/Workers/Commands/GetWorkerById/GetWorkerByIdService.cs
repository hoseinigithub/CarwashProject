using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Workers.Commands.GetWorker;
using CarwashProject.Common.Dto.Result;
using Microsoft.EntityFrameworkCore;

namespace CarwashProject.Application.Services.Workers.Commands.GetWorkerById;

public class GetWorkerByIdService : IGetWorkerByIdService
{
    private readonly IAppDbContext _context;

    public GetWorkerByIdService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<WorkerDto>> Execute(int id)
    {
        var worker = await _context.Workers.Where(t => t.Id == id).Select(d => new WorkerDto
        {
            Id = d.Id,
            Age = d.Age,
            FirstName = d.FirstName,
            LastName = d.LastName,
            Bonus = d.Bonus,
            Salary = d.Salary
        }).FirstOrDefaultAsync();

        if (worker == null)
        {
            return new ResultDto<WorkerDto>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }

        return new ResultDto<WorkerDto>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = worker
        };
    }
}