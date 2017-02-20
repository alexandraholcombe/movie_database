using Xunit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Catalog.Objects
{
  public class ActorTest: IDisposable
  {
    public ActorTest()
    {
      DBConfiguration.ConnectionString = "Data Source = (localdb)\\mssqllocaldb;Initial Catalog=MovieCatalog_test;Integrated Security=SSPI;";
    }

    public void Dispose()
    {
      Actor.DeleteAll();
    }

    [Fact]
    public void Test_ActorTableEmptyAtFirst()
    {
      //Arrange Act
      int result = Actor.GetAll().Count;

      //Assert
      Assert.Equal(0, result);
    }
  }
}
