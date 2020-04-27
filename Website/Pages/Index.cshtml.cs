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
        /// <summary>
        /// The items of the website
        /// </summary>
        public IEnumerable<IOrderItem> items { get; protected set; }


        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// logger item for the site
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// SearchTerms being searched
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }
        /// <summary>
        /// Categories being used
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }
        /// <summary>
        /// Minimum Calories being used
        /// </summary>
        [BindProperty]
        public int? CalMin { get; set; }
        /// <summary>
        /// Maximum Calories being used
        /// </summary>
        [BindProperty]
        public int? CalMax { get; set; }
        /// <summary>
        /// Minimum Price being used
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }
        /// <summary>
        /// Maximum Price being used
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }
        /// <summary>
        /// Gets a Complete Menu on start
        /// </summary>
        public void OnGet()
        {
            items = Menu.All;
        }
        /// <summary>
        /// Gets Menu with the Search requirements
        /// </summary>
        public void OnPost()
        {
            items = Menu.Search(SearchTerms);
            items = Menu.FilterByCategory(items, Categories);
            items = Menu.FilterByCalories(items, CalMin, CalMax);
            items = Menu.FilterByPrice(items, PriceMin, PriceMax);
        }

    }
}
