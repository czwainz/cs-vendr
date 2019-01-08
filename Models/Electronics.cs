using csvendr.Interfaces;

namespace csvendr.Models
{
  public class Electronic : IPurchasable
  {
    public Electronic(bool accessory, string name, float price, int quant)
    {
      Accessory = accessory;
      Name = name;
      Price = price;
      Quantity = quant;
    }

    public bool Accessory { get; set; }

    public string Name { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
  }
}