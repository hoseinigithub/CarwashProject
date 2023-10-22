using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;

namespace CarwashProject.Application.Services.Khadamats.Commands.Create;

public class CreateKhadamatService : ICreateKhadamatService
{
    private readonly IAppDbContext _context;
    public CreateKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<CreateKhadamatDto>> Execute(CreateKhadamatDto createKhadamatDto)
    {
        Khadamat khadamat = new Khadamat()
        {
            Name = createKhadamatDto.Name,
            Price = createKhadamatDto.Price,
        };
        await _context.Khadamats.AddAsync(khadamat);
        _context.SaveChanges();

        return new ResultDto<CreateKhadamatDto>
        {
            IsSuccess = true,
            Message = "ماشین با موفقیت اضافه شد",
            StatusCode = 200,
            Data = createKhadamatDto
        };
    }
}
