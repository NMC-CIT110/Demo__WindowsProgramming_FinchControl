using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinchAPI;

namespace Demo__Windows_FinchControl
{
    public partial class Form1 : Form
    {
        Finch _myFinch;
        int _speed;


        public Form1()
        {
            Finch myFinch = new Finch();
            myFinch.connect();

            InitializeComponent();
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {

        }

    }
}
