using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapi.Framework;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotingController : Controller
    {
        private readonly IVotingService _votingService;

        public VotingController(IVotingService votingService)
        {
            _votingService = votingService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: api/PaymentDetail
        [HttpGet]
        public ActionResult<PostData> GetAll(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var (posts, total, totalDisplay) = _votingService.GetData( pageIndex, pageSize, searchText,sortText);
            if (posts == null)
            {
                return NotFound();
            }

            return Ok(new PostData{PostDtos = posts,TotalCount = total,TotalDisplay = totalDisplay});
        }



    }
}