using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TV_Buddy.Data;
using TV_Buddy.Models;

namespace TV_Buddy.Controllers
{
    public class TVSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TVSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TVS
        public async Task<IActionResult> Index()
        {
            return View(await _context.TVS.ToListAsync());
        }

        // GET: TVS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVS = await _context.TVS
                .FirstOrDefaultAsync(m => m.TVSId == id);
            if (tVS == null)
            {
                return NotFound();
            }

            return View(tVS);
        }

        // GET: TVS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TVS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TVSId,Brand,ModelNumber,SerialNumber,Size,Quality,HDR,OLED,QLED,LED,ContrastLevels,Price,Hrz,BitRate")] TVS tVS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tVS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tVS);
        }

        // GET: TVS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVS = await _context.TVS.FindAsync(id);
            if (tVS == null)
            {
                return NotFound();
            }
            return View(tVS);
        }

        // POST: TVS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TVSId,Brand,ModelNumber,SerialNumber,Size,Quality,HDR,OLED,QLED,LED,ContrastLevels,Price,Hrz,BitRate")] TVS tVS)
        {
            if (id != tVS.TVSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tVS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TVSExists(tVS.TVSId))
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
            return View(tVS);
        }

        // GET: TVS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVS = await _context.TVS
                .FirstOrDefaultAsync(m => m.TVSId == id);
            if (tVS == null)
            {
                return NotFound();
            }

            return View(tVS);
        }

        // POST: TVS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tVS = await _context.TVS.FindAsync(id);
            _context.TVS.Remove(tVS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TVSExists(int id)
        {
            return _context.TVS.Any(e => e.TVSId == id);
        }
    }
}
