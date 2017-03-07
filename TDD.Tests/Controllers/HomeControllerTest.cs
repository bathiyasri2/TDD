using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using TDD.Controllers;
using TDD.Repositiry;
using System.Web.Routing;
using TDD.Tests.Models;

namespace TDD.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        Contact GetContact()
        {
            return GetContact(1, "Janet");
        }

        Contact GetContact(int id, string fName)
        {
            return new Contact
            {
                Id = id,
                Name = fName
            };
        }

        private static HomeController GetHomeController(IContactRepository repository)
        {
            HomeController controller = new HomeController(repository);

            controller.ControllerContext = new ControllerContext
            {
                Controller = controller,
                RequestContext = new RequestContext(new MockHttpContext(), new RouteData())

            };
            return controller;

        }


        [TestMethod]
        public void Index_Get_AskForIndexView()
        {
            // Arrange
            HomeController controller = GetHomeController(new InMemoryContactRepository());

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void Index_Get_RetriveAllContactFromReporsitry()
        {
            //Arrange
            Contact contact1 = new Repositiry.Contact { Id = 100, Name = "adjen" };
            Contact contact2 = new Repositiry.Contact { Id = 200, Name = "sagepay" };

            InMemoryContactRepository repository = new InMemoryContactRepository();
            repository.CreateNewContact(contact1);
            repository.CreateNewContact(contact2);

            HomeController controller = GetHomeController(repository);

            // Act
            var result = controller.Index() as ViewResult;

            var model = (IEnumerable<Contact>)result.ViewData.Model;
            CollectionAssert.Contains(model.ToList(), contact1);
            CollectionAssert.Contains(model.ToList(), contact2);


        }

        [TestMethod]
        public void Create_Post_ReturnsviewIfModelStateNotValid()
        {
            // Arrange
            HomeController controller = GetHomeController(new InMemoryContactRepository());

            controller.ModelState.AddModelError("one", "mock error message");

            Contact model = GetContact(133, "silva");

            var result = (ViewResult)controller.Create(model);

            Assert.AreEqual("Create", result.ViewName);

        }

        [TestMethod]
        public void Create_Post_PutsValidContactIntoRepository()
        {
            // Arrange
            InMemoryContactRepository repository = new InMemoryContactRepository();
            HomeController controller = GetHomeController(repository);
            Contact contact = GetContact();

            // Act
            controller.Create(contact);

            // Assert
            IEnumerable<Contact> contacts = repository.GetAllContacts();
            Assert.IsTrue(contacts.Contains(contact));
        }


        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
