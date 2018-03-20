using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using interview.Data;
using interview.Models;
using Microsoft.AspNetCore.Mvc;

namespace interview.Controllers
{
    [Route("api/[controller]")]
    public class ArraycalcController : Controller
    {
        private readonly IProductRepository _repo;
        public ArraycalcController(IProductRepository repo)
        {
            _repo = repo;

        }
        [HttpGet("reverse")]
        public IActionResult Reverse([FromQuery]Params param)
        {
            //sorting
            var sortedNums = _repo.SortingNumber(param.ProductIds);
            return Ok(sortedNums);
        }

        [HttpGet("deletepart")]
        public IActionResult Delete([FromQuery] Params param)
        {
            try
            {
                //check if the position is validated
                if (param.Position[0] > param.ProductIds.Length || param.Position[0] <= 0)
                    return BadRequest("Please enter a correct value.");

                var list = _repo.DeleteProducts(param.ProductIds, param.Position);
                return Ok(list);
            }
            catch (Exception)
            {
                return BadRequest("Unexpected error occurred");
            }
        }
    }
}