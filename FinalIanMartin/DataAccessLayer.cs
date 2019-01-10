using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalIanMartin
{
	public class DataAccessLayer
	{
		NorthwindDataSetTableAdapters.CategoriesTableAdapter adpCategories;
		NorthwindDataSet.CategoriesDataTable tblCategories;

		NorthwindDataSetTableAdapters.SuppliersTableAdapter adpSuppliers;
		NorthwindDataSet.SuppliersDataTable tblSuppliers;

		NorthwindDataSetTableAdapters.ProductsTableAdapter adpProducts;
		NorthwindDataSet.ProductsDataTable tblProducts;

		List<BusinessLogicLayer> listCategories;
		List<BusinessLogicLayer> listSuppliers;
		List<BusinessLogicLayer> listProductsByCategory;
		List<BusinessLogicLayer> listProductsBySupplier;

		public DataAccessLayer()
		{
			adpCategories = new NorthwindDataSetTableAdapters.CategoriesTableAdapter();
			tblCategories = new NorthwindDataSet.CategoriesDataTable();

			adpSuppliers = new NorthwindDataSetTableAdapters.SuppliersTableAdapter();
			tblSuppliers = new NorthwindDataSet.SuppliersDataTable();

			adpProducts = new NorthwindDataSetTableAdapters.ProductsTableAdapter();
			tblProducts = new NorthwindDataSet.ProductsDataTable();
		}

		public List<BusinessLogicLayer> GetAllCategories()
		{
			tblCategories = adpCategories.GetCategories();
			if (tblCategories.Count > 0)
			{
				listCategories = new List<BusinessLogicLayer>();
				foreach (var row in tblCategories)
				{
					BusinessLogicLayer category = new BusinessLogicLayer();
					category.Id = row.CategoryID;
					category.Name = row.CategoryName;
					listCategories.Add(category);
				}
			}
			return listCategories;
		}

		public List<BusinessLogicLayer> GetAllSuppliers()
		{
			tblSuppliers = adpSuppliers.GetSuppliers();
			if(tblSuppliers.Count > 0)
			{
				listSuppliers = new List<BusinessLogicLayer>();
				foreach(var row in tblSuppliers)
				{
					BusinessLogicLayer supplier = new BusinessLogicLayer();
					supplier.Id = row.SupplierID;
					supplier.Name = row.CompanyName;
					listSuppliers.Add(supplier);
				}
			}
			return listSuppliers;
		}

		public List<BusinessLogicLayer> GetProductsByCategory(int id)
		{
			tblProducts = adpProducts.GetProductsByCategoryID(id);
			if(tblProducts.Count > 0)
			{
				listProductsByCategory = new List<BusinessLogicLayer>();
				foreach (var row in tblProducts)
				{
					BusinessLogicLayer categoryProduct = new BusinessLogicLayer();
					categoryProduct.Id = row.ProductID;
					categoryProduct.Name = row.ProductName;
					categoryProduct.Price = row.UnitPrice;
					categoryProduct.Stock = row.UnitsInStock;
					listProductsByCategory.Add(categoryProduct);
				}
			}
			return listProductsByCategory;
		}

		public List<BusinessLogicLayer> GetProductsBySupplier(int id)
		{
			tblProducts = adpProducts.GetProductsBySupplierID(id);
			if (tblProducts.Count > 0)
			{
				listProductsBySupplier = new List<BusinessLogicLayer>();
				foreach (var row in tblProducts)
				{
					BusinessLogicLayer supplierProduct = new BusinessLogicLayer();
					supplierProduct.Id = row.ProductID;
					supplierProduct.Name = row.ProductName;
					supplierProduct.Price = row.UnitPrice;
					supplierProduct.Stock = row.UnitsInStock;
					listProductsBySupplier.Add(supplierProduct);
				}
			}
			return listProductsBySupplier;
		}
	}
}