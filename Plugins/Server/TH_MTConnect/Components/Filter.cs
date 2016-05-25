﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml;

namespace TH_MTConnect.Components
{
    public class Filter
    {
        public Filter() { }

        public Filter(XmlNode FilterNode)
        {
            XML.AssignProperties(this, FilterNode);
        }

        public string Type { get; set; }
    }
}
