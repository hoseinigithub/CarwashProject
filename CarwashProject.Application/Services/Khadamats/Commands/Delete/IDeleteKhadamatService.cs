using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Commands.Delete;

public interface IDeleteKhadamatService
{
   Task<ResultDto> Execute(int id);
}
