using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace book_shop
{
    public partial class browse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/notloggedin.aspx");
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int bookid = Convert.ToInt32(GridView1.DataKeys[RowClicked].Value);

                List<int> BooksInCart = (List<int>)Session["Cart"];

                if (BooksInCart == null)
                {
                    BooksInCart = new List<int>();
                }
                BooksInCart.Add(bookid);
                Session["Cart"] = BooksInCart;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/checkout.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/search.aspx");
        }
    }
}