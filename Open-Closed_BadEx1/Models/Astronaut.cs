﻿namespace Open_Closed_BadEx1.Models
{
    public class Astronaut
    {
        public string Name { get; }

        public int Age { get; }

        string role { get; }

        public string GetRole()
        {
            switch (role)
            {
                case "Aircraft Mechanic":
                    return $"{role}";
                case "Astronomer":
                    return role;

                default:
                    return "Not defined";
            }
        }

        public Astronaut(string name, int age, string role)
        {
            Name = name;
            Age = age;
            this.role = role;
        }
    }
}
