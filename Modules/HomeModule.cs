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
      Get["/clients/edit/{id}"] = parameters => {
        Client foundClient = Client.Find(parameters.id);
        return View["client-edit.cshtml", foundClient];
      };
      Get["/clients/view/{id}"] = parameters => {
        Client foundClient = Client.Find(parameters.id);
        return View["client-details.cshtml", foundClient];
      };
      Get["/stylists/view/{id}"] = parameters => {
        Stylist foundStylist = Stylist.Find(parameters.id);
        return View["stylist-details.cshtml", foundStylist];
      };
      Post["/clients/new"] = _ => {
        int newStylistId = Request.Form["stylist-id"];
        Client newClient = new Client(Request.Form["client-name"], newStylistId);
        newClient.Save();
        return View["client-details.cshtml", newClient];
      };
      Post["/stylists/new"] = _ => {
        Stylist newStylist = new Stylist(Request.Form["stylist-name"]);
        newStylist.Save();
        return View["stylist-details.cshtml", newStylist];
      };
      Patch["clients/edit/{id}"] = parameters => {
        Client foundClient = Client.Find(parameters.id);
        foundClient.Update(Request.Form["client-name"]);
        return View["client-details.cshtml", foundClient];
      };
      Delete["clients/delete/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object> {{"clients", Client.GetAll()}, {"stylists", Stylist.GetAll()}};
        Client foundClient = Client.Find(parameters.id);
        Client.Delete(foundClient.GetId());
        return View["index.cshtml", model];
      };
    }
  }
}
