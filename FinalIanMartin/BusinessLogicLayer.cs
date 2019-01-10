using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalIanMartin
{
	public class BusinessLogicLayer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }

		DataAccessLayer dal;

		public BusinessLogicLayer()
		{
			dal = new DataAccessLayer();
		}

		public List<BusinessLogicLayer> GetAllCategories()
		{
			return dal.GetAllCategories();
		}

		public List<BusinessLogicLayer> GetAllSuppliers()
		{
			return dal.GetAllSuppliers();
		}

		public List<BusinessLogicLayer> GetProductsByCategory(int id)
		{
			return dal.GetProductsByCategory(id);
		}

		public List<BusinessLogicLayer> GetProductsBySupplier(int id)
		{
			return dal.GetProductsBySupplier(id);
		}

	}
}