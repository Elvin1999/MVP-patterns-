using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
           Model.Model model = new Model.Model() {
                Teacher=new Entities.Teacher()
                {
                    Name="Elvin",
                    Surname="Camalzade"
                },
                Student=new List<Entities.Student>() {
                    new Entities.Student(){
                        Name="Samir",Surname="Osmanov"
                    },
                    new Entities.Student(){
                        Name="Anar",Surname="Ehmedov"
                    }

                    
                }


            };

            new MainController(new Form1(model)).ShowDialog();

        }
    }
}
