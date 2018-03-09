using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SampleASPNetCoreProject.Controllers;
using Xunit;

namespace SampleXunitTestsProject
{
    public class SampleControllerTests
    {
        private static SampleController GetSampleController()
        {
            SampleController controller = new SampleController();

            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new RouteData()
            };

            return controller;
        }

        [Fact(DisplayName = "Create Index Action @create-index-action")]
        public void IndexViewTest()
        {
            var controller = GetSampleController();
            var result = controller.Index() as ViewResult;
            Assert.True(String.IsNullOrEmpty(result.ViewName) || "Index" == result.ViewName, "`SampleController`'s `Index` action did not return the Index view.");
        }

        [Fact(DisplayName = "Create Details Action @create-details-action")]
        public void DetailsViewTest()
        {
            var controller = GetSampleController();
            var result = controller.Details(0) as ViewResult;
            Assert.True(String.IsNullOrEmpty(result.ViewName) || "Details" == result.ViewName, "`SampleController`'s `Details` action did not return the Details view.");
            Assert.True(12345 == (int)result.Model, "`SampleController`'s `Details` action did not return the correct Model.");
        }

        [Fact(DisplayName = "Compiler Error Test @compiler-error-test")]
        public void CompilerErrorTest()
        {
            var controller = GetSampleController();
            var result = controller.BreakStuff() as ViewResult;
            Assert.True(result != null, "if this failed something has gone very very wrong");
        }
    }
}