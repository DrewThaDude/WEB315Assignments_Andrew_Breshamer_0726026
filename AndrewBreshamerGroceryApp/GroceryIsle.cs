using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class GroceryIsle : IEnumerable<FoodItem>
{
    public string isleName { get; set; }

    public int isleNumber { get; set; }

    public List<FoodItem> isleItems { get; set; } = new List<FoodItem>();

    IEnumerator<FoodItem> IEnumerable<FoodItem>.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}