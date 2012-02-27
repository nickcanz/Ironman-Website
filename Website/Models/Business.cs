using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models {
  public class Business {
    public string Name { get; set; }
    public List<string> Address { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Website { get; set; }
    public string Testimonial { get; set; }
  }
}