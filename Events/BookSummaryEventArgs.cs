using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtulib_project.Events
{
    public class BookSummaryEventArgs : EventArgs
    {
        private String text;

        //Did not implement a "Set" so that the only way to give it the Text value is in the constructor
        public String Text
        {
            get { return text; }
        }

        public BookSummaryEventArgs(String theText) : base()
        {
            text = theText;
        }
    }
}
