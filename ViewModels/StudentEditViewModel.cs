using Code360NEWWEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.ViewModels
{
    public class StudentEditViewModel:StudentCreateViewModel
    {

        public int id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
