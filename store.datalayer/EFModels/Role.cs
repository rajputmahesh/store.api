﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.EFModels
{
    public class Role
    {
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
