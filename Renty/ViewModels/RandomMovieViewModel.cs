using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renty.Models;

namespace Renty.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie{ get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}