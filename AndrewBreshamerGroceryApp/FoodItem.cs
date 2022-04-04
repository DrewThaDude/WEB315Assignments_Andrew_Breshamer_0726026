using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class FoodItem 
{
    public string itemName { get; set; }

    public double price { get; set; }

    public string brand { get; set; }

    [Range(0, 20, ErrorMessage = "Maximum 20 items allowed")] //not sure why doesn't work??
    public int qty { get; set; }
}