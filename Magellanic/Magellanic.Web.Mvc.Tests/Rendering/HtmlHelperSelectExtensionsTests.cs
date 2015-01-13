namespace Magellanic.Web.Mvc.Tests.Rendering
{
    using Magellanic.Web.Mvc.Rendering;
    using Magellanic.Web.MvcTests;
    using NUnit.Framework;
    using SampleApplication.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    [TestFixture]
    public static class HtmlHelperSelectExtensionsTests
    {
        [Test]
        public static void DropDownListForTestWithListAndSelectedItem()
        {
            // Arrange
            var userViewModel = new UserViewModel(new List<User>()
                                        {
                                            new User{ Name = "Dave", Id = 1 },
                                            new User{ Name = "Nate", Id = 2 },
                                            new User{ Name = "Pat", Id = 3 },
                                            new User{ Name = "Taylor", Id = 4 },
                                            new User{ Name = "Chris", Id = 5 }
                                        })
                                        {
                                            UserId = "2"
                                        };

            var htmlHelper = HtmlHelperMock.GetMock(userViewModel);
            var expectedMvcHtmlString = SelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, new SelectList(userViewModel.UserNames, "Id", "Name", userViewModel.UserId));

            // Act
            var actualMvcHtmlString = HtmlHelperSelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, m => m.UserNames, m => m.Id, m => m.Name);

            // Assert
            Assert.AreEqual(expectedMvcHtmlString.ToHtmlString(), actualMvcHtmlString.ToHtmlString());
        }

        [Test]
        public static void DropDownListForTestWithListAndNoSelectedItem()
        {
            // Arrange
            var userViewModel = new UserViewModel(new List<User>()
                                        {
                                            new User{ Name = "Dave", Id = 1 },
                                            new User{ Name = "Nate", Id = 2 },
                                            new User{ Name = "Pat", Id = 3 },
                                            new User{ Name = "Taylor", Id = 4 },
                                            new User{ Name = "Chris", Id = 5 }
                                        });

            var htmlHelper = HtmlHelperMock.GetMock(userViewModel);
            var expectedMvcHtmlString = SelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, new SelectList(userViewModel.UserNames, "Id", "Name", userViewModel.UserId));

            // Act
            var actualMvcHtmlString = HtmlHelperSelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, m => m.UserNames, m => m.Id, m => m.Name);

            // Assert
            Assert.AreEqual(expectedMvcHtmlString.ToHtmlString(), actualMvcHtmlString.ToHtmlString());
        }

        [Test]
        public static void DropDownListForTestWithEmptyList()
        {
            // Arrange
            var userViewModel = new UserViewModel(new List<User>());

            var htmlHelper = HtmlHelperMock.GetMock(userViewModel);
            var expectedMvcHtmlString = SelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, new SelectList(userViewModel.UserNames, "Id", "Name", userViewModel.UserId));

            // Act
            var actualMvcHtmlString = HtmlHelperSelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, m => m.UserNames, m => m.Id, m => m.Name);

            // Assert
            Assert.AreEqual(expectedMvcHtmlString.ToHtmlString(), actualMvcHtmlString.ToHtmlString());
        }

        [Test]
        public static void DropDownListForTestWithNoList()
        {
            // Arrange
            var userViewModel = new UserViewModel(new List<User>());

            var htmlHelper = HtmlHelperMock.GetMock(userViewModel);
            var expectedMvcHtmlString = SelectExtensions.DropDownListFor(htmlHelper, m => m.UserId, new SelectList(new List<User>(), "Id", "Name", userViewModel.UserId));

            //Act
            var actualHtmlString = HtmlHelperSelectExtensions.DropDownListFor(htmlHelper, m => m.UserId,
              m => m.UserNames, m => m.Id,
              m => m.Name);

            // Act & Assert - expected exception
            Assert.AreEqual(expectedMvcHtmlString.ToString(), actualHtmlString.ToString());
        }
    }
}