using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransfer : System.Web.UI.Page
{

   // private Customer customerTransferee;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (IsPostBack == false)
        {
            string transferor = Session["transferorSelection"].ToString();
            foreach (Customer customer in Customer.GetAllCustomers())
            {
                if(customer.Id.ToString() !=transferor)
                {
                    ListItem item = new ListItem(customer.ToString(), customer.Id.ToString());
                    dropDownList.Items.Add(item);
                }
                

            }

        }//postback

        foreach (ListItem dropdown in dropDownList.Items)
        {
            if (dropdown.Selected)
            {
                foreach (Customer customer in Customer.GetAllCustomers())
                {
                    if (customer.ToString() == dropdown.Text)
                    {
                        rblToAccount.Items[0].Text = customer.Checking.ToString();
                        rblToAccount.Items[1].Text = customer.Saving.ToString();

                    }//if

                }//foreach
            }//if
          

        }//foreach
        

    }//page load



    protected void ButtonNext_Click(object sender, EventArgs e)
    {

        
        Response.Redirect("FundTransferConfirmation.aspx");
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

       
        Response.Redirect("FundTransferFrom.aspx");
    }

    protected void rblFromAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        string valueSelected = dropDownList.SelectedValue;

        Session["transfereeSelection"] = valueSelected;
        int CustomerId = int.Parse(valueSelected);

        Customer selectedCustomer = Customer.GetCustomerById(CustomerId);

        if (rblToAccount.Items[0].Selected)
        {
            Session["btnRadioTo"] = selectedCustomer.Checking.ToString();


        }
        else if (rblToAccount.Items[1].Selected)
        {


            Session["btnRadioTo"] = selectedCustomer.Saving.ToString();
            
        }
    }
}//class


    

