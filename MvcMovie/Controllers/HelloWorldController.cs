﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<HelloWorld>/
        public string Index()
        {
            return "this is my default action...";
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTries = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTries is : {numTries}");
        }
    }
}