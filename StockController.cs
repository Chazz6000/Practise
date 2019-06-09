using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocker.Domain.Models;
using Stocker.Persistence;

namespace Stocker.API.Controllers
{

 

    public class StockController : Controller
    {
        private readonly StockerDbContext context;

        public StockController(StockerDbContext Context)
        {
            context = Context;
        }



        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Details(int? stockId)
        {
            if(stockId != null )
            {
                Stock stock = context.Stock.Where(s => s.StockId == stockId).FirstOrDefault();
                //Save stock data to a list.
                var model = context.Stock.ToList();
                return View("Details");
            }
            else
            {
                
                return View("ErrorViewModel");
            }




        }
        [HttpPost]
        public IActionResult Create(Stock s)
        { 

            if(ModelState.IsValid)
            {
                context.Stock.Add(s);
                context.SaveChanges();
                return View("Create");
            }
            else
            {

                return View("ErrorViewModel");
            }

            
        }


        public IActionResult Delete(Stock s)
        {
            context.Stock.Remove(s);

            return View("Index");
        }


    }
}