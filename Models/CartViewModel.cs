﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class CartViewModel
    {
        //Per request empty
        //TODO: CartController with AddCart BuyCart ChangeAmount(Product product) 
        //TODO: CSHTML ViewCart Displays all items in Cart(User user)
        public List<Product> Products { get; set; }
        [Range(1,999), Display(Name = "Amount")]
        public int ProductAmount{ get; set; }
        [Range(1,999), Display(Name = "Amount of Items in Cart")]
        public int AmountOfItems { get; set; }
        [Display(Name = "Totalprice"),DataType(DataType.Currency)]
        public double TotalPrice { get; set; }
    }
}
