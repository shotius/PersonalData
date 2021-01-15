using DAL.Context;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class UOW : IUOW
    {
        protected PersonDbContext _context;

        protected IPersonRepository _personRepository;
        public UOW(PersonDbContext context)
        {
            _context = context;
        }

        public IPersonRepository Person 
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository(_context);

                return _personRepository;
            }
        
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
