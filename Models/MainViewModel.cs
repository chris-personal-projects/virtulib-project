using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace virtulib_project.Models
{
    public class MainViewModel : ObservableObject
    {
        public DialogViewModel MainDialog { get; private set; }

        public MainViewModel()
        {
            MainDialog = new DialogViewModel();
        }

        public void SetDialog(object dialog)
        {
            MainDialog.DialogObject = dialog;
            MainDialog.IsShow = !MainDialog.IsShow; // Toggle the Dialog on or off
        }
    }
}
