using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;

public class GetKhadamatService : IGetKhadamatService
{
    private readonly IAppDbContext _context;
    public GetKhadamatService(IAppDbContext context)
    {
        _context = context;
    }
    public ResultDto<List<KhadamatDto>> Execute()
    {
        var khadamat = _context.Khadamats.Select(t => new KhadamatDto
        {
            Id = t.Id,
            Name = t.Name,
            Price = t.Price,
        }).ToList();

        return new ResultDto<List<KhadamatDto>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = khadamat
        };
    }
}
