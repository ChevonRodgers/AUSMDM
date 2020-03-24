using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUSMDM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xceed.Wpf.Toolkit;


namespace AUSMDM.Controllers
{



    public class ParameterSectionController : Controller
    {

        // Event views
        public ActionResult Event()
        {
            return View(EventClass.Events);
        }

        public ActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEvent(IFormCollection collection)
        {
            EventClass events = new EventClass();
            events.Name = collection["Name"];
            events.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            events.Protocol = collection["Protocol"];
            EventClass.Events.Add(events);
            return RedirectToAction("Event");
        }

        public ActionResult DeleteEvent(int i)
        {
            var st = EventClass.Events.Find(c => c.IdentityNumber == i);
            EventClass.Events.Remove(st);
            return RedirectToAction("Event");
        }

        // End of event views





        // Collect Plan Views

        public ActionResult CollectPlan()
        {
            return View(CollectPlanClass.CollectPlans);
        }

        public ActionResult CreateCollectPlan()
        {
            return View();
               
        }

        [HttpPost]
        public ActionResult CreateCollectPlan(IFormCollection collection)
        {
            CollectPlanClass collectPlan = new CollectPlanClass();
            collectPlan.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            collectPlan.Name = collection["Name"];
            collectPlan.Status = collection["Status"];
            collectPlan.CreatedBy = collection["CreatedBy"];
            collectPlan.CreatedOn = DateTime.Now;
            collectPlan.ModifiedOn = DateTime.Now;
            collectPlan.ModifiedBy = collection["ModifiedBy"];
            CollectPlanClass.CollectPlans.Add(collectPlan);
            return RedirectToAction("CollectPlan");
        }

        public ActionResult DeleteCollectPlan(int i)
        {
            var st = CollectPlanClass.CollectPlans.Find(c => c.IdentityNumber == i);
            CollectPlanClass.CollectPlans.Remove(st);
            return RedirectToAction("CollectPlan");
        }
        
        // Collect Plan ends


        // SupplyGroup Views
        public ActionResult SupplyGroup()
        {
            return View(SupplyGroupClass.SupplyGroups);
        }

        public ActionResult CreateSupplyGroup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSupplyGroup(IFormCollection collection)
        {
            SupplyGroupClass supplyGroup = new SupplyGroupClass();
            supplyGroup.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            supplyGroup.SGC = Convert.ToInt32(collection["SGC"]);
            supplyGroup.Name = collection["Name"];
            supplyGroup.CreatedBy = collection["CreatedBy"];
            supplyGroup.CreatedOn = DateTime.Now;
            supplyGroup.ModifiedOn = DateTime.Now;
            supplyGroup.ModifiedBy = collection["ModifiedBy"];
            SupplyGroupClass.SupplyGroups.Add(supplyGroup);
            return RedirectToAction("SupplyGroup");
        }

        public ActionResult DeleteSupplyGroup(int i)
        {
            var st = SupplyGroupClass.SupplyGroups.Find(c => c.IdentityNumber == i);
            SupplyGroupClass.SupplyGroups.Remove(st);
            return RedirectToAction("SupplyGroup");
        }

        // End of Supply Groups



        // Tariff Views
        public ActionResult Tariff()
        {
            return View(TariffClass.tariffs);
        }

        public ActionResult CreateTariff()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateTariff(IFormCollection collection)
        {
            TariffClass tariff = new TariffClass();
            tariff.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            tariff.TI = Convert.ToInt32(collection["TI"]);
            tariff.Name = collection["Name"];
            tariff.Status = collection["Status"];
            tariff.CreatedBy = collection["CreatedBy"];
            tariff.CreatedOn = DateTime.Now;
            tariff.ModifiedOn = DateTime.Now;
            tariff.ModifiedBy = collection["ModifiedBy"];
            TariffClass.tariffs.Add(tariff);
            return RedirectToAction("Tariff");
        }


        public ActionResult DeleteTariff(int i)
        {
            var st = TariffClass.tariffs.Find(c => c.IdentityNumber == i);
            TariffClass.tariffs.Remove(st);
            return RedirectToAction("Tariff");
        }
        // End of Tariff Views

