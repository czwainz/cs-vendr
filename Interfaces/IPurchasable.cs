namespace csvendr.Interfaces
{
  public interface IPurchasable
  {
    string Name { get; set; }
    float Price { get; set; }
    int Quantity { get; set; }
  }
}