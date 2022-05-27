using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Business.Abstract;
using Proje.Entity.DTOs;
using Proje.Entity.Models;

namespace Proje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Sparepart> _service;

        public SparePartsController(IMapper mapper, IService<Sparepart> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var spareparts = await _service.GetAllAsync();
            var sparepartDtos = _mapper.Map<List<SparepartDto>>(spareparts.ToList());
            return Ok(sparepartDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sparepart = await _service.GetByIdAsync(id);
            var sparepartDto = _mapper.Map<SparepartDto>(sparepart);
            return Ok(sparepartDto);
        }
        [HttpPost]
        public async Task<IActionResult> Save(SparepartDto sparepartDto)
        {
            var sparepart = await _service.AddAsync(_mapper.Map<Sparepart>(sparepartDto));
            var sparepartsDto = _mapper.Map<SparepartDto>(sparepart);
            return Ok(sparepartsDto);
        }
        [HttpPut]
        public async Task<IActionResult> Update(SparepartDto sparepartDto)
        {
            await _service.UpdateAsync(_mapper.Map<Sparepart>(sparepartDto));
            return Ok(sparepartDto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var sparepart = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(sparepart);
            return Ok(sparepart);
        }
    } 
}
