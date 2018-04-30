using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;
using WorldData.Models;
using Microsoft.AspNetCore.Mvc;


namespace WorldDataTests
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void TestCountry()
        {
        List<Country> listIndia = Country.GetAllCountryInfo("India");

        Assert.AreEqual("India", listIndia[0].GetName());
        }
    }
}
