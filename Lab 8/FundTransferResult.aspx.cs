using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string transferorSelected = Session["transferorSelection"].ToString();
        string AmountSelected = Session["AmountTransfer"].ToString();
        
        string transfereeSelected = Session["transfereeSelection"].ToString();
         string balanceTransferor =Session["BalanceTransferor"].ToString();
         string balanceTransferee = Session["BalanceTransferee"].ToString();

        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                lblAmount.Text += AmountSelected.ToString();
                lblTransferor.Text += customer.ToString();
                lblTransferorAccount.Text += balanceTransferor.ToString();


            }//if
            else if (customer.Id.ToString() == transfereeSelected.ToString())
            {
                lblTransferee.Text += customer.ToString();
                lblTransfereeAccount.Text += balanceTransferee.ToString();
            }
        }

    }


    protected void Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("FundTransferFrom.aspx");
    }
}