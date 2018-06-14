using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace book_shop
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this is to  redirect anonymous users to the not logged in error page
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/notloggedin.aspx");
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //the  e. command name calls the function of the button and store it in the cart session in the list array 
            if (e.CommandName == "AddToCart")
            {
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int bookid = Convert.ToInt32(GridView1.DataKeys[RowClicked].Value);

                //list array to store the values of the selected column into the session array

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
            try
            {
                using (booksDataContext Data = new booksDataContext())
                {
                    //this is used to query the database from the linq datacontext class
                    string bookTitle = TextBoxBookTitle.Text;
                    var searchResults = Data.Books.Where(Books => (Books.bookTitle.Contains(bookTitle) || bookTitle.Length == 0));
                    GridView1.DataSource = searchResults;
                    GridView1.DataBind();
                }
            }
            catch (Exception)
            { 
                //to redirect the user to the error page if any erros occur in executing the search function
                Response.Redirect("~/error.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/checkout.aspx");
        }
    }
}