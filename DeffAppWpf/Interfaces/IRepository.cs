﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DeffAppWpf.Models;

namespace DeffAppWpf.Interfaces
{
    interface IRepository
    {
        //Create
        bool AddPerson(Person person);
        bool AddYearShape(YearShape yearShape);
        bool AddDayShape(DayShape dayShape);

        //Read

        Person GetPerson(int personId);

        YearShape GetYearShape(int yearShapeId);
        DayShape GetDayShape(int dayShapeId);

        IList<Person> GetAllPersons();
        IList<YearShape> GetAllYearShapes();
        IList<DayShape> GetAllDayShapes();  

        //Update

        bool UpdatePerson(Person person);
        bool UpdateYearShape(YearShape yearShape);
        bool UpdateDayShape(DayShape dayShape);

        //Delete

        bool DeletePerson(int personId);
        bool DeleteYearShape(int yearShapeId);
        bool DeleteDayShape(int dayShapeId);

    }
}
