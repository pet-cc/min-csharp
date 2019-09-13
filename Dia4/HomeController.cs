using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using AutoMapper;
using kiko.Models;
using Entidades;


namespace kiko.Controllers
{
    public class HomeController : Controller
    {
        private CidadeDAL DAL = new CidadeDAL();
        // GET: Home
        public ActionResult Index()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<Mapper.MappingProfile>(); });
            var mapper = config.CreateMapper();
            List<CidadeModel> lsRes = mapper.Map<List<Cidade>, List<CidadeModel>>(DAL.Select());
            return View(lsRes);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(CidadeModel item)
        {
            try
            {
                // TODO: Add insert logic here
                var config = new MapperConfiguration(cfg => { cfg.AddProfile<Mapper.MappingProfile>(); });
                var mapper = config.CreateMapper();
                Cidade cid = mapper.Map<CidadeModel, Cidade>(item);
                DAL.Insert(cid);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<Mapper.MappingProfile>(); });
            var mapper = config.CreateMapper();
            CidadeModel item = mapper.Map<Cidade, CidadeModel>(DAL.Select().Where(x => x.CID_ID == id).First());
            return View(item);
        }

        // POST: Home/Edit/5
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

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
