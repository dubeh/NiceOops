using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLabs
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
            Image1.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
            Image1.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
            Image1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
            Image1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
            Image1.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int err = new int();
            string[] splits = screen.Text.Split('/', '*', '+', '-');
            if (splits.Length > 1 && splits[1] == "")
            {
                err = 1;
            }
            if (err != 1)
            {
                int[] x;
                float y = new float();
                int z = new int();
                if (screen.Text.Contains('*'))
                {
                    z = 1;
                }
                else if (screen.Text.Contains('/'))
                {
                    z = 2;
                }
                else if (screen.Text.Contains('+'))
                {
                    z = 3;
                }
                else if (screen.Text.Contains('-'))
                {
                    z = 4;
                }
                
                   // string[] splits = screen.Text.Split('/', '*', '+', '-');
                    if (splits.Length > 1 && splits[1] !="")
                    {
                        var n1 = Convert.ToInt32(splits[0]);
                        var n2 = Convert.ToInt32(splits[1]);

                        switch (z)
                        {
                            case 1:
                                y = n1 * n2;
                                break;
                            case 2:
                                y = n1 / n2;
                                break;
                            case 3:
                                y = n1 + n2;
                                break;
                            case 4:
                                y = n1 - n2;
                                break;
                            default:
                                break;

                        }

                        screen.Text = y.ToString();
                    }
                
                screen.Text += "/";
            }
            else
            {
                Image1.Visible = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           
                screen.Text += "4";
            Image1.Visible = false;

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int err = new int();
            string[] splits = screen.Text.Split('/', '*', '+', '-');
            if (splits.Length > 1 && splits[1] == "")
            {
                err = 1;
            }
            if (err != 1)
            {
                int[] x;
                float y = new float();
                int z = new int();
                if (screen.Text.Contains('*'))
                {
                    z = 1;
                }
                else if (screen.Text.Contains('/'))
                {
                    z = 2;
                }
                else if (screen.Text.Contains('+'))
                {
                    z = 3;
                }
                else if (screen.Text.Contains('-'))
                {
                    z = 4;
                }
                
                    //string[] splits = screen.Text.Split('/', '*', '+', '-');
                    if (splits.Length > 1 )
                    {
                        var n1 = Convert.ToInt32(splits[0]);
                        var n2 = Convert.ToInt32(splits[1]);

                        switch (z)
                        {
                            case 1:
                                y = n1 * n2;
                                break;
                            case 2:
                                y = n1 / n2;
                                break;
                            case 3:
                                y = n1 + n2;
                                break;
                            case 4:
                                y = n1 - n2;
                                break;
                            default:
                                break;

                        }

                        screen.Text = y.ToString();
                    }
                
                screen.Text += "*";
            }
            else
            {
                Image1.Visible = true;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
           
            

                screen.Text += "7";
            Image1.Visible = false;

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            
              
                screen.Text += "8";
            Image1.Visible = false;

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
           
                
                screen.Text += "9";
            Image1.Visible = false;

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            int err = new int();
            string[] splits = screen.Text.Split('/', '*', '+', '-');
            if (splits.Length > 1 && splits[1] == "")
            {
                err = 1;
            }
            if (err != 1)
            {
                int[] x;
                float y = new float();
                int z = new int();
                if (screen.Text.Contains('*'))
                {
                    z = 1;
                }
                else if (screen.Text.Contains('/'))
                {
                    z = 2;
                }
                else if (screen.Text.Contains('+'))
                {
                    z = 3;
                }
                else if (screen.Text.Contains('-'))
                {
                    z = 4;
                }

               
                   // string[] splits = screen.Text.Split('/', '*', '+', '-');
                    if (splits.Length > 1)
                    {
                        var n1 = Convert.ToInt32(splits[0]);
                        var n2 = Convert.ToInt32(splits[1]);

                        switch (z)
                        {
                            case 1:
                                y = n1 * n2;
                                break;
                            case 2:
                                y = n1 / n2;
                                break;
                            case 3:
                                y = n1 + n2;
                                break;
                            case 4:
                                y = n1 - n2;
                                break;
                            default:
                                break;

                        }

                        screen.Text = y.ToString();
                    }
                
               
                screen.Text += "+";
            }
            else
            {
                Image1.Visible = true;
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            
              
                screen.Text = " ";
            Image1.Visible = false;

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            
                
                screen.Text += "0";
            Image1.Visible = false;

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            int err = new int();
            string[] splits = screen.Text.Split('/', '*', '+', '-');
            if (splits.Length > 1 && splits[1] == "")
            {
                err = 1;
            }
            if (err!=1)
            {
                int[] x;
                float y = new float();
                int z = new int();
                float n1 = new float();
                float n2 = new float();
                if (screen.Text.Contains('*'))
                {
                    z = 1;
                }
                else if (screen.Text.Contains('/'))
                {
                    z = 2;
                }
                else if (screen.Text.Contains('+'))
                {
                    z = 3;
                }
                else if (screen.Text.Contains('-'))
                {
                    z = 4;
                }

                // string[] splits = screen.Text.Split('/', '*', '+', '-');
                if (splits.Length>2 && splits[0]=="")
                {
                     n1 = - Convert.ToInt32(splits[1]);
                     n2 = Convert.ToInt32(splits[2]);

                    switch (z)
                    {
                        case 1:
                            y = n1 * n2;
                            break;
                        case 2:
                            y = n1 / n2;
                            break;
                        case 3:
                            y = n1 + n2;
                            break;
                        case 4:
                            y = n1 - n2;
                            break;
                        default:
                            break;

                    }
                }
                if (splits.Length < 2 && splits.Length>1)
                {
                    n1 = Convert.ToInt32(splits[0]);
                    n2 = Convert.ToInt32(splits[1]);

                    switch (z)
                    {
                        case 1:
                            y = n1 * n2;
                            break;
                        case 2:
                            y = n1 / n2;
                            break;
                        case 3:
                            y = n1 + n2;
                            break;
                        case 4:
                            y = n1 - n2;
                            break;
                        default:
                            break;

                    }
                }

                       

                        screen.Text = y.ToString();
                    
                    
                
                screen.Text += "-";
            }
            else
            {
                Image1.Visible = true;
            }
            
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            int[] x;
            float y = new float();
            int z = new int();
            if (screen.Text.Contains('*'))
            {
                z = 1;
            }
            else if (screen.Text.Contains('/'))
            {
                z = 2;
            }
            else if (screen.Text.Contains('+'))
            {
                z = 3;
            }
            else if (screen.Text.Contains('-'))
            {
                z = 4;
            }
            string[] splits =screen.Text.Split('/','*','+','-');
            var n1 = Convert.ToInt32(splits[0]);
            var n2 = Convert.ToInt32(splits[1]);
            
            switch (z)
            {
                case 1: y = n1 * n2;
                    break;
                case 2:
                    y = n1/n2;
                    break;
                case 3:
                    y = n1+n2;
                    break;
                case 4: y = n1-n2;
                    break;
                default:
                    break;

            }

            screen.Text = y.ToString();
            
                Image1.Visible = false;
            

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
        }
    }
}