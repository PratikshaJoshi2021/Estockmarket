﻿using Microsoft.AspNetCore.Http;
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
    public class BuyController : ControllerBase
    {
        EstockMarketContext db;
        public BuyController(EstockMarketContext _db)
        {
            db = _db;
        }
        [HttpGet]
        //user can get the details of stock start end date
        public IEnumerable<TblUser> GetUsers()
        {
            return db.TblUsers;
        }
        [HttpPost]
        //company can add the stock
        public string Post([FromBody] TblUser tblUser)
        {
            db.TblUsers.Add(tblUser);
            db.SaveChanges();
            return "success";
        }
    }
}
