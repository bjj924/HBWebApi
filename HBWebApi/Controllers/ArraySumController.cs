using HBWebApi.Domain.ArrayLogic;
using HBWebApi.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HBWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArraySumController : ControllerBase
    {
        private readonly ICalculateArray _calculateArray;

        public ArraySumController(ICalculateArray calculateArray)
        {
            _calculateArray = calculateArray;
        }

        [Route("GetArraySum")]
        [HttpGet]
        public async Task<ActionResult<CharArrayResponse>> GetArraySum([FromQuery] CharArray numbers)
        {
            var result = await _calculateArray.Calculate(numbers);

            return result;
        }
    }
}

