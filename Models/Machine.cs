using System;
using System.Collections.Generic;
using csvendr.Interfaces;
namespace csvendr.Models
{
  public class Machine
  {
    public string Name { get; set; }
    public Dictionary<string, IPurchasable> Inventory { get; set; }


    public Machine(string name)
    {
      Name = name;
      Inventory = new Dictionary<string, IPurchasable>();
    }


    public void Setup()
    {
      Snack oreo = new Snack("Nabisco", true, "01/01/19", "Oreo", .75f, 5);
      Snack famousAmos = new Snack("Nabisco", true, "12/01/19", "Famous Amos", .5f, 5);
      Snack dorito = new Snack("Doritos", false, "02/29/19", "Cool Ranch", .5f, 5);
      Beverage raspberryTea = new Beverage("Lipton", true, "none", "Raspberry Iced Tea", .75f, 4);
      Beverage cherryCoke = new Beverage("Coca Cola", true, "01/01/20", "Cherry Coke", .5f, 5);
      Beverage tea = new Beverage("Brisk", false, "none", "Unsweetened Tea", .75f, 5);
      Electronic headphones = new Electronic(true, "Headphones", 1.5f, 5);
      Electronic charger = new Electronic(true, "USB Charger", 5f, 5);
      Electronic iPad = new Electronic(false, "iPad", 200, 1);

      Inventory.Add("A1", oreo);
      Inventory.Add("A2", famousAmos);
      Inventory.Add("A3", dorito);
      Inventory.Add("B1", raspberryTea);
      Inventory.Add("B2", cherryCoke);
      Inventory.Add("B3", tea);
      Inventory.Add("C1", headphones);
      Inventory.Add("C2", charger);
      Inventory.Add("C3", iPad);

    }

    public void PrintInventory()
    {
      foreach (var item in Inventory)
      {
        Console.WriteLine($"{item.Key} {item.Value.Name} - {item.Value.Price}");
      }
    }


  }
}
