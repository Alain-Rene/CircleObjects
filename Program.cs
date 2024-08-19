/*
Program that uses a class Circle, to calculate the diameter, circumference and area based on user's
inputted radius. Also allows the circle to grow, increasizing values
*/
using CircleObjects;

double radius = 0;

System.Console.WriteLine("Hello! Welcome to the circle program");
do {


    System.Console.WriteLine("Please enter the circle's radius:");

    //Try catch if the value inputted cannot be parsed into radius
    try
    {
        radius = double.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        //Display exception message
        System.Console.WriteLine(e.Message);
    }

    
} while(radius == 0);

//Creates a new circle using the user's radius value
Circle userCircle = new Circle(radius);
bool continueProgram = true;
string userInput = "";
bool validInput = false;

do 
{
    System.Console.WriteLine($"Diameter: {userCircle.CalculateDiameter()}");
    System.Console.WriteLine($"Circumference: {userCircle.CalculateCircumference()}");
    System.Console.WriteLine($"Area: {userCircle.CalculateArea()}");
    
    //While loop incase user's input is not valid
    while (!validInput)
    {
        //Ask user to grow circle
        System.Console.WriteLine("Should the circle grow? Please enter y or n)");
        userInput = Console.ReadLine();

        if (userInput.ToLower().Trim() == "y")
        {
            userCircle.Grow();
            validInput = true;
        }
        else if (userInput.ToLower().Trim() == "n")
        {
            System.Console.WriteLine($"Goodbye. The circle's final radius is {userCircle.GetRadius()}");
            validInput = true;
            continueProgram = false;
        }
        else
        {
            System.Console.WriteLine("Invalid input, please try again");
        }
    }
    //Set valid input back to false to prevent infinite loop
    validInput = false;
    
    
} while(continueProgram);

