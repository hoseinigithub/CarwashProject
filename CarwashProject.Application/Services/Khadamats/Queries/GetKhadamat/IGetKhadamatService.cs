using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;

public interface IGetKhadamatService
{
    ResultDto<List<KhadamatDto>> Execute();
}
