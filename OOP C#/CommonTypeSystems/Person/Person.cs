namespace Person
{
    using System;

    public class Person
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1}", Name, Age == null ? "unknown" : Age.ToString());
        }
    }
}
