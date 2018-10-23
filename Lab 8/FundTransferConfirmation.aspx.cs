using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransferConfirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string transferorSelected = Session["transferorSelection"].ToString();
        string AmountSelected = Session["AmountTransfer"].ToString();
        string AccountSelected = Session["btnRadio"].ToString();
        string transfereeSelected = Session["transfereeSelection"].ToString();
        string AccountSelectedTo = Session["btnRadioTo"].ToString();

        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                lbltransfrorName.Text += customer.ToString();
                lbltransfrorAccount.Text += AccountSelected.ToString();
                lblAmount.Text += AmountSelected.ToString();
                

            }//if
            else if(customer.Id.ToString() == transfereeSelected.ToString())
            {
                lbltransfereeName.Text += customer.ToString();
                lbltransfereeAccount.Text += AccountSelectedTo.ToString();
            }
        }
    }




    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("FundTransferTo.aspx");
    }

    protected void BtnComplete_Click(object sender, EventArgs e)
    {
        string transferorSelected = Session["transferorSelection"].ToString();
        string AmountSelected = Session["AmountTransfer"].ToString();
        double Amount = double.Parse(AmountSelected);
        string AccountSelected = Session["btnRadio"].ToString();
        string transfereeSelected = Session["transfereeSelection"].ToString();
        string AccountSelectedTo = Session["btnRadioTo"].ToString();

        Transaction transaction = new Transaction(Amount);
        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                if(AccountSelected == customer.Checking.ToString())
                {
                    customer.Checking.Withdraw(transaction);

                    Session["BalanceTransferor"] = customer.Checking.ToString();
                }
                 else if (AccountSelected == customer.Saving.ToString())
                {
                    customer.Saving.Withdraw(transaction);

                    Session["BalanceTransferor"] = customer.Saving.ToString();
                }

            }//if
            else if (customer.Id.ToString() == transfereeSelected.ToString())
            {
                if (AccountSelectedTo == customer.Checking.ToString())
                {
                    customer.Checking.Deposit(transaction);

                    Session["BalanceTransferee"] = customer.Checking.ToString();
                }
                else if (AccountSelectedTo == customer.Saving.ToString())
                {
                    customer.Saving.Deposit(transaction);

                    Session["BalanceTransferee"] = customer.Saving.ToString();
                }

            }
        }
    

    Response.Redirect("FundTransferResult.aspx");
    }
}