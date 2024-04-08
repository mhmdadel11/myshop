using myshop.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.Entities.ViewModels
{
	public class OrderVM
	{
		public OrderHeader OrderHeader { get; set; }
		//عملتها ليست عشان الاوردر الواحد ممكن يحتوى ع اكتر من ديتيلز
		public IEnumerable<OrderDetail>OrderDetails { get; set; }
	}
}
