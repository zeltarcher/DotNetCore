﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Trailer
    {
        public int Id { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }

        //FK
        public int MovieId { get; set; }        
        public ICollection<Movie> Movie { get; set; }//navigation prop
    }
}
