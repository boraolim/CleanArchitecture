﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CA.Core.Entities
{
    public partial class SchemaVersion
    {
        public int Id { get; set; }
        public string ScriptName { get; set; }
        public DateTime Applied { get; set; }
    }
}
