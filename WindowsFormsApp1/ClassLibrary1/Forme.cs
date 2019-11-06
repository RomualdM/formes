using System;

namespace ClassLibrary1
{
    public abstract class Forme
    {
        private string id;

        protected string Id { get => id; set => id = value; }

        protected abstract double perimetre();
        protected abstract double surface();
        

        
    }
}
