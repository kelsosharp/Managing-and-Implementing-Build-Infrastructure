using HelloAzureDevOps.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloAzureDevOps.Tests
{
    [TestClass]
    public class HomeControllerUnitTests
    {
        [TestMethod]
        public void HomeControllerIndexViewReturned()
        {
            //Arrange
            var controller = new HomeController(logger: null);
            
            //Act
            var result = controller.Index() as ViewResult;
            
            //Assert
            Assert.AreEqual("Index", result.ViewName);

        }

        [TestMethod]
        public void HomecontrollerPrivacyViewReturned()
        {
            //Arrange
            var controller = new HomeController(logger: null);
            
            //Act
            var result = controller.Privacy() as ViewResult;
            
            //Assert
            Assert.AreEqual("Privacy", result.ViewName);
        }
    }
}
