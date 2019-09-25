using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment
{
    class Person
    {
        public static string salutationMr = "Mr";
        public static string salutationMs = "Ms";
        public static string defaultlastName = "NLN";

        public string firstName;
        public string lastName;
        public string salutation;


        public Person()
        {
            firstName = "";
            lastName = defaultlastName;
            salutation = salutationMs;
        }


        public Person(string salutation, string fName, string lName)
        {
            salutation = salutation;    // needs refinement
            firstName = fName;
            lastName = lName;
        }

    }
}
