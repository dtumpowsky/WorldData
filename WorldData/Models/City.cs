using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WorldData.Models;
using MySql.Data.MySqlClient;

namespace WorldData.Models
{
    public class City
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
        private string _code2;

        public Country(int code, string name, string continent, string region, float surface area, int indepYear, int population, float lifeExpectancy, float gnp, float gnpOld, string localName, string governmentForm, string headOfState, int capital, string code2)
        {

        }
    }
}
