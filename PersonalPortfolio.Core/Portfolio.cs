using System;

namespace PersonalPortfolio.Core
{
    public class Portfolio : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
