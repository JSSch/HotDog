using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogAssignment.Models
{
    public class EditorViewModel
    {
        public string ProfilePic { get; set; }
        public string FavoriteDog { get; set; }
        public string LastDog { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}