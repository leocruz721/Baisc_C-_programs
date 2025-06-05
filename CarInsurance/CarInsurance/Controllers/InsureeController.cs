using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        // GET: Insuree
        public ActionResult Index()
        {
            return View();
        }
    }
}
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(Insuree insuree)
{
    if (ModelState.IsValid)
    {
        insuree.Quote = CalculateQuote(insuree);
        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}

private decimal CalculateQuote(Insuree insuree)
{
    decimal quote = 50m;

    // Age-based adjustment
    var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
    if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

    if (age <= 18)
        quote += 100;
    else if (age >= 19 && age <= 25)
        quote += 50;
    else
        quote += 25;

    // Car year adjustment
    if (insuree.CarYear < 2000)
        quote += 25;
    else if (insuree.CarYear > 2015)
        quote += 25;

    // Make/model adjustment
    if (insuree.CarMake.ToLower() == "porsche")
    {
        quote += 25;
        if (insuree.CarModel.ToLower() == "911 carrera")
            quote += 25;
    }

    // Speeding tickets
    quote += insuree.SpeedingTickets * 10;

    // DUI adjustment
    if (insuree.DUI)
        quote += quote * 0.25m;

    // Coverage adjustment
    if (insuree.CoverageType)
        quote += quote * 0.50m;

    return quote;
}

public ActionResult Admin()
{
    var insurees = db.Insurees.ToList();
    return View(insurees);
}

