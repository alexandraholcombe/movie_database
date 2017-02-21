using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace Catalog.Objects
{
  public class Catalog
  {
    private int _id;
    private string _movieTitle;
    private List<Actor> _movieActors;

    public Catalog(int id=0, string movieTitle, List<Actor> movieActors)
    {
      _id = id;
      _movieTitle = movieTitle;
      _movieActors = movieActors;
    }
  }
}
