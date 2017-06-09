using Xunit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HairSalon.Objects;

namespace HairSalon
{
  public class StylistTest : IDisposable
  {
    public StylistTest()
    {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Stylist.DeleteAll();
    }

    public void GetAll_DatabaseStartsEmpty()
    {
      //Arrange / Act
      int actual = Stylist.GetAll().Count;
      int expected = 0;
      //Assert
      Assert.Equal(expected, actual);
    }
  }
}
