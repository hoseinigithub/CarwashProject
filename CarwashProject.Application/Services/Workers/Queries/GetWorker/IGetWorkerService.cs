using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Workers.Queries.GetWorker;

public interface IGetWorkerService
{
    ResultDto<List<WorkerDto>> Execute();
}