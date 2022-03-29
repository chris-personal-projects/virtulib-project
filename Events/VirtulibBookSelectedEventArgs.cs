using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using virtulib_project.Models;

namespace virtulib_project.Events
{
    public class VirtulibBookSelectedEventArgs : RoutedEventArgs
    {
        private VirtulibBookModel virtulibBook;

        public VirtulibBookSelectedEventArgs(RoutedEvent routedEvent,
                                      VirtulibBookModel virtulibBook)
        : base(routedEvent)
        {
            this.virtulibBook = virtulibBook;
        }

        public VirtulibBookModel VirtulibBook
        {
            get
            {
                return virtulibBook;
            }
        }
    }
}
