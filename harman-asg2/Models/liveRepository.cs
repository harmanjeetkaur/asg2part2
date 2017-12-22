using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using harman_asg2.Controllers;
using harman_asg2.Models;

namespace harman_asg2.Models
{
    public class table1furniturerepository : ITable1furnitureRepository
    {
        //repository for CRUD with Albums in SQL server db
        //db connection moved here from stpre manager controller
        Model1 db = new Model1();
        public IQueryable<table1furniture> table1furniture { get { return db.table1furniture; } }

        public void Delete(table1furniture table1furniture)
        {
            db.table1furniture.Remove(table1furniture);
            db.SaveChanges();
        }

        public table1furniture Save(table1furniture table1furniture)
        {
            if(table1furniture.CustomerID == 0)
            {
                db.table1furniture.Add(table1furniture);
            }
            else
            {
                db.Entry(table1furniture).State = System.Data.Entity.EntityState.Modified; 

            }
            db.SaveChanges();
            return table1furniture;
        }
    }
}