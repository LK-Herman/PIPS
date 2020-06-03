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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }
        
       

        // GET: CarModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
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
        public async Task<IActionResult> Create([Bind("Id,Marka,Model,Klasa,PojSilnika,Przebieg,RokProd,Paliwo,Kolor,Cena,Opis,ImageTitle,ImageFile")] CarModel carModel)
        {
            if (ModelState.IsValid)
            {

                // zapisywanie w katalogu ~/wwwroot/images/carimg
                
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(carModel.ImageFile.FileName);
                string extension = Path.GetExtension(carModel.ImageFile.FileName);
                carModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff")+extension;
                string path = Path.Combine(wwwRootPath + "/images/carimg/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await carModel.ImageFile.CopyToAsync(fileStream);
                }

                // zapisanie rekordów



                _context.Add(carModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carModel);
        }

        // GET: CarModels/Edit/5
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

        // POST: CarModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marka,Model,Klasa,PojSilnika,Przebieg,RokProd,Paliwo,Kolor,Cena,Opis,ImageTitle,ImageFile")] CarModel carModel)
        {
            if (id != carModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {


                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(carModel.ImageFile.FileName);
                    string extension = Path.GetExtension(carModel.ImageFile.FileName);
                    carModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/images/carimg/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await carModel.ImageFile.CopyToAsync(fileStream);
                    }



                    _context.Update(carModel);      // ***********
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

        // GET: CarModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images/carimg/", carModel.ImageName);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }

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


    

