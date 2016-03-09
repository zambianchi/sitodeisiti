using SitoDeiSiti.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace SitoDeiSiti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string path = HttpContext.Server.MapPath("~/App_Data/data.xml");
            XDocument xml = XDocument.Load(path);
            List<Sito> siti = xml.Descendants("Sito").Select(d =>
                new Sito
                {
                    Nome = d.Element("Nome").Value,
                    Link = d.Element("Link").Value,
                    PhotoLink = d.Element("Link").Value + "/Content/Images/foto.jpg"
                }).ToList();

            return View(siti);
        }
        public ActionResult Info()
        {
            string path = HttpContext.Server.MapPath("~/App_Data/data.xml");
            XDocument xml = XDocument.Load(path);
            
            return View((object)xml.ToString());
        }
    }
}