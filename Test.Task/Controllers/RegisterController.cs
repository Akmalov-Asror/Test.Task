﻿using Microsoft.AspNetCore.Mvc;
using Test.Task.Data;
using Test.Task.Entities;
using Test.Task.ViewModels;

namespace Test.Task.Controllers
{
    public class RegisterController : Controller
    {
        private readonly AppDBContext _context;

        public RegisterController(AppDBContext context)
        {
            _context = context;
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpUserViewModel dtoModel)
        {
            if (!ModelState.IsValid)
                return View(dtoModel);

            var model = new SignUp()
            {
                UserName = dtoModel.UserName,
                LastName = dtoModel.LastName,
                Email = dtoModel.Email,
                Password = dtoModel.Password,
                PhoneNumber = dtoModel.PhoneNumber,
                Role = dtoModel.Role,
            };
            _context.User.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Product", "Register");
        }
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SignInUserViewModel dtoModel)
        {
            if (!ModelState.IsValid)
                return View(dtoModel);

            var user = _context.User.FirstOrDefault(d => d.UserName == dtoModel.UserName && d.Password == dtoModel.Password);
            if (user is null)
            {
                return RedirectToAction("SignUp", "Register");
            }
            return RedirectToAction("Product", "Register");
        }
        public IActionResult Product()
        {
            var modelList = _context.Products.ToList();
            return View(modelList);
        }
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
                return View(productViewModel);

            var product = new Entities.Product()
            {
                Title = productViewModel.Title,
                Quantiy = productViewModel.Quantiy,
                Price = productViewModel.Price
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Product", "Register");
        }
    }
}
