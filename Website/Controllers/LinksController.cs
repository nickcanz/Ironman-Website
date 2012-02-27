using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Views.Photos {
  public class LinksController : Controller {
    public ActionResult Index() {

      var businesses = new List<Business> {
        new Business {
          Name = "Accent Signs LLC",
          Address = new List<string> {
            "317 Courtland Ave",
            "Stamford, CT 06906",
          },
          Phone = "(203) 975-8688",
          Fax = "(203) 358-0849",
          Website = "http://www.accent-signs.com",
          Testimonial = @"
            Very Professional, Stands by his work! Hands down the best signage 
            company in Fairfield County!"
        },
        new Business {
          Name = "Construction Solutions Group",
          Address = new List<string> {
            "30 Huckleberry Hallow",
            "Stamford, CT 06903",
          },
          Phone = "(203) 595-9822",
          Fax = "(203) 968-0254",
          Website = "http://www.theconstructionsolutionsgroup.com",
          Testimonial = @"
            Professional and honest! In house Architect and well known and respected 
            in the community!"
        },
        new Business {
          Name = "Dilamar & Sons Landscaping, Inc.",
          Address = new List<string> {
            "48 Pepper Ridge Rd",
            "Stamford, CT 06905",
          },
          Phone = "(203) 322-7398",
          Fax = "(203) 322-7398",
          Website = "http://www.dilamarandson.com",
          Testimonial = @"
            Landscape Design, Reliable, Reasonable. All around good company."
        },
        new Business {
          Name = "Shaw Welding Supply, Inc.",
          Address = new List<string> {
            "671 Fair St.",
            "Carmel, NY 10512-3010",
          },
          Phone = "(845) 878-6700",
          Fax = "(845) 878-7875",
          Website = "http://www.shawweldingsupply.com",
          Testimonial = @"
            This is the only welding supply company I deal with, no other welding supply 
            can touch there service and knowledge! I’ve bought from them over 20 years now!"
        },
        new Business {
          Name = "Portanova Excavating LLC",
          Address = new List<string> {
            "1090 Westover Rd",
            "Stamford, CT 06902",
          },
          Phone = "(203) 359-0604",
          Fax = "(203) 327-5068",
          Testimonial = @"
            Dave and Mike are safe, dependable and  honest! The best excavating company 
            in lower Fairfield County!"
        },
        new Business {
          Name = "Levine Automotive & Truck",
          Address = new List<string> {
            "4 New Canaan Ave",
            "Norwalk, CT 06855",
          },
          Phone = "(203) 324-7372",
          Fax = "(203) 840-0310",
          Website = "http://www.levineautoparts.com",
          Testimonial = @"
            Very pleasant to deal with . They do there best to get your parts fast. 
            Multiple stores, closest to Stamford is Norwalk!"
        },
      };

      return View();
    }
  }
}
