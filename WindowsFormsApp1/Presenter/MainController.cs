using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenter
{
    class MainController
    {
        IView view;
        public MainController(IView view)
        {
            this.view = view;
        }

        public void ShowDialog()
        {
            view.Show();
        }


    }
}
