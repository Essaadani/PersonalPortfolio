using PersonalPortfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalPortfolio.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
