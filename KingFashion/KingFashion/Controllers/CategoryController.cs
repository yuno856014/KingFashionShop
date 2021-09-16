﻿using KingFashion.Commons;
using KingFashion.Helpers;
using KingFashion.Models.Categorys;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/Category/Get")]
        public async Task<IActionResult> Get()
        {
            var data = await ApiHelper.HttpGet<List<Category>>(@$"{Common.ApiUrl}Category");
            return Ok(data);
        }
        [HttpGet]
        [Route("/Category/Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await ApiHelper.HttpGet<Category>(@$"{Common.ApiUrl}Category/{id}");
            return Ok(data);
        }
        [HttpPost]
        [Route("/Category/Create")]
        public async Task<IActionResult> Create([FromBody] CreateCategory model)
        {
            return Ok(await ApiHelper.HttpPost<CreateCategoryResult>(@$"{Common.ApiUrl}Category", "POST", model));
        }
        [HttpPut]
        [Route("/Category/Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCategory model)
        {
            return  Ok(await ApiHelper.HttpPost<UpdateCategoryResult>(@$"{Common.ApiUrl}Category", "PUT", model));
        }
    }
}
