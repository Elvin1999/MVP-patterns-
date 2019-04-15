using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form,IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Show()
        {
            MessageBox.Show("Test");
        }
    }
}
