using Xunit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HairSalon.Objects;

namespace HairSalon
{
  public class ClientTest : IDisposable
  {
    public ClientTest()
    {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Client.DeleteAll();
    }

    public void GetAll_DatabaseStartsEmpty()
    {
      //Arrange / Act
      int actual = Client.GetAll().Count;
      int expected = 0;
      //Assert
      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Equals_ReturnsTrueForEquivalentObjects()
    {
      //Arrange / Act
      Client testCase1 = new Client("John Bugward");
      Client testCase2 = new Client("John Bugward");
      //Assert
      Assert.Equal(testCase1, testCase2);
    }
    [Fact]
    public void Save_SavesClientToDatabase()
    {
      //Arrange
      Client testCase = new Client("Wade Dilby");
      //Act
      testCase.Save();
      List<Client> actual = Client.GetAll();
      List<Client> expected = new List<Client>{testCase};
      //Assert
      Assert.Equal(expected, actual);
    }
  }
}
