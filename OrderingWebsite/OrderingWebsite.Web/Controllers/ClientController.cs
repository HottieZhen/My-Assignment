using System;
using Microsoft.AspNetCore.Mvc;

public class ClientController : Controller {
    public IActionResult Index()
    {
        return View();
    }
}
