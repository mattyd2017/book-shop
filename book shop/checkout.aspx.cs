using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace book_shop
{
    public partial class checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/notloggedin.aspx");
            }
            //this calls the getbooks from basket method 
            if (!Page.IsPostBack)
            {
                GetBooksFromBasket();
            }
        }
        private void GetBooksFromBasket()
        {
            //this method binds the book id to dataveiw after the final choice of book ahas been made so when the user removes an item this updates the gridview accordingly
            if (Session["Cart"] != null)
            {
                using (booksDataContext data = new booksDataContext())
                {
                    List<int> Cart = (List<int>)Session["Cart"];
                    var book = data.Books.Where(Book => Cart.Contains(Book.bookid));

                    GridView1.DataSource = book;
                    GridView1.DataBind(); 
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // this removes items from the cart and is linked to the removefromcart command in the grid view remove botton column
            if (e.CommandName == "RemoveFromCart")
            {
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int bookid = Convert.ToInt32(GridView1.DataKeys[RowClicked].Value);
                // this removes the unwanted item from the array before commiting to the database
                List<int> BooksinBasket = (List<int>)Session["Cart"];
                BooksinBasket.Remove(bookid);
                Session["Cart"] = BooksinBasket;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //this send the user to the order form
            Response.Redirect("~/Payments/payments.aspx");
        }

        
    }
}