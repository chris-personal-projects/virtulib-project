using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace virtulib_project.Events
{
    public class SnackbarMessageEventArg : RoutedEventArgs
    {
        private string _snackMessage;

        public SnackbarMessageEventArg(RoutedEvent routedEvent, string snackMessage) : base(routedEvent)
        {
            _snackMessage = snackMessage;
        }

        public string SnackMessage
        {
            get { return _snackMessage; }
        }
    }
}
