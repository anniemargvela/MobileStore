using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MS.Application.UseCases.Mobiles.Queries.GetDetails;
using MS.Application.UseCases.Mobiles.Queries.GetMobilesList;
using MS.Domain.Entities;
using MS.Web.Models;

namespace MS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int? id, [FromQuery] GetMobilesListRequest request)
        {
            request.Page = id == null ? 1 : id.Value;
            var mobiles = await _mediator.Send(request);
            ViewBag.CurrentPage = request.Page;
            return View(mobiles);
        }

        public async Task<IActionResult> Details(int id)
        {
            var request = new GetDetailsRequest();
            request.ID = id;
            var mobile = await _mediator.Send(request);
            return View(mobile);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
