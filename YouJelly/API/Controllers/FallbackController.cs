using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Net.Mime;
// Whenever an HTTP request comes in, a new instance of the controller will be generated and the controller will handle the request.
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application;
using Application.Videos;
using Persistence;

namespace API.Controllers
{

    [AllowAnonymous]
    public class FallbackController : Controller
    {

        public IActionResult Index()
        {

            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");

        }

    }


}