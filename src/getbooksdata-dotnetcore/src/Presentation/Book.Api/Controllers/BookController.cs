using Core.Domain.Entities;
using Core.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Book.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("{id}", Name = "GetBook")]
        [ProducesResponseType(typeof(Book1), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Book1>> GetBook(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return NotFound();
            var book = await _service.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpDelete("{id}", Name = "DeleteBook")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBook(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return NotFound();
            await _service.DeleteBook(id);
            return Ok();
        }

    }


}
