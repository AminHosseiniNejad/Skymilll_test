using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkymillAssignment
{
    //unchanged directions
    public enum Direction { North, East, South, West};
    class MovingObject
    {
        // the requird coordinates descirbing the moving object state
        private Direction direction;
        private int x_position;
        private int y_position;

        // default constructor
        public MovingObject(){}

        //getters and setters
        public Direction Direction
        {
            get => direction;
            set => direction = value;
        }

        public int X_position
        {
            get => x_position;
            set => x_position = value;
        }

        public int Y_position
        {
            get => y_position;
            set => y_position = value;
        }

    //functional methods:
        // in MoveForward method, just one step without changing direction is taken
        public void MoveForward()
        {

            switch (direction)
            {
                case Direction.North:
                    { 
                    this.Direction = direction;
                    this.X_position = x_position;
                    this.Y_position = y_position - 1; //since the positive y axis is downward in this model, one step forward will reduce y dimension by 1 in north direction

                        break;
                    }
               case Direction.East:
                    {
                        this.Direction = direction;
                        this.X_position = x_position + 1; //since the positive x axis is to the right in this model, one step forward will add y dimension by 1 in east direction
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.South:
                    {
                        this.Direction = direction;
                        this.X_position = x_position;
                        this.Y_position = y_position +1;

                        break;
                    }

                case Direction.West:
                    {
                        this.Direction = direction;
                        this.X_position = x_position - 1;
                        this.Y_position = y_position;

                        break;
                    }
            }

        }

        // MoveBackward method is the same as MoveForward, but in the opposite direction
        public void MoveBackward()
        {

            switch (direction)
            {
                case Direction.North:
                    {
                        this.Direction = direction;
                        this.X_position = x_position;
                        this.Y_position = y_position + 1;

                        break;
                    }
                case Direction.East:
                    {
                        this.Direction = direction;
                        this.X_position = x_position - 1;
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.South:
                    {
                        this.Direction = direction;
                        this.X_position = x_position;
                        this.Y_position = y_position - 1;

                        break;
                    }

                case Direction.West:
                    {
                        this.Direction = direction;
                        this.X_position = x_position + 1;
                        this.Y_position = y_position;

                        break;
                    }


            }




        }

        // in the TurnClockwise method, the moving object does not take any step, but just change its direction
        public void TurnClockwise()
        {

            switch (direction)
            {
                case Direction.North:
                    {
                        this.Direction = Direction.East;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }
                case Direction.East:
                    {
                        this.Direction = Direction.South;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.South:
                    {
                        this.Direction = Direction.West;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.West:
                    {
                        this.Direction = Direction.North;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }


            }




        }

        //  the TurnCounterClockwise method is the same as the TurnClockwisebut method, but in an opposite direction 
        public void TurnCounterClockwise()
        {

            switch (direction)
            {
                case Direction.North:
                    {
                        this.Direction = Direction.West;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }
                case Direction.West:
                    {
                        this.Direction = Direction.South;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.South:
                    {
                        this.Direction = Direction.East;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }

                case Direction.East:
                    {
                        this.Direction = Direction.North;
                        this.X_position = x_position;
                        this.Y_position = y_position;

                        break;
                    }


            }




        }

        // other commends could be added here in different Cases
    }


    }
