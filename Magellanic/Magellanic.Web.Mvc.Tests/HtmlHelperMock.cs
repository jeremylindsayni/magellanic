// ***********************************************************************
// Assembly         : Magellanic.Web.MvcTests
// Author           : Jeremy Lindsay
// Created          : 08-Jan-2015
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 11-Jan-2015
// ***********************************************************************
/// <summary>
/// The MvcTests namespace.
/// </summary>
namespace Magellanic.Web.MvcTests
{
    using Rhino.Mocks;
    using System.Globalization;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// The HtmlHelperMock class.
    /// </summary>
    /// <remarks>
    /// Thank you to @hjgraca for allowing me to use his awesome HtmlHelperMock class. His is the best I found.
    /// Visit his original implementation at: http://hjgraca.github.io/2014/10/31/htmlhelper-unit-test-wrapper/
    /// </remarks>
    public static class HtmlHelperMock
    {
        /// <summary>
        /// Gets the mocked HtmlHelper&lt;TModel&gt; object.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="inputDictionary">The input dictionary.</param>
        public static HtmlHelper<TModel> GetMock<TModel>(TModel inputDictionary)
        {
            return GetMock<TModel>(inputDictionary, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Gets the mocked HtmlHelper&lt;TModel&gt; object.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="inputDictionary">The input dictionary.</param>
        /// <param name="routeController">The route controller.</param>
        /// <param name="routeAction">The route action.</param>
        /// <param name="viewName">Name of the view.</param>
        /// <returns>HtmlHelper&lt;TModel&gt;.</returns>
        public static HtmlHelper<TModel> GetMock<TModel>(TModel inputDictionary, string routeController,
            string routeAction, string viewName)
        {
            var viewData = new ViewDataDictionary<TModel>(inputDictionary);
            var routeData = new RouteData();
            routeData.Values["controller"] = routeController;
            routeData.Values["action"] = routeAction;

            var httpContext = MockRepository.GenerateStub<HttpContextBase>();
            var viewContext = MockRepository.GenerateStub<ViewContext>();
            var httpRequest = MockRepository.GenerateStub<HttpRequestBase>();
            var httpResponse = MockRepository.GenerateStub<HttpResponseBase>();

            httpContext.Stub(c => c.Request).Return(httpRequest).Repeat.Any();
            httpContext.Stub(c => c.Response).Return(httpResponse).Repeat.Any();
            httpResponse.Stub(r => r.ApplyAppPathModifier(Arg<string>.Is.Anything))
                        .Return(string.Format(CultureInfo.InvariantCulture, "/{0}/{1}", routeController, routeAction));

            viewContext.HttpContext = httpContext;
            viewContext.RequestContext = new RequestContext(httpContext, routeData);
            viewContext.RouteData = routeData;
            viewContext.ViewData = MockRepository.GenerateStub<ViewDataDictionary>();
            viewContext.ViewData.Model = inputDictionary;
            viewContext.TempData = MockRepository.GenerateStub<TempDataDictionary>();
            viewContext.View = SetupView(viewName);

            return new HtmlHelper<TModel>(viewContext, GetViewDataContainer(viewData));
        }

        /// <summary>
        /// Gets the view data container.
        /// </summary>
        /// <param name="viewData">The view data.</param>
        /// <returns>IViewDataContainer.</returns>
        private static IViewDataContainer GetViewDataContainer(ViewDataDictionary viewData)
        {
            var mockContainer = MockRepository.GenerateMock<IViewDataContainer>();
            mockContainer.Expect(c => c.ViewData).Return(viewData);
            return mockContainer;
        }

        /// <summary>
        /// Setups the view.
        /// </summary>
        /// <param name="viewName">Name of the view.</param>
        /// <returns>IView.</returns>
        private static IView SetupView(string viewName)
        {
            var view = MockRepository.GenerateStub<IView>();
            var engine = MockRepository.GenerateStub<IViewEngine>();
            var viewEngineResult = new ViewEngineResult(view, engine);
            engine.Stub(x => x.FindPartialView(null, viewName, false)).IgnoreArguments().Return(viewEngineResult);
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(engine);
            return view;
        }
    }
}
