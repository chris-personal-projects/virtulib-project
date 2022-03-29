using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtulib_project.Models
{
    public class VirtulibBookModel
    {
        private string _title;
        private string _itemType;
        private string _author;
        private string imageUrl;
        private string _publishDate;
        private string _mediaType;
        private float _reviewScore;
        private int _copies;
        private string _description;
        private string _category;

        public string Title { get => _title; set => _title = value; }
        public string ItemType { get => _itemType; set => _itemType = value; }
        public string Author { get => _author; set => _author = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string PublishDate { get => _publishDate; set => _publishDate = value; }
        public string MediaType { get => _mediaType; set => _mediaType = value; }
        public float ReviewScore { get => _reviewScore; set => _reviewScore = value; }
        public int Copies { get => _copies; set => _copies = value; }
        public string Description { get => _description; set => _description = value; }
        public string Category { get => _category; set => _category = value; }
    }
}
