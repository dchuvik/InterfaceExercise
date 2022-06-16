using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Logo { get; set; }
        public string Product { get; set; }
    }
}

/*Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */
