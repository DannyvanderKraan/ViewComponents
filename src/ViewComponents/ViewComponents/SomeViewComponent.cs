using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.ViewFeatures;
using ViewComponents.Models;

namespace ViewComponents.ViewComponents
{
    public class SomeViewComponent : ViewComponent
    {
	    private SomeRepository SomeRepository { get; set; }

		[ViewContext]
		private ViewContext VwContext { get; set; }

	    public SomeViewComponent(SomeRepository someRepository)
	    {
		    if(someRepository == null) throw new ArgumentNullException(nameof(someRepository));
		    SomeRepository = someRepository;
	    }
	    public IViewComponentResult Invoke()
	    {
		    return View(SomeRepository.GetSomeStuff());
	    }

		public IViewComponentResult Invoke(string id)
		{
			return View(SomeRepository.GetSomeStuff().Where(s => s.Id.Equals(id)).ToList());
		}

	}
}
