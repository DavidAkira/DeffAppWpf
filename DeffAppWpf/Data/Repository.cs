using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeffAppWpf.Interfaces;
using DeffAppWpf.Models;

namespace DeffAppWpf.Data
{
    class Repository : IRepository
    {
        public bool AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public bool AddYearShape(YearShape yearShape)
        {
            throw new NotImplementedException();
        }

        public bool DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteYearShape(int yearShapeId)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public IList<YearShape> GetAllYearShapes()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int personId)
        {
            throw new NotImplementedException();
        }

        public YearShape GetYearShape(int yearShapeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public bool UpdateYearShape(YearShape yearShape)
        {
            throw new NotImplementedException();
        }
    }
}
