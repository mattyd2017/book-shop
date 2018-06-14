using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace book_shop.Payments
{
    public partial class payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/notloggedin.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (booksDataContext data = new booksDataContext())
                {
                    // this was used to add the details to the order table on the database
                    order NewOrder = new order();
                    NewOrder.orderaddress1 = TextBoxOrderAddress1.Text;
                    NewOrder.orderaddress2 = TextBoxOrderAddress2.Text;
                    NewOrder.ordertown = TextBoxOrderTown.Text;
                    NewOrder.countyid = Convert.ToInt32(DropDownList1.SelectedValue);
                    NewOrder.orderpostcode = TextBoxOrderPostCode.Text;

                    NewOrder.orderpaid = false;
                    NewOrder.ordersent = false;

                    NewOrder.username = Page.User.Identity.Name;
                    NewOrder.orderdate = DateTime.Now;

                    data.orders.InsertOnSubmit(NewOrder);
                    data.SubmitChanges();

                    //this links to the basket in the cart session from the values still stored in the cart session

                    List<int> books = (List<int>)Session["Cart"];
                    foreach (int bookid in books)
                    {
                        bookorder newbookorder = new bookorder();
                        newbookorder.orderid = newbookorder.orderid;
                        newbookorder.bookid = bookid;
                        data.bookorders.InsertOnSubmit(newbookorder);
                    }
                    data.SubmitChanges();
                  
                }
            }
            catch(Exception)
            {
                Response.Redirect("~/error.aspx");
            }
            //to send the user to the order entered on the database page to imnform that it was entered and no errors occured
            Response.Redirect("~/Payments/ordersucess.aspx");
        }
    }
}