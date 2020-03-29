using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Core;
using PersonalPortfolio.Infrastructure.Data.UnitOfWork;
using PersonalPortfolio.ViewModels;

namespace PersonalPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Portfolio> _portfolio;
        private readonly IUnitOfWork<Owner> _owner;

        public HomeController(IUnitOfWork<Portfolio> portfolio,
            IUnitOfWork<Owner> owner)
        {
            _portfolio = portfolio;
            _owner = owner;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Portfolios = _portfolio.Entity.GetAll().ToList(),
                Owner = _owner.Entity.GetAll().FirstOrDefault()
            };

            return View(homeViewModel);
        }
    }
}