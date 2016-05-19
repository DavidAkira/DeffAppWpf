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
        private static Repository _instance;
        public Repository GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Repository();
                    return _instance;                   
                }
                else
                {
                    return _instance;
                }
            } 
        }
        public bool AddDayShape(DayShape dayShape)
        {
            using (var db = new DeffContext())
            {
                db.DayShapes.Add(dayShape);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddPerson(Person person)
        {
            using (var db = new DeffContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddYearShape(YearShape yearShape)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDayShape(int dayShapeId)
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

        public IList<DayShape> GetAllDayShapes()
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

        public DayShape GetDayShape(int dayShapeId)
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

        public bool UpdateDayShape(DayShape dayShape)
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
