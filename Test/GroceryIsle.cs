using System;
using System.Collections;
using System.Collections.Generic;

    public class GroceryIsle : IEnumerable<FoodItem>
    {
        public string isleName { get; set; }
        public int isleNumber { get; set; }

        public List<FoodItem> isleItems { get; set; }

        IEnumerator<FoodItem> IEnumerable<FoodItem>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /* public GroceryIsle()
        {
            
        } */
    }