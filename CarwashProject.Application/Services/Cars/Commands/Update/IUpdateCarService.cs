using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Update;

public interface IUpdateCarService
{
    Task<ResultDto<CarDto>> Execute(CarDto carDto);
}
