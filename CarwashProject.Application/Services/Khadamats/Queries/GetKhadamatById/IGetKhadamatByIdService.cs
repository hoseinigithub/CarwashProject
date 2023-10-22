using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Queries.GetKhadamatById;

public interface IGetKhadamatByIdService
{
   Task<ResultDto<KhadamatDto>> Execute(int id);
}
