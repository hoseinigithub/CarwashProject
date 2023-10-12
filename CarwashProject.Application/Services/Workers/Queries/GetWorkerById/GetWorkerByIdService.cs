using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Services.Workers.GetWorkerById
{
    public class GetWorkerByIdService : IGetWorkerByIdService
    {
        private readonly IAppDbContext _context;

        public GetWorkerByIdService(IAppDbContext context)
        {
            _context = context;
        }

        public ResultDto<WorkerDto> Execute(int id)
        {
            var worker = _context.Workers.Where(t => t.Id == id).Select(d => new WorkerDto
            {
                Id = d.Id,
                Age = d.Age,
                FirstName = d.FirstName,
                LastName = d.LastName,
                Bonus = d.Bonus,
                Salary = d.Salary
            }).FirstOrDefault();

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
}