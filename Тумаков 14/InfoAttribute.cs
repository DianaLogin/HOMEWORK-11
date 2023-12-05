
using System;

namespace Тумаков_14
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = true)]
    internal class InfoAttribute : System.Attribute
    {
        public string Developers_Name {  get; set; }
        public string Developers_Organization { get; set; }
        public InfoAttribute() { }
        public InfoAttribute(string developers_Name, string developers_Organization)
        {
            Developers_Name = developers_Name;
            Developers_Organization = developers_Organization;
        }
    }

}
