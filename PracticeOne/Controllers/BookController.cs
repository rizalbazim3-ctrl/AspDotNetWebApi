using Microsoft.AspNetCore.Mvc;
using PracticeOne.Models;
using PracticeOne.Services;

using System.Reflection.Metadata.Ecma335;

namespace PracticeOne.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        static BookService ser = new BookService();
        public BookService service = new BookService();
        [HttpGet]
        public IActionResult GetMethod(){

            return Ok(BookService.books);
        }

        [HttpPost]
        public IActionResult postmethod(Book data)
        {
            ser.add(data);
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult deletmethod( int id)
        {
            ser.dlt(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult editmethod(int id,Book data)
        {

            ser.edit(id, data);
            return Ok();
        }
 }
}