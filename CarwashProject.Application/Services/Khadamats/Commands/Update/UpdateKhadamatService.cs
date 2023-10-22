using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Commands.Update;

public class UpdateKhadamatService : IUpdateKhadamatService
{
    private readonly IAppDbContext _context;
    public UpdateKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<UpdateKhadamatDto>> Execute(UpdateKhadamatDto updateKhadamatDto)
    {
        var khadamat = await _context.Khadamats.FindAsync(updateKhadamatDto.Id);

        if (khadamat == null)
        {
            return new ResultDto<UpdateKhadamatDto>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };

        }
        else
        {
            khadamat.Name = updateKhadamatDto.Name;
            khadamat.Price = updateKhadamatDto.Price;
        }
        _context.SaveChanges();
        return new ResultDto<UpdateKhadamatDto>
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = updateKhadamatDto
        };
    }
}
