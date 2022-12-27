using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.AccessControl;
using VefatcomAPI.Application.Repositories;
using VefatcomAPI.Application.RequestParameters;
using VefatcomAPI.Application.ViewModels.Deads;
using VefatcomAPI.Domain.Entities;

namespace VefatcomAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeadController : ControllerBase
    {
        readonly private IDeadReadRepository _deadReadRepository;
        readonly private IDeadWriteRepository _deadWriteRepository;


        public DeadController(IDeadReadRepository deadReadRepository, IDeadWriteRepository deadWriteRepository)
        {
            _deadReadRepository = deadReadRepository;
            _deadWriteRepository = deadWriteRepository;

        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]Pagination pagination)
        {
            
            var totalCount = _deadReadRepository.GetAll(false).Count();
         var deads = _deadReadRepository.GetAll(false).Skip(pagination.Page * pagination.Size).Take(pagination.Size).Select(x => new
            {

                x.Id,
                x.DeadName,
                x.DeadLastName,
                x.DeadDate,
                x.DeadAge,
                x.CreatedDate,
                x.UpdatedDate
            }).ToList();
            return Ok(new {totalCount,deads});
           

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {

            return Ok(_deadReadRepository.GetByIdAsync(id, false));

        }
        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Dead model)
        {


            await _deadWriteRepository.AddAsync(new()
            {
                DeadName = model.DeadName,
                DeadLastName = model.DeadUsername,
                DeadAge = model.DeadAge,
                DeadDate = model.DeadDate
               
            });
            await _deadWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);


        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Deads model)
        {
            Dead dead = await _deadReadRepository.GetByIdAsync(model.Id);


            dead.DeadName = model.DeadName;
            dead.DeadLastName = model.DeadUsername;
            dead.DeadAge = model.DeadAge;
            

            await _deadWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _deadWriteRepository.RemoveAsync(id);
            await _deadWriteRepository.SaveAsync();
            return Ok();
        }

    }
}
