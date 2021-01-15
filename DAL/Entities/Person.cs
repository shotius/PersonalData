using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int  GenderId { get; set; }
        
        public int PositionId { get; set; }
        
        public string  Mail { get; set; }
        
        public Dictionary Gender { get; set; }
        
        public Dictionary Position { get; set; }
        
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

    }
}
