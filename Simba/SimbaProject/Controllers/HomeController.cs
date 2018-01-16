using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Repositories;

namespace SimbaProject.Controllers
{

    public class HomeController : Controller
    {
        public HomeController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository{ get; set; }        

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var readerList = LibraryRepository.GetReaders();
            return View(readerList);
        }

        [HttpGet("add")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Reader reader)
        {
            LibraryRepository.LibraryContext.Readers.Add(reader);
            LibraryRepository.LibraryContext.SaveChanges();
            return RedirectToAction("list");
        }



        [HttpGet("update/{id}")]
        public IActionResult UpdateForm([FromRoute]int id)
        {
            return View(LibraryRepository.GetSingleReader(id));
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(Reader inputReader, [FromRoute] int id)
        {
            LibraryRepository.UpdateReader(inputReader, id);
            return RedirectToAction("list");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            LibraryRepository.RemoveReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("fee/{id}")]
        public IActionResult Fee(int id)
        {
            LibraryRepository.FineReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("single/{id}")]
        public IActionResult SingleReader(int id)
        {
            var reader = LibraryRepository.GetSingleReader(id);
            return View(reader);
        }
    }
}