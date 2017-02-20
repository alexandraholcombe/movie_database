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
    public void Test_MovieDatabaseEmptyAtFirst()
    {
      //Arrange Act
      int result = Movie.GetAll().Count;

      //Assert
      Assert.Equal(0,result);
    }
  }
}
