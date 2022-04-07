﻿using System;

namespace BookstoreSystem.Data
{
    public class Customer
    {
        private int id;
        private String name;
        private String surname;

        public Customer(int _id, String _name, String _surname)
        {
            this.id = _id;
            this.name = _name;
            this.surname = _surname;
        }

        public int Id { get { return id; } }
        public String Name { 
            get { return name; } 
            set { name = value; } 
        }
        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   id == customer.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }


        // override Equals and GetHashCode for easier comparison in repository

    }
}