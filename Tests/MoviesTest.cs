using Xunit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Catalog.Objects
{
  public class MovieTest: IDisposable
  {
    public MovieTest()
    {
      DBConfiguration.ConnectionString = "Data Source =(localdb)\\mssqllocaldb;Initial Catalog=MovieCatalog_test;Integrated Security=SSPI;";
    }

    public void Dispose()
    {
      Movie.DeleteAll();
    }

    [Fact]
    public void Test_MovieTableEmptyAtFirst()
    {
      //Arrange Act
      int result = Movie.GetAll().Count;

      //Assert
      Assert.Equal(0,result);
    }

    [Fact]
    public void Test_Save_SavesToDatabase()
    {
      //Arrange
      Movie testMovie = new Movie("JAWS");

      //Act
      testMovie.Save();
      List<Movie> result = Movie.GetAll();
      List<Movie> testList = new List<Movie>{testMovie};

      //Assert
      Assert.Equal(testList[0], result[0]);
    }

  }
}
