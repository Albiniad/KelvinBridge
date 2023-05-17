using KelvinBridge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using KelvinBridge.Repository;

namespace KelvinBridge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<BridgeModel> _variantsRepository;

        public HomeController()
        {
            _variantsRepository = new VariantsRepository();
        }

        public IActionResult Index()
        {
            ViewBag.Variants = _variantsRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult CalculateVoltage(string RMM, string RNN, string Rm, string Rn)
        {
            var voltage = 0d;

            if (double.TryParse(RMM?.Replace(".", ","), out var _RM) &&
                double.TryParse(RNN?.Replace(".", ","), out var _RN) &&
                double.TryParse(Rm?.Replace(".", ","), out var _Rm) &&
                double.TryParse(Rn?.Replace(".", ","), out var _Rn)) voltage = (_RM / _RN) * (_Rn - _Rm);

            return Json(voltage);
        }

        [HttpPost]
        public IActionResult CalculateResult(string Ra, string RM, string RN)
        {
            Random random = new Random();
            double randomNumber = random.NextDouble() / 10;
            double rx = 0d;

            if (double.TryParse(Ra.Replace(".", ","), out var _Ra) &&
                double.TryParse(RM.Replace(".", ","), out var _RM) &&
                double.TryParse(RN.Replace(".", ","), out var _RN))
            {
                rx = _Ra * (_RN / _RM) * (1 + randomNumber);
            }

            return Json(rx);
        }
    }
}