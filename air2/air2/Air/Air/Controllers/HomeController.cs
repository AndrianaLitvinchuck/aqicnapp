using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Air.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Air.Models.DB;
using Air.Models.DTO;
using Air.Models.Helpers;

namespace Air.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Storage _storage;
        private readonly XLSFileCreator _xls;

        public HomeController(
            ILogger<HomeController> logger,
            DbContextOptions<AppCtx> options)
        {
            _logger = logger;
            _storage = new Storage(options);
            _xls = new XLSFileCreator(options);
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var dto = new DashboardDTO();
                dto.Cities = await _storage.GetCitiesAsync();
                dto.Data = await _storage.GetDataAsync();

                return View(dto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Route("getexcelreport/{id?}")]
        public IActionResult GetExcelReport(int id)
        {
            try
            {                
                _xls.WriteToXls(_storage.GetCity(id));
                var fileName = $"ImportFromDT.xlsx";
                var filepath = $"{fileName}";
                var mimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
                return File(fileBytes, mimeType, fileName);

            }
            catch (Exception)
            {
               return  BadRequest();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
