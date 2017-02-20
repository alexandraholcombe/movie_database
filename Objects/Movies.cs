using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace Catalog.Objects
{
  public class Movie
  {
    private string _name;
    private int _id = 0;

    public Movie(string newName, int newId=0)
    {
      _name = newName;
      _id = newId;
    }

    public static void DeleteAll()
    {
      SqlConnection connection = DB.Connection();
      connection.Open();

      SqlCommand command = new SqlCommand("DELETE FROM movies;", connection);
      command.ExecuteNonQuery();
      connection.Close();
    }

    public static List<Movie> GetAll()
    {
      List<Movie> allMovies = new List<Movie>{};

      SqlConnection connection = DB.Connection();
      connection.Open();

      SqlCommand command = new SqlCommand("SELECT * FROM movies", connection);
      SqlDataReader rdr = command.ExecuteReader();

      while(rdr.Read())
      {
        int movieId = rdr.GetInt32(0);
        string movieName = rdr.GetString(1);
        Movie newMovie = new Movie(movieName, movieId);
        allMovies.Add(newMovie);
      }
      return allMovies;
    }


    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetId()
    {
      return _id;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }


  }
}
