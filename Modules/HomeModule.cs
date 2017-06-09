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
      Get["/clients"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object> {{"clients", Client.GetAll()}, {"stylists", Stylist.GetAll()}};
        return View["clients.cshtml", model];
      };
      Get["/stylists"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object> {{"clients", Client.GetAll()}, {"stylists", Stylist.GetAll()}};
        return View["stylists.cshtml", model];
      };
      Post["/clients/new"] = _ => {
        Client newClient = new Client(Request.Form["client-name"], Request.Form["stylist-id"]);
        newClient.Save();
        return View["client-details.cshtml", newClient];
      };
      Post["/stylists/new"] = _ => {
        Stylist newStylist = new Stylist(Request.Form["stylist-name"]);
        newStylist.Save();
        return View["stylist-details.cshtml", newStylist];
      };
    }
  }
}
