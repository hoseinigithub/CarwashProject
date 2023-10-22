using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;
using CarwashProject.Common.Dto.Result;
using Microsoft.EntityFrameworkCore;

namespace CarwashProject.Application.Services.Khadamats.Queries.GetKhadamatById;

public class GetKhadamatByIdService : IGetKhadamatByIdService
{
    private readonly IAppDbContext _context;
    public GetKhadamatByIdService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<KhadamatDto>> Execute(int id)
    {
        var khadamat = await _context.Khadamats.Where(d => d.Id == id).Select(d => new KhadamatDto
        {
            Id = d.Id,
            Name = d.Name,
            Price = d.Price,
        }).FirstOrDefaultAsync();

        if (khadamat == null)
        {
            return new ResultDto<KhadamatDto>()
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }

        return new ResultDto<KhadamatDto>()
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = khadamat
        };
    }
}
