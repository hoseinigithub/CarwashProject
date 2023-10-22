using CarwashProject.Application.Services.Workers.Commands.GetWorker;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Workers.Commands.GetWorkerById;

public interface IGetWorkerByIdService
{
    Task<ResultDto<WorkerDto>> Execute(int id);
}