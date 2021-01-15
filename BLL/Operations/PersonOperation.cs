using AutoMapper;
using BLL.DTOs.Person;
using BLL.Interfaces;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{
    public class PersonOperation : IPersonOperation
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public PersonOperation(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<PersonListDTO> GetAll()
        {
            var persons = _uow.Person.GetAll();
            return _mapper.Map<IEnumerable<PersonListDTO>>(persons);
        }
    }
}
