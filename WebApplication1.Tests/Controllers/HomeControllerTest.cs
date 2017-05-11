using System.Web.Mvc;
using WebApplication1.Controllers;
using FluentAssertions;
using Xunit;

namespace WebApplication1.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;
            string message = result?.ViewBag.Message as string;

            // Assert
            message.Should().Be("Your application description page.");
        }

        [Fact]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }
    }
}
