using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocialMediaL.Models;

namespace SocialMediaL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<SocialMediaLinksOptions> _options;

        public HomeController(IOptions<SocialMediaLinksOptions> options)
        {
            _options = options;
        }

        [Route("/")]
        public IActionResult Index()
        {
            SocialMediaLinksOptions social = new SocialMediaLinksOptions()
            {
                Facebook = _options.Value.Facebook,
                Instagram = _options.Value.Instagram,
                Twitter = _options.Value.Twitter,
                Youtube = _options.Value.Youtube


            };
            return View(social);
        }
    }
}
