using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Queries.GetCarById;

public interface IGetCarByIdService
{
   Task<ResultDto<Car>> Execute(int id);
}
