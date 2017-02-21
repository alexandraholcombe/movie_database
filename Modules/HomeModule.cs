using Nancy;
using System.Collections.Generic;
using Catalog.Objects;

namespace Catalog
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
    }
  }
}
