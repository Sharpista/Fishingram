using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PhotoAlbumController : ControllerBase
    {
        private readonly IPhotoAlbumRepository _photoAlbumRepository;
        private readonly IPhotoAlbumService _photoAlbumService;
        private readonly IMapper _mapper;

        public PhotoAlbumController(IPhotoAlbumRepository photoAlbumRepository, IPhotoAlbumService photoAlbumService, IMapper mapper)
        {
            _photoAlbumRepository = photoAlbumRepository;
            _photoAlbumService = photoAlbumService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoAlbumDTO>>> GetAllPhotoAlbums()
        {
            var photoAlbums = _mapper.Map<IEnumerable<PhotoAlbumDTO>>(await _photoAlbumService.GetAll());

            return Ok(photoAlbums);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PhotoAlbumDTO>> GetPhotoAlbumById(long id)
        {
            var photoAlbum = _mapper.Map<PhotoAlbumDTO>(await _photoAlbumService.GetById(id));
            return Ok(photoAlbum);
        }
        [HttpPost]
        public async Task<ActionResult<PhotoAlbumDTO>> AddPhotoAlbum(PhotoAlbumDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var photoAlbum = _mapper.Map<PhotoAlbum>(dto);

            await _photoAlbumService.Add(photoAlbum);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<PhotoAlbumDTO>> UpdatePhotoAlbum(long id, PhotoAlbumDTO dto)
        {
            if (id != dto.Id) return BadRequest();
            var photoAlbum = _mapper.Map<PhotoAlbum>(dto);
            await _photoAlbumService.Put(photoAlbum);

            return Ok(photoAlbum);
        }
        [HttpDelete]
        public async Task<ActionResult<PhotoAlbumDTO>> DeletePhotoAlbum(long id)
        {
            var photoAlbum =  _mapper.Map<PhotoAlbumDTO>(await _photoAlbumService.GetById(id));
            if (photoAlbum == null) return NotFound();
            await _photoAlbumService.Delete(photoAlbum.Id);

            return Ok();
        }
       
    }
}
