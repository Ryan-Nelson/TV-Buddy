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
    public class TVSInRoomsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TVSInRoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TVSInRooms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TVSInRooms.Include(t => t.Rooms).Include(t => t.TVS);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TVSInRooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVSInRooms = await _context.TVSInRooms
                .Include(t => t.Rooms)
                .Include(t => t.TVS)
                .FirstOrDefaultAsync(m => m.TVSInRoomsId == id);
            if (tVSInRooms == null)
            {
                return NotFound();
            }

            return View(tVSInRooms);
        }

        // GET: TVSInRooms/Create
        public IActionResult Create()
        {
            ViewData["RoomsId"] = new SelectList(_context.Rooms, "RoomsId", "RoomName");
            ViewData["TVSId"] = new SelectList(_context.TVS, "TVSId", "Brand");
            return View();
        }

        // POST: TVSInRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TVSInRoomsId,TVSId,RoomsId")] TVSInRooms tVSInRooms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tVSInRooms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomsId"] = new SelectList(_context.Rooms, "RoomsId", "RoomName", tVSInRooms.RoomsId);
            ViewData["TVSId"] = new SelectList(_context.TVS, "TVSId", "Brand", tVSInRooms.TVSId);
            return View(tVSInRooms);
        }

        // GET: TVSInRooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVSInRooms = await _context.TVSInRooms.FindAsync(id);
            if (tVSInRooms == null)
            {
                return NotFound();
            }
            ViewData["RoomsId"] = new SelectList(_context.Rooms, "RoomsId", "RoomName", tVSInRooms.RoomsId);
            ViewData["TVSId"] = new SelectList(_context.TVS, "TVSId", "Brand", tVSInRooms.TVSId);
            return View(tVSInRooms);
        }

        // POST: TVSInRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TVSInRoomsId,TVSId,RoomsId")] TVSInRooms tVSInRooms)
        {
            if (id != tVSInRooms.TVSInRoomsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tVSInRooms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TVSInRoomsExists(tVSInRooms.TVSInRoomsId))
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
            ViewData["RoomsId"] = new SelectList(_context.Rooms, "RoomsId", "RoomName", tVSInRooms.RoomsId);
            ViewData["TVSId"] = new SelectList(_context.TVS, "TVSId", "Brand", tVSInRooms.TVSId);
            return View(tVSInRooms);
        }

        // GET: TVSInRooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVSInRooms = await _context.TVSInRooms
                .Include(t => t.Rooms)
                .Include(t => t.TVS)
                .FirstOrDefaultAsync(m => m.TVSInRoomsId == id);
            if (tVSInRooms == null)
            {
                return NotFound();
            }

            return View(tVSInRooms);
        }

        // POST: TVSInRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tVSInRooms = await _context.TVSInRooms.FindAsync(id);
            _context.TVSInRooms.Remove(tVSInRooms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TVSInRoomsExists(int id)
        {
            return _context.TVSInRooms.Any(e => e.TVSInRoomsId == id);
        }
    }
}
