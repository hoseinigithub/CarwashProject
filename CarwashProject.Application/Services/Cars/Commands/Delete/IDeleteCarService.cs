using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Cars.Commands.Delete;

public interface IDeleteCarService
{
    Task<ResultDto> Execute(int id);
}
