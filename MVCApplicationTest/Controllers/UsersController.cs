using MVCApplicationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCApplicationTest.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            IEnumerable<mvcUserModel> usersList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("User").Result;
            usersList = response.Content.ReadAsAsync<IEnumerable<mvcUserModel>>().Result;
            return View(usersList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new mvcUserModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("User/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcUserModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(mvcUserModel user)
        {
            if (user.UsersID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("User", user).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("User/" + user.UsersID, user).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("User/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}