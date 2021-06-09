using System.Collections.Generic;
using System.ComponentModel.Design;
using MyWebsite.Data.Models;
using System.Linq;
using NPoco.Linq;
using Umbraco.Core.Composing;
using System.Web.Mvc;

namespace MyWebsite.Core.Extensions
{
    public static class ComponentsCompositionExtensions
    {
        public static bool HasComponents(this IComponentsComposition componentsComposition)
        {
            return componentsComposition?.Components != null && componentsComposition.Components.Any(x => x is IComponentComposition cc && cc.Active);
        }

        public static IEnumerable<IComponentComposition> GetComponents(this IComponentsComposition componentsComposition)
        {
            return !componentsComposition.HasComponents() 
                ? Enumerable.Empty<IComponentComposition>() 
                : componentsComposition.Components.OfType<IComponentComposition>().Where(x => x.Active);
        }

       


    }
}
