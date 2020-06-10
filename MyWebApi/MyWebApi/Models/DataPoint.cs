using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyWebApi.Models
{
	
	public class DataPoint
    {
		public string Name { get; set; }
		public int Quantity { get; set; }

		public DataPoint(String name , int quantity)
        {
			this.Name = name;
			this.Quantity = quantity;
        }
	}
}