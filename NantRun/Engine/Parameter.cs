﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NantRun.Engine
{
    public class Parameter
    {
        public string ParamString{ get; set; }
        public Parameter(string parameter)
        {
            this.ParamString = parameter;
        }

        public Parameter(){}
    }
}
