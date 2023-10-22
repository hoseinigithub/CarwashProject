using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using Microsoft.EntityFrameworkCore;

namespace CarwashProject.Application.Services.Workers.Commands.GetWorker;

public class GetWorkerService : IGetWorkerService
{
    private readonly IAppDbContext _context;

    public GetWorkerService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<List<WorkerDto>>> Execute()
    {
        var worker = await _context.Workers.Select(d => new WorkerDto
        {
            Id = d.Id,
            Age = d.Age,
            FirstName = d.FirstName,
            LastName = d.LastName,
            Bonus = d.Bonus,
            Salary = d.Salary
        }).ToListAsync();

        return new ResultDto<List<WorkerDto>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = worker
        };
    }
}