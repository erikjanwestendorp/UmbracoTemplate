using System.Web.Mvc;
using MyWebsite.Data.Models;
using Umbraco.Web.Mvc;

namespace MyWebsite.Business.Controllers
{
    public class ComponentController : SurfaceController
    {

        public ActionResult RenderComponent(IComponentComposition component)
        {
            var componentAlias = component.ContentType.Alias.Replace("Component", string.Empty).ToLower();

            var componentPath = $"~/Views/Partials/Components/{componentAlias}.cshtml";
            return PartialView(componentPath, component);
        }
    }
}
