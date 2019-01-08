using csvendr.Interfaces;

namespace csvendr.Models
{
  public class Snack : Edible, IPurchasable
  {
    public Snack(string brand, bool sweet, string exp, string name, float price, int quant) : base(brand, sweet, exp)
    {
      Name = name;
      Price = price;
      Quantity = quant;
    }
    public string Name { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }

  }
}