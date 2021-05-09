using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kalakaar.Data;
using Kalakaar.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Kalakaar.Controllers
{
    public class ShopsController : Controller
    {
        private readonly AppDbContext _context;

        public ShopsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Shops
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> CheckoutNav()
        {
            return PartialView(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> Women()
        {
            return View(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> Men()
        {
            return View(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> BabiesBabas()
        {
            return View(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> HomeAccessories()
        {
            return View(await _context.Shops.ToListAsync());
        }

        public async Task<IActionResult> DressAccessories()
        {
            return View(await _context.Shops.ToListAsync());
        }
        public async Task<IActionResult> Fabric()
        {
            return View(await _context.Shops.ToListAsync());
        }
        public async Task<IActionResult> Wishlist()
        {
            return View(await _context.Shops.ToListAsync());
        }
        public async Task<IActionResult> MyCart()
        {
            return View(await _context.Shops.ToListAsync());
        }
        public async Task<IActionResult> Checkout()
        {
            return View(await _context.Shops.ToListAsync());
        }
        // GET: Shops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // GET: Shops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ShopType,ProductCategory,ProductName,Price,Avail,Discription,Image1Url,Image2Url,ImgBanner,Brand")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shop);
        }

        // GET: Shops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            return View(shop);
        }

        public ActionResult AddWishlist(int id)
        {
            var wishlist = JsonConvert.DeserializeObject<Wishlist>(HttpContext.Session.GetString("wishlist"));
            
            wishlist.ProductIDs.Add(id);

            HttpContext.Session.SetString("wishlist", JsonConvert.SerializeObject(wishlist));

            string url = this.Request.Path;
            return Redirect("/Shops/Wishlist");
        }

        public ActionResult RemoveWishlist(int id)
        {
            var wishlist = JsonConvert.DeserializeObject<Wishlist>(HttpContext.Session.GetString("wishlist"));

            wishlist.ProductIDs.Remove(id);

            HttpContext.Session.SetString("wishlist", JsonConvert.SerializeObject(wishlist));

            string url = this.Request.Path;
            return Redirect("/Shops/Wishlist");
        }

        public ActionResult AddCheckout(int id)
        {
            var checkout = JsonConvert.DeserializeObject<Checkout>(HttpContext.Session.GetString("checkout"));

            checkout.ProductIDs.Add(id);

            HttpContext.Session.SetString("checkout", JsonConvert.SerializeObject(checkout));

            string url = this.Request.Path;
            return RedirectToAction(nameof(MyCart));
        }

        public ActionResult RemoveCheckout(int id)
        {
            var checkout = JsonConvert.DeserializeObject<Checkout>(HttpContext.Session.GetString("checkout"));

            checkout.ProductIDs.Remove(id);

            HttpContext.Session.SetString("checkout", JsonConvert.SerializeObject(checkout));

            string url = this.Request.Path;
            return RedirectToAction(nameof(MyCart));
        }

        // POST: Shops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ShopType,ProductCategory,ProductName,Price,Avail,Discription,Image1Url,Image2Url,ImgBanner,Brand")] Shop shop)
        {
            if (id != shop.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopExists(shop.ProductId))
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
            return View(shop);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shop = await _context.Shops.FindAsync(id);
            _context.Shops.Remove(shop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ProductId == id);
        }
    }
}
