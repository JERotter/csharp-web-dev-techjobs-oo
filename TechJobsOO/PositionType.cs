﻿using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType() : base()
        {

        }

        public PositionType(string value) : this()
        {
            Value = value;
        }
    }
}
