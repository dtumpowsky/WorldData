using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WorldData.Models
{
    public class City
    {
        private int _id;
        private string _name;
        private string _countryCode;
        private string _district;
        private int _population;

        public City(string name, string countryCode, string district, int population, int id = 0)
        {
            _name = name;
            _countryCode = countryCode;
            _district = district;
            _population = population;
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetCountryCode()
        {
            return _countryCode;
        }
        public string GetDistrict()
        {
            return _district;
        }
        public int GetPopulation()
        {
            return _population;
        }


        public static List<City> GetAll(string city_name)
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM city WHERE name LIKE '" + city_name + "%\';";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              string cityName = rdr.GetString(0);
              string cityCountryCode = rdr.GetString(1);
              string cityDistrict = rdr.GetString(2);
              int cityPopulation = rdr.GetInt32(3);
              int cityId = rdr.GetInt32(4);

              City newCity = new City( cityName, cityCountryCode, cityDistrict, cityPopulation, cityId);
              allCities.Add(newCity);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }
    }
}
