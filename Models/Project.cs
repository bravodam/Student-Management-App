﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public ProjectStatus Status { get; set; }
        public string Link { get; set; }
        public StudentClass Student { get; set; }



    }
}
