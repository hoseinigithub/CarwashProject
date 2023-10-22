using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Workers.Commands.GetWorker;

public interface IGetWorkerService
{
    Task<ResultDto<List<WorkerDto>>> Execute();
}