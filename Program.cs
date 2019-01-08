using System;
using csvendr.Models;
using csvendr.Interfaces;

namespace csvendr
{
  class Program
  {
    static void Main(string[] args)
    {
      float machineTotal;
      float addedMoney;
      Machine myMachine = new Machine("Chrissy's Cookies n Cola");

      myMachine.Setup();

      void AddMoney()
      {
        machineTotal += addedMoney;
      }

      bool standingIfFrontOfMachine = true;

      while (standingIfFrontOfMachine)
      {
        Console.Clear();
        myMachine.PrintInventory();
        // ask question
        Console.Write("What would you like to do? 1-Add Money 2-Purchase Item 3-Leave");
        var decision = Console.ReadLine();

        var moneyToAdd = Console.ReadLine();

        // addedMoney = float.TryParse("Cannot Add", out moneyToAdd);


        switch (decision)
        {
          case "q":
          case "Q":
          case "3":
            standingIfFrontOfMachine = false;
            break;

        }



      }


    }
    public enum Menus
    {

    }
  }
}
