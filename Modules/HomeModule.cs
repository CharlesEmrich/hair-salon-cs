using Nancy;
using HairSalon.Objects;
using System.Collections.Generic;

namespace HairSalon
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object> {{"clients", Client.GetAll()}, {"stylists", Stylist.GetAll()}};
        return View["index.cshtml", model];
      };
    }
  }
}
