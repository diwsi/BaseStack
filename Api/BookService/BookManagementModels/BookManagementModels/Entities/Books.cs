﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementModels.Entities
{
    /// <summary>
    /// Sample Entity
    /// </summary>
    public class Books : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //...etc
    }
}
