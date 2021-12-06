using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class UserProfile : EntityBase
    {
        public virtual string Name { get; private set; }

        public virtual DateTime BirthDate { get; private set; }
        public virtual string ZipCode { get; private set; }
        public virtual string Street { get; private set; }
        public virtual string Number { get; private set; }
        public virtual string Complement { get; private set; }
        public virtual string State { get; private set; }
        public virtual string City { get; private set; }
        public virtual Photo ProfilePicture { get; private set; }
        public virtual  Login Login { get; private set; }

        public UserProfile(string name, Login login, DateTime birthDate, string zipCode, string street, string number, string complement, string state, string city, Photo profilePicture)
        {
            Name = name;
            Login = login;
            BirthDate = birthDate;
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            State = state;
            City = city;
            ProfilePicture = profilePicture;
           
        }

        public UserProfile()
        {
                
        }
    }
}