        // Fee Views
        [HttpPost]
        public ActionResult CreateFee(IFormCollection collection)
        {
            FeeModel fee = new FeeModel();
            fee.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            fee.Name = collection["Name"];
            fee.Status = collection["Status"];
            fee.CreatedBy = collection["CreatedBy"];
            fee.CreatedOn = DateTime.Now;
            fee.ModifiedOn = DateTime.Now;
            fee.ModifiedBy = collection["ModifiedBy"];
            FeeModel.FeeList.Add(fee);
            return RedirectToAction("Fee");

        }
       

        public ActionResult CreateFee()
        {
            return View();
        }

        public ActionResult Fee()
        {
            return View(FeeModel.FeeList);
        }

        public ActionResult DeleteFee(int i)
        {
            var st = FeeModel.FeeList.Find(c => c.IdentityNumber == i);
            FeeModel.FeeList.Remove(st);
            return RedirectToAction("Fee");
        }
        // Fee Views End
         


        // Meter list views
        public ActionResult MeterList()
        {
            return View(Meter.AllMeters);
        }

        public ActionResult CreateMeter()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateMeter(IFormCollection collection)

        { 
           
            Meter meterlist = new Meter();
            meterlist.IdentityNumber = Convert.ToInt32(collection["IdentityNumber"]);
            meterlist.Name = collection["Name"];
            meterlist.Supplier = collection["Supplier"];
            meterlist.Protocol = collection["Protocol"];
            meterlist.Accuracy = Convert.ToDouble(collection["Accuracy"]);
            meterlist.CurrentGrade = Convert.ToInt32(collection["CurrentGrade"]);
            meterlist.CreditType = collection["CreditType"];
            meterlist.ConnectionType = collection["ConnectionType"];
            meterlist.Voltage = Convert.ToInt32(collection["Voltage"]);

            Meter.AllMeters.Add(meterlist);
           return RedirectToAction("MeterList");
        }

        public ActionResult DeleteMeter(int i)
        {
            var st = Meter.AllMeters.Find(c => c.IdentityNumber == i);
            Meter.AllMeters.Remove(st);
            return RedirectToAction("MeterList");

            



        }

        public ActionResult EditMeter(string i)
        {
           
            var std = Users.AllUsers.Where(s => s.IdentityNumber == i).FirstOrDefault();
            var st = Users.AllUsers.Find(c => c.IdentityNumber == i);
            Users.AllUsers.Remove(st);
            return View(std);


        }

        // End of Meter-List Views

        // Supplier Views and functions

            public ActionResult DetailsSupplier(string i)
        {
            var std = Users.AllUsers.Find(s => s.IdentityNumber == i);
            return View(std);
        }


        public ActionResult DeleteSupplier(string i)
        {
            var st = Users.AllUsers.Find(c => c.IdentityNumber == i);
            Users.AllUsers.Remove(st);
            return RedirectToAction("Supplier");

          
           
            

        }

      

        public ActionResult EditSupplier(string i)
        {
          
            var std = Users.AllUsers.Where(s => s.IdentityNumber == i).FirstOrDefault();
            var st = Users.AllUsers.Find(c => c.IdentityNumber == i);
            Users.AllUsers.Remove(st);

            return View(std);

            
        }



        [HttpPost]
        public ActionResult EditSupplier(Users user)
        {
            var name = user.Name;
            var id = user.IdentityNumber;
            var surname = user.Surname;
         
            Users Newuser = new Users();
            Newuser.Name = name;
            Newuser.Surname = surname;
            Newuser.IdentityNumber = id;
            
            Users.AllUsers.Add(Newuser);

             

            return RedirectToAction("Supplier");
        }

       

        public ActionResult CreateSupplier(int id)
        {
            return View();
        }


        public IActionResult Supplier()
        {
        
            return View(Users.AllUsers);
        }

     [HttpPost]
        public ActionResult CreateSupplier(IFormCollection collection)
           
        {
            Users newUser = new Users(); // new class
            newUser.Name = collection["Name"];
            newUser.Surname = collection["Surname"];
            newUser.IdentityNumber = collection["IdentityNumber"];

            Users.AllUsers.Add(newUser); // Inserting into list 
            return RedirectToAction("Supplier");


        }

        // End of Supplier Views
              


    }
}