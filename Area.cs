using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkymillAssignment
{
    // Abstract class for Area, since it can be inhereted to different shape such as rectangles, circles and so on.
    abstract class Area
    {
        // presenting association relationship between the Area class and the MovingObject class
        protected MovingObject moves;

       //getters and setters
        public MovingObject Moves
        {
            get => moves;
            set => moves = value;
        }
       
        // Abstract method
        public abstract bool movingObjectFallsOutOfTheArea(int point_xDimension , int point_yDimension);


    }
    class Rectangle : Area
    {
        // rectangle attributes with the assumption of origin as the corner of the rectangle, as the assignmnet description requires
        int width;
        int length;

        // default constructor
         public Rectangle(){}

        //getters and setters
        public int Width
            {
            get => width;
            set => width = value;
            }

        public int Length
        {
            get => length;
            set => length = value;
        }
        public override bool movingObjectFallsOutOfTheArea(int point_xDimension, int point_yDimension)
        {
            /* all the points in a rectangle of width and length dimensions and origin as a corner are in 0 <= x <= width & 0 <= y <= length,
            but since in this model (0,0) takes space, the length and width should be subtarcted by 1*/
            if ((point_xDimension > width-1 || point_xDimension < 0) || (point_yDimension > length-1 || point_yDimension < 0))
                return true;
            else
                return false;

            
        }
    }

class Circle : Area
{
    // circle attribute with the assumption of origin as the center of the circle, as the assignmnet description may assume
    int radius;

    // default constructor
    public Circle(){}

    //getters and setters
    public int Radius
        {
        get => radius;
        set => radius = value;
    }

   
    public override bool movingObjectFallsOutOfTheArea(int point_xDimension, int point_yDimension)
    {
            /* defining a local attribute presenting y coordinate of all the points on a circle of "radius" dimension and the origin as its center; 
            Note that we need only integers, for the steps are discrete*/
            int circle_yDimension = (int)Math.Sqrt((Math.Pow(radius, 2.0)) - (Math.Pow(point_xDimension, 2.0)));

            /*since the steps are of square shape and should be fully in the circle to be considered inside on one hand, and having (0,0) as a step in this model, so:
              -(radius-1) < x < (radius -2) and -sqrt(radius^2 -x^2) < y < sqrt(radius^2 -x^2) */
            if (point_xDimension >= -(radius - 1) && point_xDimension <= (radius -2) && (point_yDimension > -(circle_yDimension) && point_yDimension < circle_yDimension-1))
            return false;
        else
            return true;

    }
}
    }


