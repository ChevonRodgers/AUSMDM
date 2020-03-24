using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUSMDM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AUSMDM.Controllers
{



    public class ParameterSectionController : Controller
    {
       
        public ActionResult Delete(string i)
        {
            var st = Users.AllUsers.Find(c => c.IdentityNumber == i);
            Users.AllUsers.Remove(st);
            return RedirectToAction("Supplier");

           // return View(st);
           
            

        }

      

        public ActionResult Edit(string i)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = Users.AllUsers.Where(s => s.IdentityNumber == i).FirstOrDefault();
            var st = Users.AllUsers.Find(c => c.IdentityNumber == i);
            Users.AllUsers.Remove(st);

            return View(std);

            
        }



        [HttpPost]
        public ActionResult Edit(Users user)
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

       

        public ActionResult Create(int id)
        {
            return View();
        }


        public IActionResult Supplier()
        {
        
           


            return View(Users.AllUsers);
        }

     [HttpPost]
        public ActionResult Create(IFormCollection collection)
           
        {
            Users newUser = new Users(); // new class
            newUser.Name = collection["Name"];
            newUser.Surname = collection["Surname"];
            newUser.IdentityNumber = collection["IdentityNumber"];

            Users.AllUsers.Add(newUser); // Inserting into list 
            return RedirectToAction("Supplier");


        }
              


    }
}