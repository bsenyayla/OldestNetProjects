using PersonelMVC.Models;
using PersonelMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        //Normalde routeconfigte ki ayara göre url den controllerName/MethodName/?ve paramtre olarak bu method çağrılır
        public string TestMVC(string prm1)
        {
            return "TestMVC çalışıyor prm1:" + prm1;
        }

        /*Yukarıdaki örnekte method çağrıldı ve geriye return ün içinde ne varsa basıldı.
         Fakat bir web ortamında kullanacağımız için ActionResult adında bir tipde dönüş yapıyoruz. bu web sayfasınının browser
         ın anladığı istediği cinseten olacaktır . ActionResult un bir kaç farklı dönüş methodu vardır View bunlardan bir tanesidir.
             */
        public ActionResult Merhaba()
        {
            var departman = new Departman() { Id=1,Ad="Bahadır"};
            return View(departman);

        }

        public ActionResult Test()
        {
            var departman = new Departman() { Id = 1, Ad = "Bahadır" };
            return RedirectToAction("Index", "Personel");

        }


        public ActionResult Index()
        {
            return Content("Departman index Sayfası");
        }

        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = 1, Ad = "IT Departmanı" };


            var data = new DepartmanDetayViewModel() {
                Departman=departman,
                PersonelData= new List<Personel>() {
                    new Personel { DepartmanId=1,PersonelAd="Bahadır",PersonelId=1},
                    new Personel { DepartmanId=1,PersonelAd="Buğra",PersonelId=2},
                    new Personel { DepartmanId=1,PersonelAd="Kakun",PersonelId=3},
                    new Personel { DepartmanId=1,PersonelAd="Amet",PersonelId=4}
                }
           };
            return View(data);
        }
    }
}