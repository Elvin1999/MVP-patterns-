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
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form,IView
    {
        public Model.Model Model { get; set; }
        public Form1(Model.Model model)
        {
            InitializeComponent();
            Model = model;
        }
       

        public void Show()
        {
            ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label labelTeacher = new Label();
            labelTeacher.Size = new Size(300, 100);
            labelTeacher.Location = new Point(100, 100);
            labelTeacher.Text = Model.Teacher.Name+" "+Model.Teacher.Surname;
            labelTeacher.Font = new Font("Comic Sans MS", 16, FontStyle.Italic);

            this.Controls.Add(labelTeacher);
            
        }
    }
}
