using LibraryManagementLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementMVC.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;
        private readonly IDataConnection _sql;

        public LibraryController(ILogger<LibraryController> logger, IDataConnection sql)
        {
            _logger = logger;
            _sql = sql;
        }
    }
}
