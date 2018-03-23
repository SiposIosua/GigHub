using System;
using System.Data.Entity;
using GigHub.Core;
using GigHub.Core.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using GigHub.Persistance;

namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;


        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query = null)
        {
            var userId = User.Identity.GetUserId();

            var upcomingGigs = _unitOfWork.Gigs.GetUpcomingGigs(query);

            
            var attendances = _unitOfWork.Attendances.GetFutureAttendances(userId)
                .ToLookup(a => a.GigId);

            /*if (!String.IsNullOrWhiteSpace(query))
            {
                upcomingGigs = upcomingGigs
                    .Where(g =>
                        (g.Artist.Name.Contains(query)) ||
                        g.Genre.Name.Contains(query) ||
                        g.Venue.Contains(query));
            }*/

            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming Gigs",
                SearchTerm = query,
                Attendances = attendances
            };

            return View("Gigs", viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}