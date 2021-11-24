using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ById(string name)
        {
            var viewModel = new DataViewModel();
            viewModel.ParameterValue = name;
            this.ViewBag.Name = "Asen";
            return this.View(viewModel);
        }
    }
}
