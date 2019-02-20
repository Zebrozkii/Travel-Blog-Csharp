using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Blog.Models
{
  public class BlogMain
  {
    private string _cityName;
    private static List<BlogMain> _instances=new List<BlogMain>{};

    public BlogMain(string cityName){
      _cityName=cityName;
      _instances.Add(this);
    }
    public void SetCityName(string newCity)
    {
      _cityName=newCity;
    }
    public string GetCityName()
    {
      return _cityName;
    }

    public static List<BlogMain> GetAll()
    {
      return _instances;
    }


    //public string Filter(string sentence)
    //{
    //  Regex Filter = new Regex(@"[^\w\s\d]");
      //string result = Filter.Replace(sentence, "");
      //return result;
    //}

  }
}
