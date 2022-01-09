using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    public class Car
    {
        private string _colour = "red";

        public string Colour
        {
            get 
            { 
                return _colour; 
            }
            set
            {
                _colour = value;
            }
        }
    }
}