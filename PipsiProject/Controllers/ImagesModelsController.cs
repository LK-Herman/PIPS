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
    public class ImagesModelsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostEnvironment;

        public ImagesModelsController(AppDbContext context, IHostingEnvironment hostEnvironment)
        {
            this._context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: ImagesModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Images.ToListAsync());
        }

        // GET: ImagesModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageModel = await _context.Images
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (imageModel == null)
            {
                return NotFound();
            }

            return View(imageModel);
        }

        // GET: ImagesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImagesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageId,ImageTitle,ImageFile")] ImageModel imageModel)
        {
            if (ModelState.IsValid)
            {

                // zapisywanie w katalogu ~/wwwroot/images/carimg

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
                string extension = Path.GetExtension(imageModel.ImageFile.FileName);
                imageModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/images/carimg/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await imageModel.ImageFile.CopyToAsync(fileStream);
                }

                // zapisanie rekordów



                _context.Add(imageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imageModel);
        }

        // GET: ImagesModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageModel = await _context.Images.FindAsync(id);
            if (imageModel == null)
            {
                return NotFound();
            }
            return View(imageModel);
        }

        // POST: ImagesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImageId,ImageTitle,ImageFile")] ImageModel imageModel)
        {
            if (id != imageModel.ImageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // zapisywanie zdjęcia do katalogu

                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
                    string extension = Path.GetExtension(imageModel.ImageFile.FileName);
                    imageModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/images/carimg/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await imageModel.ImageFile.CopyToAsync(fileStream);
                    }



                    _context.Update(imageModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageModelExists(imageModel.ImageId))
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
            return View(imageModel);
        }

        // GET: ImagesModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageModel = await _context.Images
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (imageModel == null)
            {
                return NotFound();
            }

            return View(imageModel);
        }

        // POST: ImagesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imageModel = await _context.Images.FindAsync(id);


            // usuwanie zdjęcia z folderu ~/images/carimg

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images/carimg/", imageModel.ImageName);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }



            _context.Images.Remove(imageModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageModelExists(int id)
        {
            return _context.Images.Any(e => e.ImageId == id);
        }
    }
}
