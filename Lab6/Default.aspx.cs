using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack)
        {
            try
            {
                var firstNumber = double.Parse(txtFirstNumber.Text);
                var secondNumber = double.Parse(txtSecondNumber.Text);
                var thirdNumber = double.Parse(txtThirdNumber.Text);

               // ClearResult();

                lblMaximum.Text = "Max is: " + GetMaxNumber(firstNumber, secondNumber, thirdNumber);
                lblMinimum.Text = "Min is: " + GetMinNumber(firstNumber, secondNumber, thirdNumber);
                lblAverage.Text = "Average is: " + GetAvgNumber(firstNumber, secondNumber, thirdNumber);
                lblTotal.Text = "Total is: " + GetSumNumber(firstNumber, secondNumber, thirdNumber);

                //ClearResult();
            }
            catch(Exception ex)

            {
               
                lblerror.Text = ex.Message;
                lblerror.Visible = true;
               // ClearResult();


            }

        }
       else
        {
            lblerror.Visible = false;
        }
      
    }
    protected double GetMaxNumber(double firstNumber, double secondNumber, double thirdNumber)
    {
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            else 

            {
                return thirdNumber;


            }
        }
        else
        
        {
            if (secondNumber > thirdNumber)
                return secondNumber;
            else
                return thirdNumber;
        }
    }
    protected double GetMinNumber(double firstNumber, double secondNumber, double thirdNumber)
    {
        if (firstNumber < secondNumber)
        {
            if (firstNumber <thirdNumber)
            {
                return firstNumber;
            }
            else

            {
                return thirdNumber;


            }
        }
        else

        {
            if (secondNumber < thirdNumber)
                return secondNumber;
            else
                return thirdNumber;
        }
    }
    protected double GetAvgNumber(double firstNumber, double secondNumber, double thirdNumber)
    {
        return ((firstNumber + secondNumber + thirdNumber) / 3); 
    }
    protected double GetSumNumber(double firstNumber, double secondNumber, double thirdNumber)
    {
        return firstNumber + secondNumber + thirdNumber;
    }
       // private void ClearResult()
       // {


      
        
           // lblMaximum.Text += "";
            //lblMinimum.Text += "";
            //lblAverage.Text += "";
            //lblTotal.Text += "";
            //lblerror.Visible = false;
     

       // }
    
}