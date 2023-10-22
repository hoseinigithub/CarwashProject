using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Create;

public interface ICreateCarService
{
    Task<ResultDto<CarDto>> Execute(CarDto carDto);
}
