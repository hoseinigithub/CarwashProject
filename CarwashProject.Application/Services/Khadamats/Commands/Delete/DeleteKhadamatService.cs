using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;

namespace CarwashProject.Application.Services.Khadamats.Commands.Delete;

public class DeleteKhadamatService : IDeleteKhadamatService
{
    private readonly IAppDbContext _context;
    public DeleteKhadamatService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto> Execute(int id)
    {
        var khadamat = await _context.Khadamats.FindAsync(id);
        if (khadamat == null)
        {
            return new ResultDto()
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            _context.Khadamats.Remove(khadamat);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کارگر شما با موفقیت حذف شد",
                StatusCode = 200
            };
        }
    }
}
