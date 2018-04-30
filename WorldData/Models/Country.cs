using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using WorldData.Models;

namespace WorldData.Models
{
    public class Country
    {
        private int _code;
        private string _name;
        private string _continent;
        private string _region;
        private float _surfaceArea;
        private int _indepYear;
        private int _population;
        private float _lifeExpectancy;
        private float _gnp;
        private float _gnpOld;
        private string _localName;
        private string _governmentForm;
        private string _headOfState;
        private int _capital;

        public Country(int code = 0, string name, string continent, string region, float surfaceArea, int indepYear, int population, float lifeExpectancy, float gnp, float gnpOld, string localName, string governmentForm, string headOfState, int capital)
        {
            _code = code;
            _name = name;
            _continent = continent;
            _region = region;
            _surfaceArea = surfaceArea;
            _indepYear = indepYear;
            _population = population;
            _lifeExpectancy = lifeExpectancy;
            _gnp = gnp;
            _gnpOld = gnpOld;
            _localName = localName;
            _governmentForm = governmentForm;
            _headOfState = headOfState;
            _capital = capital;

        }

        public int GetCode()
        {
            return _code;
        }
        public string GetName()
        {
            return _name
        }
        public string GetContinent()
        {
            return _continent
        }
        public string GetRegion()
        {
            return _region
        }
        public float GetSurfaceArea()
        {
            return _surfaceArea;
        }
        public int GetIndepYear()
        {
            return _indepYear;
        }
        public int GetPopulation()
        {
            return _population;
        }
        public float GetLifeExpectancy()
        {
            return _lifeExpectancy;
        }
        public float GetGNP()
        {
            return _gnp;
        }
        public float GetGNPOld()
        {
            return _gnpOld;
        }
        public string GetLocalName()
        {
            return _localName;
        }
        public string GetGovernmentForm()
        {
            return _governmentForm;
        }
        public string GetHeadOfState()
        {
            return _headOfState;
        }
        public int GetCapital()
        {
            return _capital;
        }


        public static List<Country> GetAll()
        {
            List<Country> allCountries = new List<Country> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM items;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              int countryCode = rdr.GetInt32(0);
              string countryName = rdr.GetString(1);
              string countryContinent = rdr.GetString(2);
              string countryRegion = rdr.GetString(3);
              float countrySurfaceArea = rdr.GetFloat(4);
              int countryIndepYear = rdr.GetInt32(5);
              int countryPopulation = rdr.GetInt32(6);
              float countryLifeExpectancy = rdr.GetFloat(7);
              float countryGNP = rdr.GetFloat(8);
              float countryGNPOld = rdr.GetFloat(9);
              string countryLocalName = rdr.GetString(10);
              string countryGovernmentForm = rdr.GetString(11);
              string countryHeadOfState = rdr.GetString(12);
              int countryCapital = rdr.GetInt32(13);


              // Country newCountry = new Country(itemDescription, itemId);
              // allCountrys.Add(newCountry);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCountries;
        }
    }
}
