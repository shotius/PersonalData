using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonListDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int PositionId { get; set; }

        public string Mail { get; set; }
    }
}
