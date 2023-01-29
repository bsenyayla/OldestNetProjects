using PersonelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVC.ViewModels
{
    public class DepartmanDetayViewModel
    {
           public Departman Departman { get; set; }
           public List<Personel> PersonelData { get; set; }
    }
}