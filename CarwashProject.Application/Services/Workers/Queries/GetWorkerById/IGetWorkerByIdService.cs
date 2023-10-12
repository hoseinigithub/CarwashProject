using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Services.Workers.GetWorkerById;

/// <summary>
///
/// </summary>
public interface IGetWorkerByIdService
{
    ResultDto<WorkerDto> Execute(int id);
}