using AutoMapper;
using Bloger.Core;
using Bloger.Core.Entities;
using Bloger.Core.Spec;
using Bloger.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bloger.Controllers
{

    public class CategoriesController : ApiBaseController
    {
        private readonly IGenericRepository<Category> _categoryDbcontext;
        private readonly IMapper _mapper;

        public CategoriesController(IGenericRepository<Category> categoryDbcontext, IMapper mapper)
        {
            _categoryDbcontext = categoryDbcontext;
            _mapper = mapper;
        }

        //Get All Categories 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAllCategories()
        {
            var spec = new CategoryWithDataSpec();
            var result = await _categoryDbcontext.GetAllWithSpecAsync(spec);
            var categories = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(result);
            return Ok(categories);
        }
        // Get Category By Id

        [HttpGet("id")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryById(int id)
        {
            var spec = new CategoryWithDataSpec(id);
            var result = await _categoryDbcontext.GetByIdWithSpecAsync(spec);

            var categories = _mapper.Map<Category, CategoryDTO>(result);
            return Ok(categories);
        }

    }
}
