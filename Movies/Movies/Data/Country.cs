using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
