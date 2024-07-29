using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_App_Dynamic_Anon_OperatorOverloading
{//namespace begin
    public abstract class Shape
    {//Shape
        //define a property to hold the name of the shape
        public string Name { get; set; }

        //abstract method to calulate the area of the shape
        public abstract double GetArea();

    }//Shape

    //define Circle & Rectangle child class that inherits from the base: Shape Class
    public class Circle : Shape 
    {//circle 
        //property to hold radius of the circle
        public double Radius { get ; set; }

        //Constructor to initialize the radius & set the nae to "Cicle"
        public Circle(double radius)
        {//constructor 
            Name = "Circle";
            Radius = radius;
        }//constructor

        //Overide the GetArea Method
        public override double GetArea()
        {//GetArea
            return Math.PI * Radius*Radius;
        }//GetArea

        //operator overloading: Add the area od two circles & return a new Circile with the equivalent are
        public static Circle operator +(Circle a, Circle b) 
        {//Circle overload
            //calulate the new radius from the sum of areas of the 2 circles
            return new Circle(Math.Sqrt(a.GetArea() + b.GetArea())/Math.PI);
        
        }//Circle overload
    }//circle


    //Create a second child class : Rectangle
    //define the properties to hold width & height
    //define constructor to intalize width, height, set Name to  'Rectangle'
    //overide the getArea method 
    //operator overloading : Add two rectangle objects & return new Rectangle with the sum of width & height of the 2 objects

    public class Rectangle : Shape
    {//rectangle 
        //property to hold radius of the circle
        public double Length { get; set; }
        public double Breath { get; set; }

        //Constructor to initialize the radius & set the name to "Cicle"
        public Rectangle(double length, double breath)
        {//constructor 
            Name = "Rectangle";
            Length = length;
            Breath = breath;
        }//constructor

        //Overide the GetArea Method
        public override double GetArea()
        {//GetArea
            return Length*Breath;
        }//GetArea

        //operator overloading: Add the area od two circles & return a new Circile with the equivalent are

    }//rectangle

}//namespace end
