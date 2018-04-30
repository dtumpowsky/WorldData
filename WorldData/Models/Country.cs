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
        private string _code2;

        public Country(int code = 0, string name, string continent, string region, float surfaceArea, int indepYear, int population, float lifeExpectancy, float gnp, float gnpOld, string localName, string governmentForm, string headOfState, int capital, string code2)
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
            _code2 =code2;
        }

        public int GetCode()
        {
            return _code;
        }
        public int GetName()
        {
            return _name
        }
        public int GetContinent()
        {
            return _continent
        }
        public int GetRegion()
        {
            return _region
        }
        public int GetSurfaceArea()
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
        public int GetLifeExpectancy()
        {
            return _lifeExpectancy;
        }
        public int GetGNP()
        {
            return _gnp;
        }
        public int GetGNPOld()
        {
            return _gnpOld;
        }
        public int GetLocalName()
        {
            return _localName;
        }
        public int GetGovernmentForm()
        {
            return _governmentForm;
        }
        public int GetHeadOfState()
        {
            return _headOfState;
        }
        public int GetCapital()
        {
            return _capital;
        }
        public int GetCode2()
        {
            return _code2;
        }
    }
}
