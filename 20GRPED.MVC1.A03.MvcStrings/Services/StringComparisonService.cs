using _20GRPED.MVC1.A03.MvcStrings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20GRPED.MVC1.A03.MvcStrings.Services
{
    public class StringComparisonService
    {
        public bool Compare(StringComparisonModel stringComparisonModel)
        {
            var result = stringComparisonModel.Left == stringComparisonModel.Right;
            return result;
        }

        public bool CompareIgnoreCase(StringComparisonModel stringComparisonModel)
        {
            var result =
                string.Equals(
                    stringComparisonModel.Left,
                    stringComparisonModel.Right,
                    StringComparison.OrdinalIgnoreCase);
            return result;
        }
    }
}
