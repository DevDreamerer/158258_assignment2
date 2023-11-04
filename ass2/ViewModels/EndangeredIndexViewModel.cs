using ass2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace ass2.ViewModels
{
    public class EndangeredIndexViewModel
    {
        public IPagedList<Endangered> Endangereds { get; set; }
        //public IQueryable<Endangered> Endangereds { get; set; }
        public string Search { get; set; }
        public IEnumerable<ContinentWithCount> CatsWithCount { get; set; }
        public string Continent { get; set; }
        public string SortBy { get; set; }
        public Dictionary<string, string> Sorts { get; set; }

        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
    }
    public class ContinentWithCount
    {
        public int ProductCount { get; set; }
        public string CategoryName { get; set; }
        public string CatNameWithCount
        {
            get
            {
                return CategoryName + " (" + ProductCount.ToString() + ")";
            }
        }
    }
}