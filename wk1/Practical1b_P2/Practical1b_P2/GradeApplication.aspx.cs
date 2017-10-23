using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1b_P2.BLL
{
    public partial class GradeApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngrade_Click(object sender, EventArgs e)
        {
            // Initialise student 1 to 5
            Double s1 = 0;
            Double s2 = 0;
            Double s3 = 0;
            Double s4 = 0;
            Double s5 = 0;

            // Read stud score from tb 
            try
            {
                s1 = Convert.ToDouble(tbstud1.Text);
                s2 = Convert.ToDouble(tbstud2.Text);
                s3 = Convert.ToDouble(tbstud3.Text);
                s4 = Convert.ToDouble(tbstud4.Text);
                s5 = Convert.ToDouble(tbstud5.Text);
            }
            catch(FormatException fe)
            {
                //error msg
                Response.Write("<script>alert('Format exception error')</script>");
            }
            // Compute sum, avg, min and max 
            Double sum = s1 + s2 + s3 + s4 + s5;
            Double avg = sum / 5;
            lblavg.Text = avg.ToString();

            // lowest
            Double min1 = System.Math.Min(s1, s2);
            Double min2 = System.Math.Min(s3, s4);
            Double min3 = System.Math.Min(min1, min2);
            Double min4 = System.Math.Min(min3, s5);
            lblavg1.Text = min4.ToString();
            // highest
            Double max1 = System.Math.Max(s1, s2);
            Double max2 = System.Math.Max(s3, s4);
            Double max3 = System.Math.Max(max1, max2);
            Double max4 = System.Math.Max(max3, s5);
            lblavg0.Text = max4.ToString();

            string p1, p2, p3, p4, p5;
            string g1, g2, g3, g4, g5;
            if (s1 >= 50)
            {
                p1 = "Pass";
                g1 = "D";
                lblpass1.Text = p1;
                lblstud1grade.Text = g1;
            }
            else if (s1 >= 60)
            {
                p1 = "Pass";
                g1 = "C";
                lblpass1.Text = p1;
                lblstud1grade.Text = g1;
            }
            else if (s1 >= 70)
            {
                p1 = "Pass";
                g1 = "B";
                lblpass1.Text = p1;
                lblstud1grade.Text = g1;
            }
            else if (s1 >= 80)
            {
                p1 = "Pass";
                g1 = "A";
                lblpass1.Text = p1;
                lblstud1grade.Text = g1;
            }
            else
            {
                p1 = "Fail";
                g1 = "F";
                lblpass1.Text = p1;
                lblstud1grade.Text = g1;
            }



            if (s2 >= 50)
            {
                p2 = "Pass";
                g2 = "D";
                lblpass2.Text = p2;
                lblstud2grade.Text = g2;
            }
            else if (s2 >= 60)
            {
                p2 = "Pass";
                g2 = "C";
                lblpass2.Text = p2;
                lblstud2grade.Text = g2;
            }
            else if (s2 >= 70)
            {
                p2 = "Pass";
                g2 = "B";
                lblpass2.Text = p2;
                lblstud2grade.Text = g2;
            }
            else if (s2 >= 80)
            {
                p2 = "Pass";
                g2 = "A";
                lblpass2.Text = p2;
                lblstud2grade.Text = g2;
            }
            else
            {
                p2 = "Fail";
                g2 = "F";
                lblpass2.Text = p2;
                lblstud2grade.Text = g2;
            }



            if (s3 >= 50)
            {
                p3 = "Pass";
                g3 = "D";
                lblpass3.Text = p3;
                lblstud3grade.Text = g3;
            }
            else if (s3 >= 60)
            {
                p3 = "Pass";
                g3 = "C";
                lblpass3.Text = p3;
                lblstud3grade.Text = g3;
            }
            else if (s3 >= 70)
            {
                p3 = "Pass";
                g3 = "B";
                lblpass3.Text = p3;
                lblstud3grade.Text = g3;
            }
            else if (s3 >= 80)
            {
                p3 = "Pass";
                g3 = "A";
                lblpass3.Text = p3;
                lblstud3grade.Text = g3;
            }
            else
            {
                p3 = "Fail";
                g3 = "F";
                lblstud3grade.Text = g3;
                lblpass3.Text = p3;
            }




            if (s4 >= 50)
            {
                p4 = "Pass";
                g4 = "D";
                lblstud4grade.Text = g4;
                lblpass4.Text = p4;
            }
            else if (s4 >= 60)
            {
                p4 = "Pass";
                g4 = "C";
                lblstud4grade.Text = g4;
                lblpass4.Text = p4;
            }
            else if (s4 >= 70)
            {
                p4 = "Pass";
                g4 = "B";
                lblstud4grade.Text = g4;
                lblpass4.Text = p4;
            }
            else if (s4 >= 80)
            {
                p4 = "Pass";
                g4 = "A";
                lblstud4grade.Text = g4;
                lblpass4.Text = p4;
            }
            else
            {
                p4 = "Fail";
                g4 = "F";
                lblstud4grade.Text = g4;
                lblpass4.Text = p4;
            }




            if (s5 >= 50)
            {
                p5 = "Pass";
                g5 = "D";
                lblstud5grade.Text = g5;
                lblpass5.Text = p5;
            }
            else if (s5 >= 60)
            {
                p5 = "Pass";
                g5 = "C";
                lblstud5grade.Text = g5;
                lblpass5.Text = p5;
            }
            else if (s5 >= 70)
            {
                p5 = "Pass";
                g5 = "B";
                lblstud5grade.Text = g5;
                lblpass5.Text = p5;
            }
            else if (s5 >= 80)
            {
                p5 = "Pass";
                g5 = "A";
                lblstud5grade.Text = g5;
                lblpass5.Text = p5;
            }
            else
            {
                p5 = "Fail";
                g5 = "F";
                lblstud5grade.Text = g5; 
                lblpass5.Text = p5;
            }

        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            // clear student input boxes 
            tbstud1.Text = "";
            tbstud2.Text = "";
            tbstud3.Text = "";
            tbstud4.Text = "";
            tbstud5.Text = "";
            // clear scores 
            lblavg.Text = "";
            lblavg0.Text = "";
            lblavg1.Text = "";
            // clear grades
            lblstud1grade.Text = "";
            lblstud2grade.Text = "";
            lblstud3grade.Text = "";
            lblstud4grade.Text = "";
            lblstud5grade.Text = "";
            // clear status 
            lblpass1.Text = "";
            lblpass2.Text = "";
            lblpass3.Text = "";
            lblpass4.Text = "";
            lblpass5.Text = "";
        }
    }
}