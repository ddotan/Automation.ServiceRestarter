﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automation.Restarter.Agent.Utilities
{
    public class item
    {
        [XmlAttribute]
        public string id;
        [XmlAttribute]
        public string value;
    }
}
