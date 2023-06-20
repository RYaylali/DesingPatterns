using DP.ChainOfResponsibilty.ChainOfResponsiblty;
using DP.ChainOfResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;

namespace DP.ChainOfResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessVM model)
        {
            Employee treasurer= new Treasurer();
            Employee managerAsisstant= new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirectory = new AreaDirectory();
            //Zincir halkasındaki sonraki onaylayıcıcılar belirlenir
            treasurer.SetNextApprover(managerAsisstant);
            managerAsisstant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirectory);
            //işlemin ilk geldiğinde tetiklenmesi için 
            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
