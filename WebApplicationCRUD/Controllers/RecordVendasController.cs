﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCRUD.Services;
using WebApplicationCRUD.Services.Exception;



namespace WebApplicationCRUD.Controllers
{
    public class RecordVendasController : Controller
    {
        private readonly RecordVendasService _recordVendasService;
        public RecordVendasController(RecordVendasService recordVendasService)
        {
            _recordVendasService = recordVendasService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>PesquisaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _recordVendasService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        
        public async Task<IActionResult>PesquisaAgrupada(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _recordVendasService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }
    }
}