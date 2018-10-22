using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    // Base Class
    abstract class  Animal
    {
        // 
        private int _id;
        private string _name;
        private string _picture;
        protected string _food;
        protected string _boundries;

        // constructor 
        public Animal(int id ,string name , string location)
        {
            _name = name;
            _id = id;
            _boundries = location;

        }

        // abstract method 
        public abstract string MakeNoise();

        public abstract string Eat();

        // concrete method 
        public virtual string Sleep()
        {
            return "all animal have sleeping habits";
        }
        public override string ToString()
        {
            return $"{_name} - {_boundries}";
        }
    }
}
