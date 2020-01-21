using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanNunez_Final
{
    class DVD
    {
        private int _dvdID;
        private string _title;
        private string _rating;
        private decimal _yearOfRelease;
        private decimal _price;

        public DVD(int dvdId, string title, string rating, decimal year, decimal price)
        {
            _dvdID = dvdId;
            _title = title;
            _rating = rating;
            _yearOfRelease = year;
            _price = price;
        }

        public int GetID
        {
            get { return _dvdID; }
        }

        public string GetTitle
        {
            get { return _title; }
            set { _title = value; }
        }

        public string GetRating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public decimal GetReleaseDate
        {
            get { return _yearOfRelease; }
            set { _yearOfRelease = value; }
        }

        public decimal GetPrice
        {
            get { return _price;  }
            set { _price = value; }
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
