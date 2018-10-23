using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransferFrom : System.Web.UI.Page
{

    private Customer customerTransferor;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)//to display content before submission
        {

            foreach (Customer customer in Customer.GetAllCustomers())// to get the list from customer
            {

                ListItem item = new ListItem(customer.ToString(), customer.Id.ToString());//listItem is in gesign part i dropdownList
                dropDownList.Items.Add(item);//adding items in dropdown List
                //adding title selected transforor in aspx
            }

        }//postback

        foreach (ListItem dropdown in dropDownList.Items)
        {
            if (dropdown.Selected)
            {
                foreach (Customer customer in Customer.GetAllCustomers())
                {
                    if (customer.ToString() == dropdown.Text)//if selected person info is matached to the list content 
                    {
                        rblFromAccount.Items[0].Text = customer.Checking.ToString();//labels in axps file to assign the money from checking class
                        rblFromAccount.Items[1].Text = customer.Saving.ToString();

                    }//if

                }//foreach
            }//if


        }//foreach


    }//page load




    protected void btnNext_Click(object sender, EventArgs e)
    {

        Session["AmountTransfer"] = TextBoxamount.Text;



        Response.Redirect("FundTransferTo.aspx");
    }

    protected void rblFromAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        string valueSelected = dropDownList.SelectedValue;

        Session["transferorSelection"] = valueSelected;
        int CustomerId = int.Parse(valueSelected);

        Customer selectedCustomer = Customer.GetCustomerById(CustomerId);

        
        if (rblFromAccount.Items[0].Selected)
        {
            Session["btnRadio"] = selectedCustomer.Checking.ToString();

            if(selectedCustomer.Status == CustomerStatus.REGULAR)

                if (selectedCustomer.Checking.Balance > CheckingAccount.MaxTransferAmount)
                
                    RangeValidatorAmount.MaximumValue = CheckingAccount.MaxTransferAmount.ToString();
                
            else
                
                    RangeValidatorAmount.MaximumValue = selectedCustomer.Checking.Balance.ToString();
                
            else
            {
                RangeValidatorAmount.MaximumValue = selectedCustomer.Checking.Balance.ToString();//preminum
            }
        }
        else if (rblFromAccount.Items[1].Selected)
        {


            Session["btnRadio"] = selectedCustomer.Saving.ToString();
            RangeValidatorAmount.MaximumValue = selectedCustomer.Saving.Balance.ToString();
        }
        //if










    }
}






