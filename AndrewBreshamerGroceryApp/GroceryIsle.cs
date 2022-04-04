using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class GroceryIsle 
{
    public string isleName { get; set; }
    
    public int isleNumber { get; set; }

    public List<FoodItem> isleItems { get; set; } = new List<FoodItem>();
}