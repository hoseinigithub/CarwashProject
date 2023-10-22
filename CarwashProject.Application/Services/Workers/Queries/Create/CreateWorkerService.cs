using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Workers.Queries.Create;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.CreateWorker;


public class CreateWorkerService : ICreateWorkerService
{
    private IAppDbContext _context;
    public CreateWorkerService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<CreateWorkerDto>> Execute(CreateWorkerDto worker)
    {
        Worker worker1 = new Worker()
        {
            FirstName = worker.FirstName,
            LastName = worker.LastName,
            Age = worker.Age,
        };

        await _context.Workers.AddAsync(worker1);
        _context.SaveChanges();


        return new ResultDto<CreateWorkerDto>
        {
            IsSuccess = true,
            Message = "کارگر شما با موفقیت اضافه شد",
            StatusCode = 200,
            Data = worker
        };
    }
}
