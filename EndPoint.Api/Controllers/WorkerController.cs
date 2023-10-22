using CarwashProject.Application.Services.Workers.Commands.GetWorker;
using CarwashProject.Application.Services.Workers.Commands.GetWorkerById;
using CarwashProject.Application.Services.Workers.Queries.Create;
using CarwashProject.Application.Services.Workers.Queries.CreateWorker;
using CarwashProject.Application.Services.Workers.Queries.Delete;
using CarwashProject.Application.Services.Workers.Queries.Update;
using Microsoft.AspNetCore.Mvc;

namespace CarwashProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IGetWorkerService _getWorker;
        private readonly IGetWorkerByIdService _getWorkerById;
        private readonly ICreateWorkerService _createWorker;
        private readonly IDeleteWorkerService _deleteWorker;
        private readonly IUpdateWorkerService _updateWorker;

        public WorkerController(IGetWorkerService getWorker, IGetWorkerByIdService getWorkerById, ICreateWorkerService createWorker, IDeleteWorkerService deleteWorker, IUpdateWorkerService updateWorker)
        {
            _getWorker = getWorker;
            _getWorkerById = getWorkerById;
            _createWorker = createWorker;
            _deleteWorker = deleteWorker;
            _updateWorker = updateWorker;
        }

        [HttpGet]
        public async Task<IActionResult> GetWorker()
        {
            var worker = await _getWorker.Execute();
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkerById([FromQuery] int id)
        {
            var worker = await _getWorkerById.Execute(id);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpPost]

        public async Task<IActionResult> CreateWorker(CreateWorkerDto createWorker)
        {
            var worker = await _createWorker.Execute(createWorker);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteWorker(int id)
        {
            var worker = await _deleteWorker.Execute(id);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateWorker(UpdateWorkerDto updateWorkerDto)
        {
            var worker =await _updateWorker.Execute(updateWorkerDto);
            return StatusCode(worker.StatusCode); //استاتوس کد چه ربطی به ای سینک داره؟
        }
    }
}