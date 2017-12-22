using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using harman_asg2.Models;

namespace harman_asg2.Models
{
    // repository for mock album data for unit testing
    public interface ITable1furnitureRepository
    {
        IQueryable<table1furniture> table1furniture { get; }

    table1furniture Save(table1furniture table1furniture);
    void Delete(table1furniture table1furniture);
    }
}
