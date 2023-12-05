using System;
namespace Тумаков_14
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = true)] // эта скобка означает, что атрибут позволяет многократное использование
    internal class DeveloperInfoAttribute : System.Attribute
    {
        public string Developers_Name { get; }
        public DateTime Development_Date { get; }

        public DeveloperInfoAttribute() { }

        public DeveloperInfoAttribute(string developers_Name, string development_Date)
        {
        Developers_Name = developers_Name;
        Development_Date = DateTime.Parse(development_Date);
        }
    }
}
