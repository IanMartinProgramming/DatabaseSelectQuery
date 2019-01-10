using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace FinalIanMartin
{
	public partial class WebFormFinalExam : System.Web.UI.Page
	{
		BusinessLogicLayer bll;

		public WebFormFinalExam()
		{
			bll = new BusinessLogicLayer();
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				ddlCategories.DataTextField = "Name";
				ddlCategories.DataValueField = "Id";
				ddlCategories.DataSource = bll.GetAllCategories();
				ddlCategories.DataBind();
				ddlCategories.Items.Insert(0, "Select a Category");

				ddlSuppliers.DataTextField = "Name";
				ddlSuppliers.DataValueField = "Id";
				ddlSuppliers.DataSource = bll.GetAllSuppliers();
				ddlSuppliers.DataBind();
				ddlSuppliers.Items.Insert(0, "Select a Supplier");
			}
		}

		protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlSuppliers.SelectedIndex = 0;
			int id = ddlCategories.SelectedIndex;
			grdProducts.DataSource = bll.GetProductsByCategory(id);
			grdProducts.DataBind();
		}

		protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlCategories.SelectedIndex = 0;
			int id = ddlSuppliers.SelectedIndex;
			grdProducts.DataSource = bll.GetProductsBySupplier(id);
			grdProducts.DataBind();
		}
	}
}