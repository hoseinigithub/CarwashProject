using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Commands.Update;

public interface IUpdateKhadamatService
{
   Task<ResultDto<UpdateKhadamatDto>> Execute(UpdateKhadamatDto updateKhadamatDto);
}
