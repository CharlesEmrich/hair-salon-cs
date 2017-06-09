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
      Stylist.DeleteAll();
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
    public void Constructor_TakesStringforStylistId()
    {
      //Arrange / Act
      Stylist testStylist = new Stylist("Mandy Lopatka");
      testStylist.Save();
      Client testCase1 = new Client("James Wingate", "Mandy Lopatka");
      Client testCase2 = new Client("James Wingate", testStylist.GetId());
      //Assert
      Assert.Equal(testCase2, testCase1);
    }
    [Fact]
    public void Equals_ReturnsTrueForEquivalentObjects()
    {
      //Arrange / Act
      Client testCase1 = new Client("John Bugward", 0);
      Client testCase2 = new Client("John Bugward", 0);
      //Assert
      Assert.Equal(testCase1, testCase2);
    }
    [Fact]
    public void Save_SavesClientToDatabase()
    {
      //Arrange
      Client testCase = new Client("Wade Dilby", 0);
      //Act
      testCase.Save();
      List<Client> actual = Client.GetAll();
      List<Client> expected = new List<Client>{testCase};
      //Assert
      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Update_UpdatesClientInDatabase()
    {
      //Arrange
      Client testCase = new Client("Hrothgar Gunnirson", 0);
      testCase.Save();
      string newName = "Joe Smith";
      //Act
      testCase.Update(newName);
      string actual = testCase.GetName();
      //Assert
      Assert.Equal(newName, actual);
    }
    [Fact]
    public void Delete_RemovesClientFromDatabase()
    {
      //Arrange
      Client testCase1 = new Client("Jorge Kleems", 0);
      testCase1.Save();
      Client testCase2 = new Client("Jimson Clegway", 0);
      testCase2.Save();
      //Act
      Client.Delete(testCase1.GetId());
      int actual = Client.GetAll().Count;
      int expected = 1;
      //Assert
      Assert.Equal(expected, actual);
    }
  }
}
