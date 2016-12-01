using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MealOrder
/// </summary>
public class MealOrder
{   public List<string> Entrees { set; get; }
    public List<string> Drinks { set; get; }
    public MealOrder()
    {
        Entrees = new List<string>();
        Drinks = new List<string>();
    }
    public void AddEntree(string item)
    {
        Entrees.Add(item);
    }
    public void AddDrink(string item)
    {
        Drinks.Add(item);
    }
    public double CalculateTotal()
    {
        double total = 0;
        foreach (string entree in Entrees)
        {
            total += 2.99;
        }
        foreach(string drink in Drinks)
        {
            total += .99;
        }
        return total;
    }
}