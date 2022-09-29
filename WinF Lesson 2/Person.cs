using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinF_Lesson_2
{

    internal class Person
    {
        private bool ValidateName(string? name) => Regex.IsMatch(name!, @"^[a-zA-Z]+$");
        private bool ValidatePhone(string? phone) => Regex.IsMatch(phone!, @"^([0|\+[0-9]{1,5})?([0-9]{10})$");
        private string? surname;
        private string? name;
        private string? fatherName;
        private string? country;
        private string? city;
        private string? phone;
        private string? gender;

        public string? Surname
        {
            get { return surname; }
            set
            {

                if (!ValidateName(value))

                    throw new ArgumentException("Invalid Surname!");

                surname = value;
            }
        }

        public string? Name
        {
            get { return name; }
            set
            {
                if (!ValidateName(value))
                    throw new ArgumentException("Invalid Name!");
                name = value;
            }
        }

        public string? FatherName
        {
            get { return fatherName; }
            set
            {
                if (!ValidateName(value))
                    throw new ArgumentException("Invalid Name!");
                fatherName = value;
            }
        }

        public string? Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Incalid Country");
                country = value;
            }
        }

        public string? City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Invalid City");
                city = value;
            }
        }

        public string? Phone
        {
            get { return phone; }
            set
            {
                if (!ValidatePhone(value))
                    throw new ArgumentException("Invalid Phone!");

                phone = value;
            }
        }

        public DateTime BirthDate { get; set; }
        public string? Gender
        {
            get { return gender; }
            set
            {
                if (value!= "Male" && value != "Female")
                    throw new ArgumentException("Invalid Gender");

                gender = value;
            }
        }

        public Person(string? surname, string? name, string? fatherName, string? country, string? city, string? phone, DateTime birthDate, string? gender)
        {
            Surname=surname;
            Name=name;
            FatherName=fatherName;
            Country=country;
            City=city;
            Phone=phone;
            BirthDate=birthDate;
            Gender=gender;
        }
    }
}
