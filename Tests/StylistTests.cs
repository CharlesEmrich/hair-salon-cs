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
    [Fact]
    public void Equals_ReturnsTrueForEquivalentObjects()
    {
      //Arrange / Act
      Stylist testCase1 = new Stylist("Velma Wilburt");
      Stylist testCase2 = new Stylist("Velma Wilburt");
      //Assert
      Assert.Equal(testCase1, testCase2);
    }
    [Fact]
    public void Save_SavesStylistToDatabase()
    {
      //Arrange
      Stylist testCase = new Stylist("Mindy Demby");
      //Act
      testCase.Save();
      List<Stylist> actual = Stylist.GetAll();
      List<Stylist> expected = new List<Stylist>{testCase};
      //Assert
      Assert.Equal(expected, actual);
    }
  }
}
