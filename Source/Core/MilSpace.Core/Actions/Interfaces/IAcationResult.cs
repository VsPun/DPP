﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilSpace.Core.Actions.Interfaces
{
    public interface IActionResult 
    {
        Type ReturnType { get; }
        string ErrorMessage { get; set; }
        Guid PeocessId { get; set; }

        Exception Exception { get; set; }
    }
}
