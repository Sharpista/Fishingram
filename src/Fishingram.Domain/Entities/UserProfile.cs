using Fishingram.Shared.Entities;
using System;

namespace Fishingram.Domain.Entities
{
    public class UserProfile : EntityBase
    {
        public virtual string Name { get; private set; }
        public virtual string  Email { get; private set; }
        public virtual string Password { get; private set; }
        public virtual string CPF { get; private set; }
        public virtual DateTime BirthDate { get; private set; }
        public virtual string ZipCode { get; private set; }
        public virtual string Street { get; private set; }
        public virtual string Number { get; private set; }
        public virtual string District { get; private set; }
        public virtual string Complement { get; private set; }
        public virtual string State { get; private set; }
        public virtual string City { get; private set; }
        public virtual Photo ProfilePicture { get; private set; }

        public UserProfile(string name,string email , string password, string cpf, DateTime birthDate, string zipCode, string street, string number, string district, string complement, string state, string city, Photo profilePicture)
        {
            Name = name;
            Email = email;
            Password = password;
            CPF = cpf;
            BirthDate = birthDate;
            ZipCode = zipCode;
            Street = street;
            District = district;
            Number = number;
            Complement = complement;
            State = state;
            City = city;
            ProfilePicture = profilePicture;
           
        }

        public UserProfile(string email, string password)
        {
            Email = email;
            Password = password;
        }



        public UserProfile()
        {
                
        }
    }
}