﻿using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;
using System.Collections.Generic;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){Id = 0, Author="Emily Dickinson", Description="The brain is wider than the sky", Title="Inspirational"  },
            new Quote(){Id = 1, Author="Richard Bach", Description="True love stories never have endings", Title="Love Stories"  }
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        [HttpPost]
        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }

        [HttpPut("{id}")]
        public void Put(int id, Quote quote)
        {
            _quotes[id] = quote;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}
