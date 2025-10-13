using Computers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Computers.Controllers;

public class ComputersOnSaleController : Controller
{
    private IComputersRepo _computersRepo;

    public IActionResult Contact()
    {
        return View();
    }

    // GET: ComputersOnSaleController
    public ActionResult GetAll()
    {
        _computersRepo = new FileComputersRepo();
        var computers = _computersRepo.Computers;
        return View(computers);
    }

    [HttpGet]
    public IActionResult AddComputer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddComputer(Computer computer)
    {
        if (ModelState.IsValid)
        {
            _computersRepo = new FileComputersRepo();
            _computersRepo.AddComputer(computer);
            return RedirectToAction("GetAll");
        }
        return View();
    }

    public IActionResult DeleteComputer(int id)
    {
        _computersRepo = new FileComputersRepo();
        _computersRepo.RemoveComputer(id);
        return RedirectToAction("GetAll");
    }

    [HttpGet]
    public IActionResult EditComputer(int id)
    {
        _computersRepo = new FileComputersRepo();
        var computerToEdit = _computersRepo.GetComputer(id);
        if (computerToEdit is not null)
        {
            return View(computerToEdit);
        }
        return RedirectToAction("GetAll");
    }

    [HttpPost]
    public IActionResult EditComputer(Computer computer)
    {
        if (ModelState.IsValid)
        {
            _computersRepo = new FileComputersRepo();
            _computersRepo.UpdateComputer(computer);
            return RedirectToAction("GetAll");
        }
        return View();
    }
}