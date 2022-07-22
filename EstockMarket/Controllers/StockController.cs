using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstockMarket.Models;

namespace EstockMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        EstockMarketContext db;
        public StockController(EstockMarketContext _db)
        {
            db = _db;
        }
        [HttpGet]
        //user can get the details of stock start end date
        public IEnumerable<TblStock> GetStocks()
        {
            return db.TblStocks;
        }
        [HttpPost]
        //company can add the stock
        public string Post([FromBody] TblStock tblStock)
        {
            db.TblStocks.Add(tblStock);
            db.SaveChanges();
            return "success";
        }
    }
}
