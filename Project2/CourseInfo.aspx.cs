using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Project2.Models;

namespace Project2
{
    public partial class CourseInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCourse.Text = Request.QueryString["name"];
            courseName.Text = Request.QueryString["name"];
            txtHeader.Text = Request.QueryString["name"];

            txtTeacher.Text = Request.QueryString["teacher"];

            txtDesc.Text = Request.QueryString["desc"];

            txtYear.Text = Request.QueryString["year"];

            if (string.IsNullOrWhiteSpace(Request.QueryString["year"]))
                courseYear.Text = "";
            else if(int.Parse(Request.QueryString["year"]) == 1)
                courseYear.Text = "First Year";
            else if (int.Parse(Request.QueryString["year"]) == 2)
                courseYear.Text = "Second Year";
            else if (int.Parse(Request.QueryString["year"]) == 3)
                courseYear.Text = "Third Year";
            else if (int.Parse(Request.QueryString["year"]) == 4)
                courseYear.Text = "Fourth Year";
            else if (int.Parse(Request.QueryString["year"]) == 5)
                courseYear.Text = "Fifth Year";

            /*string txt = (string)(Session["name"]);
            txtcourse.Text = txt;
            courseName.Text = txt;*/
        }

        protected void FollowButton_OnClick(object sender, EventArgs e)
        {
            CourseContext cc = new CourseContext();

            string userId = Context.User.Identity.GetUserId();

            var query = from s in cc.Students
                where s.UserId == userId
                select s;

            var query2 = from c in cc.Courses
                where c.CourseName == courseName.Text
                select c;

            foreach (var std in query)
            {
                foreach (var cou in query2)
                {
                    std.Courses.Add(cou);   
                }
            }

            cc.SaveChanges();
        }
    }
}