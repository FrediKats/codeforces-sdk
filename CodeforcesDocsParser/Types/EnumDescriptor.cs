﻿using System.Collections.Generic;
using System.Linq;
using CodeforcesDocsParser.Tools;

namespace CodeforcesDocsParser.Types
{
    public class EnumDescriptor
    {
        public string Name { get; set; }
        public List<string> Values { get; set; }

        public EnumDescriptor(string className, string propertyName, string description)
        {
            className = className.LowerToUpperCamelCase();
            propertyName = propertyName.LowerToUpperCamelCase();

            Name = $"{className}{propertyName}Enum";

            Values = description
                .Remove(0, 6)
                .Split(", ")
                .Select(v => v.Trim())
                .Select(v => v.SnakeToCammelCase())
                .ToList();
        }
    }
}