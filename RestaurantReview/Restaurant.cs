using System;
using System.Text.RegularExpressions;

namespace _RestaurantReview
{
    public class Class1
    {
        private string _city;
        public string City
        {
            get { return _city; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenevr you give
                    throw new Exception("City can only hold letters!");
                }
                _city = value;
            }
        }
    }
}
           
      