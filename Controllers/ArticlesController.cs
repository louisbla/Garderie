using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garderie.Models;
using Garderie.Data;
using Garderie.ViewModels.ArticleViewModels;

namespace Garderie.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly GarderieContext _context;

        public ArticlesController(GarderieContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            List<IndexArticleViewModel> ArticleVMList = new List<IndexArticleViewModel>();
            var garderieContext = _context.Articles.Include(a => a.Categorie).Include(a => a.EnfantInventaire).Include(a => a.Inventaire);
            var articles = await garderieContext.ToListAsync();
            foreach(var article in articles)
            {
                IndexArticleViewModel viewModel = new IndexArticleViewModel
                {
                    ArticleId = article.ArticleId,
                    Nom = article.Nom,
                    Quantite = (int)article.Quantite,
                    Photo = article.Photo,
                    Description = article.Description,
                    Categorie = article.Categorie.Nom
                };
                ArticleVMList.Add(viewModel);
            }
            return View(ArticleVMList);
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.Categorie)
                .Include(a => a.EnfantInventaire)
                .Include(a => a.Inventaire)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }


            DetailsArticleViewModel detailsArticleViewModel = new DetailsArticleViewModel
            {
                ArticleId = article.ArticleId,
                Nom = article.Nom,
                Quantite = (int)article.Quantite,
                Photo = article.Photo,
                Visible = (byte)article.Visible,
                Description = article.Description,
                EnfantInventaireId = article.EnfantInventaireId,
                Categorie = article.Categorie.Nom
            };


            return View(detailsArticleViewModel);

        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["CategorieId"] = new SelectList(_context.CategoriesArticle, "CategorieId", "CategorieId");
            ViewData["EnfantInventaireId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId");
            ViewData["InventaireId"] = new SelectList(_context.Inventaires, "InventaireId", "InventaireId");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArticleId,Nom,Quantite,Photo,Visible,Description,InventaireId,EnfantInventaireId,CategorieId")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategorieId"] = new SelectList(_context.CategoriesArticle, "CategorieId", "CategorieId", article.CategorieId);
            ViewData["EnfantInventaireId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", article.EnfantInventaireId);
            ViewData["InventaireId"] = new SelectList(_context.Inventaires, "InventaireId", "InventaireId", article.InventaireId);
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["CategorieId"] = new SelectList(_context.CategoriesArticle, "CategorieId", "CategorieId", article.CategorieId);
            ViewData["EnfantInventaireId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", article.EnfantInventaireId);
            ViewData["InventaireId"] = new SelectList(_context.Inventaires, "InventaireId", "InventaireId", article.InventaireId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArticleId,Nom,Quantite,Photo,Visible,Description,InventaireId,EnfantInventaireId,CategorieId")] Article article)
        {
            if (id != article.ArticleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleId))
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
            ViewData["CategorieId"] = new SelectList(_context.CategoriesArticle, "CategorieId", "CategorieId", article.CategorieId);
            ViewData["EnfantInventaireId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", article.EnfantInventaireId);
            ViewData["InventaireId"] = new SelectList(_context.Inventaires, "InventaireId", "InventaireId", article.InventaireId);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.Categorie)
                .Include(a => a.EnfantInventaire)
                .Include(a => a.Inventaire)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ArticleId == id);
        }
    }
}
