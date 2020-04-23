using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> items { get; protected set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }

        public int? CalMin { get; set; }

        public int? CalMax { get; set; }

        public double? PriceMin { get; set; }

        public double? PriceMax { get; set; }

        public void OnGet(int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
        {
            this.CalMin = CalMin;
            this.CalMax = CalMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            items = Menu.Search(SearchTerms);
            items = Menu.FilterByCategory(items, Categories);
            items = Menu.FilterByCalories(items, CalMin, CalMax);
            items = Menu.FilterByPrice(items, PriceMin, PriceMax);
        }


    }
}
