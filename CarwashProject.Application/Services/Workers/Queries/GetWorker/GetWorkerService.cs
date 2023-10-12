using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Workers.Queries.GetWorker;

public class GetWorkerService : IGetWorkerService
{
    private readonly IAppDbContext _context;

    public GetWorkerService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<List<WorkerDto>> Execute()
    {
        var worker = _context.Workers.Select(d => new WorkerDto
        {
            Id = d.Id,
            Age = d.Age,
            FirstName = d.FirstName,
            LastName = d.LastName,
            Bonus = d.Bonus,
            Salary = d.Salary
        }).ToList();

        return new ResultDto<List<WorkerDto>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = worker
        };
    }
}