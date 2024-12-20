using LoansAPI.Dto;
using LoansAPI.DtoMapper;
using LoansLib.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILogger<LoanController> _logger;
        private readonly ILoanService _loanService;

        public LoanController(ILogger<LoanController> logger, ILoanService loanService)
        {
            _logger = logger;
            _loanService = loanService;
        }

        // POST api/<LoanController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoanRequestDto requestDto)
        {
            try
            {
                var requetModel = requestDto.ToModel();
                var responeModel = await _loanService.CalcLoanAsync(requetModel);
                var responeDto = responeModel.FromModel();
                return Ok(responeDto);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex.Message);
                return BadRequest(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, new { Message = ex.Message, Details = ex.Message });
            }
        }
    }
}
