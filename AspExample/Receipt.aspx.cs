using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session ["Meal"]==null)
        {
            Response.Redirect("Default.aspx");
        }
        DisplayReceipt();
    }
    protected void DisplayReceipt()
    {
        StringBuilder sb = new StringBuilder();
        MealOrder meal = (MealOrder)Session["Meal"];
        List<string> entrees = meal.Entrees;
        List<string> drinks = meal.Drinks;
        foreach(string entree in entrees)
        {
            sb.Append(entree);
            sb.Append("<br/>");
        }
        foreach (string drink in drinks)
        {
            sb.Append(drink);
            sb.Append("<br/>");
        }
        sb.Append(meal.CalculateTotal().ToString());
        Label1.Text = sb.ToString();
    }
}