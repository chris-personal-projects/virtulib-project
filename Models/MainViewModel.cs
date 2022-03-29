using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace virtulib_project.Models
{
    public class MainViewModel : ObservableObject
    {
        private string dataPath = @"/data/bookdata.json";
        private VirtulibBookModel[] bookList;

        public DialogViewModel MainDialog { get; private set; }

        public MainViewModel()
        {
            MainDialog = new DialogViewModel();
            // ParseBookData();
            
        }

        public void SetDialog(object dialog)
        {
            MainDialog.DialogObject = dialog;
            MainDialog.IsShow = !MainDialog.IsShow; // Toggle the Dialog on or off
        }

        //private void ParseBookData()
        //{
        //    using(StreamReader file = File.OpenText(dataPath))
        //    {
        //        string jsonstring = file.ReadToEnd();
        //        JObject jsonObj = JObject.Parse(jsonstring);
        //        var jsonArray = JArray.Parse(jsonObj["virtulib_data"].ToString());
        //        bookList = jsonArray.ToObject<List<VirtulibBookModel>>().ToArray();

        //        Console.WriteLine(bookList[0]);
        //    }

        //}
    }
}
