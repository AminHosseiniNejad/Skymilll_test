using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkymillAssignment
{
    class MainClass
    {

        static void Main(string[] args)
        {
           // creating objects of different classes
            MovingObject movingObject=new MovingObject();
            Rectangle rectangle=new Rectangle();
            Circle circle=new Circle();


            Console.WriteLine("Welcome to the game.\n");
            SelectedArea: Console.WriteLine("Enter 1 or 2 to have a rectangle or a circle as the area for the moving objects, respectively: ");
            int numForSelectedArea = Convert.ToInt32(Console.ReadLine()); // converting string to integer

            switch (numForSelectedArea)
            {
                case 1:// rectangle
                    Console.WriteLine("You selected a rectangle as the area for the moving obejct.");

                RectLength: Console.WriteLine("Enter a positive integer as the length of the rectangle: ");//length
                int lengthRectangle = Convert.ToInt32(Console.ReadLine()); // converting string to integer
                    
                    // not letting non-positive integers to be considered as length
                    if (lengthRectangle > 0)
                    {
                        rectangle.Length = lengthRectangle;//setting length of the rectangle
                    }
                    else
                    {
                        goto RectLength;
                    }

                    RectWidth: Console.WriteLine("Enter a positive integer as the width of the rectangle: ");//width
                
                    int widthRectangle = Convert.ToInt32(Console.ReadLine()); // converting string to integer

                    // not letting non-positive integers to be considered as width
                    if (widthRectangle > 0)
                    {
                        rectangle.Width = widthRectangle;//setting width of the rectangle
                    }
                    else
                    {
                        goto RectWidth;
                    }


                ObjectOutOfTable:  Console.WriteLine("Enter an integer as the x coordinate of the starting point of the moving obejct: ");// x coordinate for the moving object
                int xCoordinate = Convert.ToInt32(Console.ReadLine()); // converting string to in
                movingObject.X_position=xCoordinate; // setting the x coordinate of the starting point of the object by this input

                Console.WriteLine("Enter an integer as the y coordinate of the starting point of the moving obejct: ");// y coordinate for the moving object
                int yCoordinate = Convert.ToInt32(Console.ReadLine()); // converting string to integer
                movingObject.Y_position= yCoordinate; // setting the y coordinate of the starting point of the object by this input


                    if (rectangle.movingObjectFallsOutOfTheArea(movingObject.X_position, movingObject.Y_position)) // if the initial position of the starting point is out of the area
                {
                    Console.WriteLine("OPSS! Your inputs make the object fall out of the area!");
                    goto ObjectOutOfTable;
                }
                else
                    {
                    Console.WriteLine("******************************************");

                    Console.WriteLine("Here you can give some commands to the object to move. Commands are represented as some numbers as:\n" +
                    "0 = quit simulation and print the moving object position\n"+"1 = move froward one step\n2 = move backward one step\n"+
                    "3 = rotate clockwise 90 degrees\n4 = rotate counterclockwise 90 degrees");
                    Console.WriteLine("******************************************");


                        // while loop for getting commands from the user, until the moving object falls off the area or the user enter 0 to quit the program and print the moving object position
                        while (true)
                        {
                            if (rectangle.movingObjectFallsOutOfTheArea(movingObject.X_position, movingObject.Y_position))
                            {
                                Console.WriteLine("OPSS! The moving object fell out of the area, so its position is (-1 , -1)");
                                return;
                            }
                            else
                            {
                                while (!(rectangle.movingObjectFallsOutOfTheArea(movingObject.X_position, movingObject.Y_position)))
                                {
                                    Console.WriteLine("Enter the command number between 0 and 4:");
                                    int commandNumber = Convert.ToInt32(Console.ReadLine());

                                    switch (commandNumber)
                                    {
                                        case 0:// quit the simulation and give the position
                                            Console.WriteLine("The x,y coordinates for the moving object are " + movingObject.X_position + "," + movingObject.Y_position);
                                            return;

                                        case 1://move the object forward one step
                                            movingObject.MoveForward();
                                            break;
                                        case 2://move the object backward
                                            movingObject.MoveBackward();
                                            break;
                                        case 3://turn the object clockwise
                                            movingObject.TurnClockwise();
                                            break;
                                        case 4://turn the object counterclockwise
                                            movingObject.TurnCounterClockwise();
                                            break;
                                        default://the input number is wrong
                                            Console.WriteLine("Wrong number.");
                                            break;
                                    }
                                }
                            }
                        }
                         }
                    
                case 2://Circle
                    Console.WriteLine("You selected a circle as the area for the moving obejct.");
 
                    CircleRadius: Console.WriteLine("Enter a positive integer as the radius of the circle: ");//radius
                    int radius = Convert.ToInt32(Console.ReadLine()); // converting string to integer

                    if(radius > 0)
                    { 
                    circle.Radius=radius;//setting radius of the circle
                    }
                    else
                    {
                        goto CircleRadius;
                    }
                    ObjectOutOfArea: Console.WriteLine("Enter an integer as the x coordinate of the starting point of the moving obejct: ");// x coordinate for the moving object
                    int xCircleCoordioante = Convert.ToInt32(Console.ReadLine()); // converting string to in
                    movingObject.X_position= xCircleCoordioante;

                    Console.WriteLine("Enter an integer as the y coordinate of the starting point of the moving obejct: ");// y coordinate for the moving object
                    int yCircleCoordioante = Convert.ToInt32(Console.ReadLine()); // converting string to integer
                    movingObject.Y_position= yCircleCoordioante;

                    if (circle.movingObjectFallsOutOfTheArea(movingObject.X_position, movingObject.Y_position))
                    {
                        Console.WriteLine("OPSS! Your inputs make the object fall out of the area!"); // to make sure that object does not start to move outside the area
                        goto ObjectOutOfArea;
                    }
                    else
                    {
                        Console.WriteLine("******************************************");

                        //commands
                        Console.WriteLine("Here you can give some commands to the object to move. Commands are represented as some numbers as:\n" +
                        "0 = quit simulation and print the moving object position\n"+"1 = move froward one step\n2 = move backward one step\n"+
                        "3 = rotate clockwise 90 degrees\n4 = rotate counterclockwise 90 degrees");

                        Console.WriteLine("******************************************");


                        // while loop for getting commands from the user, until the moving object falls off the area or the user enter 0 to quit the program and print the moving object position
                        while (true)
                            {
                             if (circle.movingObjectFallsOutOfTheArea(movingObject.X_position,movingObject.Y_position)) // to check if the object falls off the area while moving
                                {
                                Console.WriteLine("OPSS! The moving object fell out of the area, so its position is (-1 , -1)"); // (-1 , -1) as asked in the assignmnet 
                                return;
                                }
                            else
                                {
                                while (!(circle.movingObjectFallsOutOfTheArea(movingObject.X_position,movingObject.Y_position)))
                                    {
                                    Console.WriteLine("Enter the command number between 0 and 4:");
                                     int commandNumber = Convert.ToInt32(Console.ReadLine());// converting string to in

                                    switch (commandNumber)
                                        {
                                        case 0:// quit the simulation and give the position
                                            Console.WriteLine("The x,y coordinates for the moving object are "+ movingObject.X_position +"," + movingObject.Y_position );
                                            break;
                                
                                        case 1://move the object forward one step
                                            movingObject.MoveForward();
                                            break;
                                        case 2://move the object backward
                                            movingObject.MoveBackward();
                                            break;
                                        case 3://turn the object clockwise
                                            movingObject.TurnClockwise();
                                            break;
                                        case 4://turn the object counterclockwise
                                            movingObject.TurnCounterClockwise();
                                            break;
                                        default ://the input number is wrong
                                            Console.WriteLine("Wrong number.");
                                            break;
                               
                                        }
                                    }
                                }
                        
                             }
                    }

                     default :// to check if the user does not enter any number out of the range
                                        Console.WriteLine("Wrong number!");
                                        goto SelectedArea;
        }
    }
        }
    }
    
