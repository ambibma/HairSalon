using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HairSalon.Models;


namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
      private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                                .Include(client => client.Stylist)
                                .ToList();
      return View(model);
                            
    }
     public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (client.ClientId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    
      

    }
}