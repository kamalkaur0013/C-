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

        lblError.Visible = true;
        studentInfo.Visible = false;
        form1.Visible = true;



        // if i want to display my list before submit button
        if (IsPostBack == false)
        {
            // creating new list 
           // List<Course> CheckList = new List<Course>();

            // calling given list contents in new list
            //CheckList = Helper.GetCourses();
            
            // to display the list
            foreach (Course c in Helper.GetCourses())
            {
                // calling ginen method from course class
                c.ToString();

                CheckBoxList.Items.Add(c.ToString());


            } // END of foreach 

        }//end of Ispost



    }

    protected void ValidateForm(){

        var studentName = txtStudentName.Text;

        var studentType = pnlStudentType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        if (studentType == null)
            return;

        Student student =null;


        if (studentType == btuFulltime)
        {
            student = new FullTimeStudent(studentName);
         }

        else if(studentType == btuparttime)
        {
            student = new PartTimeStudent(studentName);
        }
        else
        {
            student = new CoopStudent(studentName);
        }
        var error = false;

        for (var i = 0; i < CheckBoxList.Items.Count; i++)
        {
            if (!CheckBoxList.Items[i].Selected)
                continue;
            try
            {
                student.addCourse(Helper.GetCourses()[i]);//add course is taken from full time class
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
                error = true;
            }
           
            
           // lblError.Visible = false;
        }

        if (!error)
        {
            StudentInfo(student, studentType.Text);
        }


    }//validate form


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        ValidateForm();
        //form1.Visible = false;
    }

    protected void StudentInfo(Student student, string type)
    {
        lblStudentInfoName.Text = student.Name;
        lblStudentInfoType.Text = student.ToString();

        studentInfo.Visible = true;


        var tableHead = new TableHeaderRow();
        tblCourses.Rows.Add(tableHead);// tblCourse is id from aspx file of table

        var tableHeadCellCode = new TableHeaderCell();
        var tableHeadCellTitle = new TableHeaderCell();
        var tableHeadCellHours = new TableHeaderCell();
        var tableHeadCellFee = new TableHeaderCell();

        tableHeadCellCode.Text = "Course Code";
        tableHeadCellTitle.Text = "Course Title";
        tableHeadCellHours.Text = "Weekly Hours";
        tableHeadCellFee.Text = "Fee Payable";

        tableHead.Cells.Add(tableHeadCellCode);
        tableHead.Cells.Add(tableHeadCellTitle);
        tableHead.Cells.Add(tableHeadCellHours);
        tableHead.Cells.Add(tableHeadCellFee);

        foreach (Course course in student.getEnrolledCourses())
        {
            // Start creating the table rows
            var tableRow = new TableRow();
            tblCourses.Rows.Add(tableRow);

            // Now the table cells
            var tableCellCode = new TableCell();
            var tableCellTitle = new TableCell();
            var tableCellHours = new TableCell();
            var tableCellFee = new TableCell();

            tableCellCode.Text = course.Code;
            tableCellTitle.Text = course.Title;
            tableCellHours.Text = Convert.ToString(course.WeeklyHours);
            tableCellFee.Text = Convert.ToString(String.Format("{0:C0}", course.Fee));

            tableRow.Cells.Add(tableCellCode);
            tableRow.Cells.Add(tableCellTitle);
            tableRow.Cells.Add(tableCellHours);
            tableRow.Cells.Add(tableCellFee);
        }
        // Generate the table footer
        var tableFoot = new TableRow();
        tblCourses.Rows.Add(tableFoot);

        var tableFootTotalLabel = new TableCell();//total text
        var tableFootTotalRows = new TableCell();//total hours
        var tableFootTotal = new TableCell();//total fee

        tableFootTotalLabel.Text = "Total";
        tableFootTotalLabel.HorizontalAlign = HorizontalAlign.Right;
        tableFootTotalLabel.ColumnSpan = 2;
        tableFootTotalRows.Text = Convert.ToString(student.totalWeeklyHours());
        tableFootTotal.Text = Convert.ToString(String.Format("{0:C0}", student.feePayable()));

        tableFoot.Cells.Add(tableFootTotalLabel);
        tableFoot.Cells.Add(tableFootTotalRows);
        tableFoot.Cells.Add(tableFootTotal);



    }








}//end of class



