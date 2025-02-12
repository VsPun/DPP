﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MilSpace.Configurations.Base;

namespace MilSpace.Configurations
{
    public class WorkingDBConnectionSection : ConfigurationSection
    {
        internal static string SectionName = ConfigElementNames.WorkingDBConnectionSection;



        [ConfigurationProperty(ConfigElementNames.ConnectionString, IsKey = true, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string)this[ConfigElementNames.ConnectionString]; }
            set { base[ConfigElementNames.ConnectionString] = value; }
        }
    }
}
