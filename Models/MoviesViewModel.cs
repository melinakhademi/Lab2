using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieLab.Models;

    public class MoviesViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set;}
    }
