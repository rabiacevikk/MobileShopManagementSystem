using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace MobileShop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

       
   

private void btnLogin_Click(object sender, EventArgs e)
        {
                if (txtUsername.Text == "rabiacevikk" && txtPassword.Text == "pass")
                {

                    this.Hide();
                Form1 fr = new Form1();
                    fr.Show();

                }
                else
                {
                    lblShow.Visible = true;
                }
            }



        
    }
    }


      
    

