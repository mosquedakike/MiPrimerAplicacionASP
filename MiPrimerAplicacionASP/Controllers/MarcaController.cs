using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MiPrimerAplicacionASP.Models;

namespace MiPrimerAplicacionASP.Controllers
{
    public class MarcaController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarca = null;
            using (var bd = new BDPasajeEntities())
            {
                listaMarca = (from marca in bd.Marca
                    where marca.BHABILITADO==1
                    select new MarcaCLS
                    {
                        iidmarca = marca.IIDMARCA,
                        nombre = marca.NOMBRE,
                        descripcion = marca.DESCRIPCION
                    }).ToList();
            }
            return View(listaMarca);
        }

        public ActionResult Agregar()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Agregar(MarcaCLS oMarcaClS)
        {
            if (!ModelState.IsValid)
            {
                return View(oMarcaClS);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    Marca oMarca = new Marca();
                    oMarca.NOMBRE = oMarcaClS.nombre;
                    oMarca.DESCRIPCION = oMarcaClS.descripcion;
                    oMarca.BHABILITADO = 1;
                    bd.Marca.Add(oMarca);
                    bd.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}