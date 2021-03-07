using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecordManager.Models;
using RecordManager.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace RecordManager.Controllers
{
//class for Employee Controller
public class EmployeeController:Controller
{
     private readonly RMSDbContext  db;


        public EmployeeController(RMSDbContext _db)
        {
            db = _db;
        }
    public ActionResult Index(){
        var employees = db.Employees.ToList();
        return View(employees);

    }
    [Authorize]
    [HttpGet]
     public ActionResult Add()
    {
       return View();
    }
    [Authorize]
    [HttpPost]
    public ActionResult Add([FromForm]Employee employee)
    {
        db.Employees.Add(employee);
         db.SaveChanges();
       return RedirectToAction(nameof(Index));
    }
    [Authorize]
    [HttpGet]
     public ActionResult Edit([FromQuery]int id)
    {
        var employee = db.Employees.Find(id);
       return View(employee);
    }
    [Authorize]
    [HttpPost]
    public ActionResult Edit([FromForm]Employee employee)
    {
        db.Employees.Attach(employee);
       db.Employees.Update(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    }
    [Authorize]
    [HttpGet]
     public ActionResult Delete([FromQuery]int id)
    {
        var employee = db.Employees.Find(id);
       return View(employee);
    }
    [Authorize]
    [HttpPost]
    public ActionResult Delete([FromForm]Employee employee)
    {
        db.Employees.Attach(employee);
        db.Employees.Remove(employee);
         db.SaveChanges();
       return RedirectToAction(nameof(Index));
    }

}
}