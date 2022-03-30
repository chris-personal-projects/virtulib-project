using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtulib_project.Models
{
    public class VirtulibBookModel
    {
        private string _olid;
        private string _title;
        private string _itemType;
        private string _author;

        private string _publishDate;
        private string _mediaType;
        private float _reviewScore;
        private int _copies;
        private string _description;
        private string _image_location;

        public string OLID { get => _olid; set => _olid = value; }
        public string Title { get => _title; set => _title = value; }
        public string Item_Type { get => _itemType; set => _itemType = value; }
        public string Author { get => _author; set => _author = value; }
        public string Publish_Date { get => _publishDate; set => _publishDate = value; }
        public string Media_Type { get => _mediaType; set => _mediaType = value; }
        public float Review_Score { get => _reviewScore; set => _reviewScore = value; }
        public int Copies { get => _copies; set => _copies = value; }
        public string Description { get => _description; set => _description = value; }
        public string Image_Location { get => _image_location; set => _image_location = $@"{value}"; }


    }
}
