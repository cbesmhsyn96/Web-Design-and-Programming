using modelkullanimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelkullanimi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BootstrapDeneme()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About controller' ında çoklu model düzenlemesi(atamalar,eklemeler) yapıldı.";
            ViewBag.Message2 = "About view' inde düzenlenen çoklu model gösterildi.";

            Altmodel1 altmodel = new Altmodel1()
            {
                altsayi1 = 12,altyazi1="altyazi1",altyazi11="altyazi11"
            };
            List<Altmodel2> altmodel2liste = new List<Altmodel2>()
            {
                new Altmodel2(){ID=1,altsayi2=111,altyazi2="qqqqqq",altyazi21="eeeeee"},
                new Altmodel2(){ID=2,altsayi2=112,altyazi2="rrrrrr",altyazi21="tttttt"},
                new Altmodel2(){ID=3,altsayi2=113,altyazi2="yyyyyy",altyazi21="jjjjjj"},
                new Altmodel2(){ID=4,altsayi2=114,altyazi2="wwwwww",altyazi21="vvvvvv"},
                new Altmodel2(){ID=5,altsayi2=115,altyazi2="nnnnnn",altyazi21="mmmmmm"},
                new Altmodel2(){ID=6,altsayi2=116,altyazi2="pppppp",altyazi21="üüüüüü"},
            };
            AnaModel anaModel = new AnaModel();
            anaModel.altmodel1 = altmodel;
            anaModel.altmodel2 = altmodel2liste;
            anaModel.anamodel_yazi="AnaModel' in yazısı";
            return View(anaModel);
        }
        public ActionResult AnaModel2Action()
        {
            List<Model1> model1list = new List<Model1>() {
                new Model1{ID=1,sayi=12,yazi1="asas",yazi2="rrrr",yazi3="yyyy"},
                new Model1{ID=2,sayi=33,yazi1="aaas",yazi2="ryur",yazi3="yooy"},
                new Model1{ID=3,sayi=55,yazi1="asss",yazi2="ruyr",yazi3="yppy"},
                new Model1{ID=4,sayi=32,yazi1="rrrs",yazi2="rıır",yazi3="yğğy"},
                new Model1{ID=5,sayi=11,yazi1="adds",yazi2="rnnr",yazi3="yüüy"},
                new Model1{ID=6,sayi=44,yazi1="ayys",yazi2="rvvr",yazi3="yııy"},
                new Model1{ID=7,sayi=45,yazi1="auus",yazi2="rccr",yazi3="yzzz"},
            };
            List<Model2> model2list = new List<Model2>()
            {
                new Model2{ID=2,yazi1="yazi",yazi2="yazi2q"},
                new Model2{ID=4,yazi1="yazias",yazi2="yazi2s"},
                new Model2{ID=6,yazi1="yazisda",yazi2="yazi2d"},
                new Model2{ID=8,yazi1="yazicc",yazi2="yazi2f"},
                new Model2{ID=10,yazi1="yaziz",yazi2="yazi2g"},
                new Model2{ID=12,yazi1="yaziv",yazi2="yazi2x"},
                new Model2{ID=14,yazi1="yaziuu",yazi2="yazi2n"},
            };
            Model3 mdel3 = new Model3();
            mdel3.sayi = 232323;
            mdel3.mevsim = "İlkbahar";
            mdel3.adet = 44444444;
            AnaModel2 anaModel2 = new AnaModel2();
            anaModel2.model1 = model1list;
            anaModel2.model2 = model2list;
            anaModel2.model3 = mdel3;
            return View(anaModel2);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            List<contact_model> model = new List<contact_model>() {
            new contact_model{sayi=12,yazi="yazi1",varyok=true},
            new contact_model{sayi=23,yazi="yazi2",varyok=true},
            new contact_model{sayi=125,yazi="yazi3",varyok=true},
            new contact_model{sayi=1223,yazi="yazi4",varyok=true},
            new contact_model{sayi=1,yazi="yazi5",varyok=true},
            };
            List<Viewbag_model> vbag_model = new List<Viewbag_model>() {
            new Viewbag_model{ID=1,name="Electronic Product",brand="Vestel",district="Havsa",city="Edirne" },
            new Viewbag_model{ID=2,name="Electronic Product",brand="Arçelik",district="Çelikhan",city="Adıyaman" },
            new Viewbag_model{ID=3,name="Cleaning Product",brand="Bor",district="Havsa",city="Edirne" },
            new Viewbag_model{ID=4,name="Car",brand="TOGG",district="Havsa",city="Edirne" },
            new Viewbag_model{ID=5,name="Ice tea",brand="Didi",district="Havsa",city="Edirne" },
            new Viewbag_model{ID=6,name="Tank",brand="Altay",district="Havsa",city="Edirne" },
            new Viewbag_model{ID=7,name="Car",brand="Murat",district="Havsa",city="Edirne" },
            };
            ViewBag.viewbagmodel = vbag_model;
            ViewBag.controllerViewBag = new List<dynamic>() {
                {12},
                {"adasd"},
                {"sdddd"},
                {23},
                {44},
                {"adddddd"},
                {"wertyu"},
                {"kırk"},
                {"Ağaç"},

            };
            /*ViewBag kendisine atanan verinin tipinden haberdar değil.*/
            return View(model);
        }
    }
}