using Ex_11.Entities.Enums;

namespace Ex_11.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }        
        public Shape(Color color)
        {
            Color=color;            
        }
        
        public abstract double Area();
    }
}