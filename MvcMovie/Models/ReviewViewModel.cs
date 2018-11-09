using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewViewModel
    {
        public List<MvcMovie.Models.Review> ReviewerName { get; set; }
        public List<String> ReviewBody { get; set; }
    }
}
