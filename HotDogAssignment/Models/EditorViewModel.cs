using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotDogAssignment.Models
{
    public class EditorViewModel
    {
        public string ProfilePic { get; set; }
        public string FavoriteDog { get; set; }
        public string LastDog { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}