using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class PersonInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictionary>()
                .HasData(
                    new Dictionary()
                    {
                        Id = 1,
                        Title = "manager",
                        HasPosition = true
                    },
                    new Dictionary()
                    {
                        Id = 2,
                        Title= "CEO",
                        HasPosition = true
                    },
                    new Dictionary()
                    {
                        Id = 3,
                        Title = "shveicar",
                        HasPosition = true
                    },
                    new Dictionary()
                    {
                        Id = 4,
                        Title = "Male",
                        HasGender = true
                    },
                    new Dictionary()
                    {
                        Id = 5,
                        Title = "Female",
                        HasGender = true
                    },
                    new Dictionary()
                    {
                        Id = 6,
                        Title = "mobile",
                        HasPhoneType = true
                    },
                    new Dictionary()
                    {
                        Id = 7,
                        Title = "work",
                        HasPhoneType = true
                    },
                    new Dictionary()
                    {
                        Id = 8,
                        Title = "Home",
                        HasPhoneType = true
                    }
                );

            modelBuilder.Entity<Person>()
                .HasData(
                    new Person()
                    {
                        Id = 1,
                        FirstName = "name1",
                        LastName = "LastName1",
                        BirthDate = new DateTime(1999,5,21),
                        Mail = "test@mail.com",
                        GenderId = 5,
                        PositionId = 1                                                
                    },
                    new Person()
                    {
                        Id = 2,
                        FirstName = "name2",
                        LastName = "LastName2",
                        BirthDate = new DateTime(1999, 5, 21),
                        Mail = "test@mail.com",
                        GenderId = 5,
                        PositionId = 1
                    },
                    new Person()
                    {
                        Id = 3,
                        FirstName = "name3",
                        LastName = "LastName3",
                        BirthDate = new DateTime(1999, 5, 21),
                        Mail = "test@mail.com",
                        GenderId = 5,
                        PositionId = 1
                    }


                );
        }
    }
}
