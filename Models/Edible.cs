namespace csvendr.Models
{
  public abstract class Edible
  {
    public string Brand { get; set; }
    public bool Sweet { get; set; }
    public string Expiration { get; set; }

    public Edible(string brand, bool sweet, string exp)
    {
      Brand = brand;
      Sweet = sweet;
      Expiration = exp;
    }
  }
}