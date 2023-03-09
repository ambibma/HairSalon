namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId {get; set;}
    public string Name {get; set;}
    public string HireDate {get; set;}
    public List<Clients> Clients {get; set;}
  }
}