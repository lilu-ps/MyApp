using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Models;
using MyApp.Services;
using MyApp.Filters;
using MyApp.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.Controllers
{
    public class StatementModelsController : Controller
    {

        private readonly IStatementService statementService;

        public IActionResult Index(StatementFilter statementFilter = null)
        {
            var statementList = statementService.GetStatementList(statementFilter);
            return View("~/Views/Index.cshtml", statementList);
        }


        public StatementModelsController(IStatementService statementService)
        {
            this.statementService = statementService;
        }

        public IActionResult UpdateStatementGrid([FromQuery] StatementFilter statementFilter = null)
        {
            var statementList = statementService.GetStatementList(statementFilter);
            return PartialView("~/Views/GridView.cshtml", statementList);
        }

        [HttpGet]
        public IActionResult GoToStatement(long Id)
        {
            var statementModel = statementService.GetStatement(Id);
            return View("~/Views/Statement.cshtml", statementModel);
        }


    }
}
