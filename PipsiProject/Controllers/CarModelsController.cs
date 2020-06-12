using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PipsiProject.Models;

namespace PipsiProject.Controllers
{
    public class CarModelsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostEnvironment;

        public CarModelsController(AppDbContext context, IHostingEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }


        // GET: CarModels

        //public async Task<IActionResult> Index()
        //{
        //    var carAndImg = _context.Cars
        //    .Include(c => c.CarImage)
        //    .AsNoTracking();
        //    return View(await carAndImg.ToListAsync());

        //    //return View(await _context.Cars.ToListAsync());
        //}

        public async Task<IActionResult> Index(int? id)
        {
            var carAndImg = _context.Cars
           .Include(c => c.CarImage)
           .AsNoTracking();

            if (id != null)
            {
                string klasa = "";
                switch (id)
                {
                    case 1:
                        klasa = "Ekonomiczna";
                        break;
                    case 2:
                        klasa = "Sportowa";
                        break;
                    case 3:
                        klasa = "Luksusowa";
                        break;
                }

                carAndImg = _context.Cars
                .Include(c => c.CarImage)
                .Where(c => c.Klasa.Equals(klasa))
                .AsNoTracking();
                return View(await carAndImg.ToListAsync());
            }
            else
            {
                return View(await carAndImg.ToListAsync());
                //return View(await _context.Cars.ToListAsync());
            }
        }

        //public async Task<IActionResult> IndexEko()
        //{
        //    var carAndImg = _context.Cars
        //    .Include(c => c.CarImage)
        //    .Where(c => c.Klasa == "Ekonomiczna")
        //    .AsNoTracking();

        //    return View(await carAndImg.ToListAsync());

            //return View(await _context.Cars.ToListAsync());
        //}


 //-----------------------DETAILS---GET-----------------------------------------
        public async Task<IActionResult> Details(int? id)
        {
            var carAndImg = await _context.Cars
           .Include(c => c.CarImage)
           .AsNoTracking()
           .FirstOrDefaultAsync(m => m.Id == id);
                                                                                              // return View(await carAndImg.ToListAsync());

            if (id == null)
            {
                return NotFound();
            }
            if (carAndImg == null)
            {
                return NotFound();
            }
            return View(carAndImg);
        }

        // GET: CarModels/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: CarModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marka,Model,Klasa,PojSilnika,Przebieg,RokProd,Paliwo,Kolor,Cena,Opis,CarImage")] CarModel carModel)
        {
            if (ModelState.IsValid)
            {

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(carModel.CarImage.ImageFile.FileName);
                string extension = Path.GetExtension(carModel.CarImage.ImageFile.FileName);

                carModel.CarImage.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/images/carimg/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await carModel.CarImage.ImageFile.CopyToAsync(fileStream);
                }

                _context.Add(carModel);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(carModel);
        }


        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.Cars.FindAsync(id);
            if (carModel == null)
            {
                return NotFound();
            }
            return View(carModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marka,Model,Klasa,PojSilnika,Przebieg,RokProd,Paliwo,Kolor,Cena,Opis,Carimg")] CarModel carModel)
        {
            if (id != carModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.UpdateRange(carModel);      // *********** zmiana z Update na UpdateRange
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarModelExists(carModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carModel);
        }

//---------------DELETE--------------------------------------------------------------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {
            var carModel = await _context.Cars
                .Include(c => c.CarImage)
               .AsNoTracking()
               .FirstOrDefaultAsync(m => m.Id == id);


            if (id == null)
            {
                return NotFound();
            }

            
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
        }

        // POST: CarModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carModel = await _context.Cars.FindAsync(id);

            // usuwanie zdjęcia z folderu ~/images/carimg
            //var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images/carimg/", carModel.ImageName);
            //if (System.IO.File.Exists(imagePath))
            //{
            //    System.IO.File.Delete(imagePath);
            //}

            // usuwanie rekordu DB

            _context.Cars.Remove(carModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarModelExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }

        public ActionResult Display()
        {
            return View();
        }
    }
}




