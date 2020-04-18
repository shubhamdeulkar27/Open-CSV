using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCSV
{
    /// <summary>
    /// CSVUsers Class for setting and getting data.
    /// </summary>
    public class CSVUsers 
    {
        //Variales.
        private string name;
        private string email;
        private string phoneNo;
        private string country;

        //Setters And Getters, to set and get the data.
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Country { get => country; set => country = value; }
    }
}
