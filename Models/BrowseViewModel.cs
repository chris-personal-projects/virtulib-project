using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtulib_project.Models
{
    public class BrowseViewModel : ObservableObject
    {
        public DialogViewModel BookDialog { get; private set; }

        public BrowseViewModel()
        {
            BookDialog = new DialogViewModel();
        }

        public void SetBookDialog(object dialog)
        {
            BookDialog.DialogObject = dialog;
            BookDialog.IsShow = !BookDialog.IsShow; // Toggle the Dialog on or off
        }
    }
}
