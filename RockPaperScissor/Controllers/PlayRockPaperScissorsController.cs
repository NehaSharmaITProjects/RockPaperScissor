using RockPaperScissor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RockPaperScissor.Controllers
{
    public class PlayRockPaperScissorsController : Controller
    {
        // GET: PlayRockPaperScissors
        public ActionResult Index(string imagename = "", string result = "", string imageclicked = "")
        {
            ViewBag.ShowFrom = "none";
            ViewBag.Result = "";
            if (String.IsNullOrEmpty(imagename))
            {
                ViewBag.ImageName = "~/Images/noimage.png";
            }
            else {
                ViewBag.ImageName = "~/Images/" + imagename + ".png";
                if (result == "Won") {
                    ViewBag.ShowFrom = "inline";
                }
                ViewBag.Result = "You clicked " + imageclicked + " and computer generated " + imagename + ". Result : " + result;
            }
           
            return View();
        }

        public ActionResult Play(string imageclicked)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            string imagename = "";
            string result = "";
            switch (randomNumber) {
                case 1:
                    imagename = "rock";
                    if (imageclicked == imagename)
                    {
                        result = "Draw";
                    }
                    else if (imageclicked == "paper") {
                        result = "Won";
                    }
                    else if (imageclicked == "scissor")
                    {
                        result = "Lost";
                    }
                    break;
                case 2:
                    imagename = "paper";
                    if (imageclicked == imagename)
                    {
                        result = "Draw";
                    }
                    else if (imageclicked == "scissor")
                    {
                        result = "Won";
                    }
                    else if (imageclicked == "rock")
                    {
                        result = "Lost";
                    }
                    break;
                case 3:
                    imagename = "scissor";
                    if (imageclicked == imagename)
                    {
                        result = "Draw";
                    }
                    else if (imageclicked == "rock")
                    {
                        result = "Won";
                    }
                    else if (imageclicked == "paper")
                    {
                        result = "Lost";
                    }
                    break;
            }



            return RedirectToAction("Index", new { imagename = imagename , result = result, imageclicked  = imageclicked });
        }

        public ActionResult SaveData(PlayerViewModel pv) {

            PlayerFactoryViewModel.SaveData(pv);
            return RedirectToAction("Index");
        }

        public ActionResult ReadData()
        {

            var model = PlayerFactoryViewModel.ReadData();
            return View(model);
        }
    }
}