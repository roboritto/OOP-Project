﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Project
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            public double Cost { get; set; }

            public Project(string name, string description, double cost, DateTime date)
            {
                Name = name;
                Description = description;
                Cost = cost;
                Date = date;
            }
        }

    }

