﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendasAspNetMVC.Models;

namespace VendasAspNetMVC.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produtos/Create
        public ActionResult Novo()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(PRODUTO produto)
        {
            try
            {
                // TODO: Add insert logic here
                vendasdbEntities db = new vendasdbEntities();
                db.PRODUTOes.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index", "ProdutosController");
            }
            catch
            {
                return View("Novo");
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
