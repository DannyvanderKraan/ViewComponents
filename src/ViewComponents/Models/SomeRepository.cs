using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class SomeRepository
    {
	    public List<SomeStuff> GetSomeStuff()
	    {
		    return new List<SomeStuff>()
		    {
			    new SomeStuff() {Id = "97CFB273-7388-4D85-85F1-061297C5E9A5"},
			    new SomeStuff() {Id = "6BB03A93-FFC0-4F5E-BED6-DC3D87C3FCFD"}
		    };
	    }
    }
}
