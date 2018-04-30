using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WorldData.Models
{
    public class Country
    {
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
        private string _code;

        public Country(string name, string continent, string region, float surfaceArea, int indepYear, int population, float lifeExpectancy, float gnp, float gnpOld, string localName, string governmentForm, string headOfState, int capital, string code)
        {
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
            _code = code;

        }

        public string GetCode()
        {
            return _code;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetContinent()
        {
            return _continent;
        }
        public string GetRegion()
        {
            return _region;
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


        public static List<Country> GetAllCountryInfo(string country_name)
        {
            List<Country> allCountries = new List<Country> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM country WHERE name LIKE '" + country_name + "%\';";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
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
              string countryCode = rdr.GetString(0);


              Country newCountry = new Country(countryName, countryContinent, countryRegion, countrySurfaceArea, countryIndepYear, countryPopulation, countryLifeExpectancy, countryGNP, countryGNPOld, countryLocalName, countryGovernmentForm, countryHeadOfState, countryCapital, countryCode);
              allCountries.Add(newCountry);
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
