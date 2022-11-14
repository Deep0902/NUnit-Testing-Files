 using System;
using System.Collections.Generic;

namespace MyAreas
{
    public class Areas
    {
        public float Circle(int radius)
        {
            return (float)Math.PI*(radius * radius);
        }
        public int Rectangle(int l, int b)
        {
            return (l * b);
        }
        public float Triangle(int h, int b)
        {
            return (float)(0.5 * b * h);
        }
        public int Square(int s)
        {
            return (s * s);
        }
        public int Sum2Nos(int x, int y)
        {
            return x + y;
        }
        public string Login(string user, string pwd)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                return "Credentials cannot be empty";
            }
            else if (user == "admin" && pwd == "admin")
            {
                return "Login successful";
            }
            else
                return "Invalid user & password";
        }
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Jerry");
            names.Add("Noddy");
            names.Add("Scooby");
            names.Add("Oswald");
            names.Add("Daphine");
            names.Add("Wennie");
            return names;
        }
    }
}
