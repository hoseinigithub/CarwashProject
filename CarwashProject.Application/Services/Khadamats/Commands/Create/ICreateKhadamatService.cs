using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Commands.Create;


public interface ICreateKhadamatService
{
   Task<ResultDto<CreateKhadamatDto>> Execute(CreateKhadamatDto createKhadamatDto);
}
