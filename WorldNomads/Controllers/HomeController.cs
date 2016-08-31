using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection.Emit;
using System.Dynamic;
using WorldNomads.Models;
using System.Globalization;


namespace WorldNomads.Controllers
{
    public class myClass
    {

    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(TestModel model, string returnUrl)
        {
            int iNum = 0;
            if (CheckInput(model.InputNumber, out iNum))
            {
                ViewBag.Result = "Success";
                ViewBag.Result1 = GetAllNum(iNum);
                ViewBag.Result2 = GetOddNum(iNum);
                ViewBag.Result3 = GetEvenNum(iNum);
                ViewBag.Result4 = GetCEZ(iNum);
                ViewBag.Result5 = GetFibonacci(iNum);
                return View(model);
            }

            ViewBag.Result = "Failed";
            ModelState.AddModelError("", "The input number provided is incorrect, only accept integer and greater than zero");
            return View(model);
        }

        private bool CheckInput(string number, out int iReturnNum)
        {
            bool result = false;
            iReturnNum = 0;

            int iNum;
            if (int.TryParse(number, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out iNum))
            {
                if (iNum > 0)
                {
                    result = true;
                    iReturnNum = iNum;
                }
            }

            return result;
        }
        private string GetAllNum(int num)
        {
            string result = "";

            for (int i = 0; i <= num; i++)
                result = result + i.ToString() + ", ";

            result = result.Remove(result.Length - 2);      //remove last comma
            return result;
        }

        private string GetOddNum(int num)
        {
            string result = "";

            for (int i = 1; i <= num; i++)
            {
                if(i % 2 != 0)
                    result = result + i.ToString() + ", ";
            }
            result = result.Remove(result.Length - 2);      //remove last comma

            return result;
        }
        private string GetEvenNum(int num)
        {
            string result = "";

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                    result = result + i.ToString() + ", ";
            }
            result = result.Remove(result.Length - 2);      //remove last comma

            return result;
        }
        private string GetCEZ(int num)
        {
            string result = "";

            for (int i = 0; i <= num; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    result = result + "Z" + ", ";
                else if(i % 3 == 0)
                    result = result + "C" + ", ";
                else if (i % 5 == 0)
                    result = result + "E" + ", ";
                else
                    result = result + i.ToString() + ", ";
            }

            result = result.Remove(result.Length - 2);      //remove last comma

            return result;
        }
        private string GetFibonacci(int num)
        {
            string result = "";

            int step = 0;
            while(true)
            {
                int FinNum = Fibonacci(step);
                if (FinNum <= num)
                {
                    result = result + FinNum + ", ";
                    step++;
                }
                else
                    break;
            }

            result = result.Remove(result.Length - 2);      //remove last comma

            return result;
        }
        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;           
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
