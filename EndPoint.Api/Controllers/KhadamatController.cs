using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;
using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamatById;
using CarwashProject.Application.Services.Khadamats.Commands.Delete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarwashProject.Application.Services.Khadamats.Commands.Update;
using CarwashProject.Application.Services.Khadamats.Commands.Create;

namespace EndPoint.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KhadamatController : ControllerBase
    {
        private readonly IGetKhadamatService _getKhadamat;
        private readonly IGetKhadamatByIdService _getKhadamatById;
        private readonly IDeleteKhadamatService _deleteKhadamat;
        private readonly IUpdateKhadamatService _updateKhadamat;
        private readonly ICreateKhadamatService _createKhadamat;
        public KhadamatController(IGetKhadamatService getKhadamat, IGetKhadamatByIdService getKhadamatById, IDeleteKhadamatService deleteKhadamat, IUpdateKhadamatService updateKhadamat, ICreateKhadamatService createKhadamat)
        {
            _getKhadamat = getKhadamat;
            _getKhadamatById = getKhadamatById;
            _deleteKhadamat = deleteKhadamat;
            _updateKhadamat = updateKhadamat;
            _createKhadamat = createKhadamat;
        }

        [HttpGet]

        public IActionResult GetKhadamat()
        {
            var khadamat =  _getKhadamat.Execute();
            return Ok(khadamat);
        }

        [HttpGet]

        public async Task<IActionResult> GetKhadamatById(int id)
        {
            var khadamat = await _getKhadamatById.Execute(id);
            return StatusCode(khadamat.StatusCode, khadamat);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateKhadamatDto createKhadamatDto)
        {
            var khadamat = await _createKhadamat.Execute(createKhadamatDto);
            return StatusCode(khadamat.StatusCode, khadamat);
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteKhadamat(int id)
        {
            var khadamat = await _deleteKhadamat.Execute(id);
            return StatusCode(khadamat.StatusCode,khadamat);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateKhadamat(UpdateKhadamatDto updateKhadamatDto)
        {
            var khadamat = await _updateKhadamat.Execute(updateKhadamatDto);
            return StatusCode(khadamat.StatusCode, khadamat);
        }
    }
}
