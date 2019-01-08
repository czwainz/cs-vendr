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
        var decision = Console.ReadLine();

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
  }
}
