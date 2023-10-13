using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Services.Workers.GetWorkerById;
using Microsoft.AspNetCore.Mvc;

namespace CarwashProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IGetWorkerService _getWorker;
        private readonly IGetWorkerByIdService _getWorkerById;

        public WorkerController(IGetWorkerService getWorker, IGetWorkerByIdService getWorkerById)
        {
            _getWorker = getWorker;
            _getWorkerById = getWorkerById;
        }

        [HttpGet]
        public IActionResult GetWorker()
        {
            var userlist = _getWorker.Execute();
            return Ok(userlist);
        }
        /// <summary>
        /// salam2
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetWorkerById([FromQuery] int id)
        {
            var result = _getWorkerById.Execute(id);
            return Ok(result);
        }
    }
}