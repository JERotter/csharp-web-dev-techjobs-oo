using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer() : base()
        {
            
        }

        public Employer(string value) : this()
        {
            Value = value;
        }
    }
}
