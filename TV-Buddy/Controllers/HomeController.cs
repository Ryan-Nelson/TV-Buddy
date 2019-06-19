using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TV_Buddy.Models;

namespace TV_Buddy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


/*        public async Task<IActionResult> PrefectSize(int? id)
            {
                var multapierForSize = 0.84;
                return public Rooms DistanceFromSeat * multapierForSize;
        }
    */

/*        public IActionResult QualityOfTV(Rooms _DistanceFromSeat)
        {
            double totalQualityOfTV = _DistanceFromSeat * .84;

        }*/


/*        public IActionResult QualityOfTV(Rooms _xbo)
        {
            double totalQualityOfTV = _DistanceFromSeat * .84;

        }*/
/*        public IActionResult QualityOfTV(bool _Xbox , bool _bluray, string _Quality)
        {
            if (_Xbox == false && _bluray != false)
            {
                _Quality = "4k";

            }
            else if (_Xbox != false && _bluray == false)
            {
                _Quality = "4k";

            }
            else if (_Xbox != false && _bluray != false)
            {
                _Quality = "4k";

            }
            else if (_Xbox == false && _bluray == false)
            {
                _Quality = "1080p";

            }
            string currentQuality = _Quality;

            return View(currentQuality);
        }*/
