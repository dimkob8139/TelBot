using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot_ASP_Core.Models;

namespace TelegramBot_ASP_Core.Controllers
{
    public class HomeController : Controller
    {
       public string Index()
        {
            return "It`s my telega bot Domkobbot";
        }
    }
}
