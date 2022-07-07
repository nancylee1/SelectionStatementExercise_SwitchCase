//Exercise 2
//    Create a switch/case statement:
//Inside the scope of your Main() method
// Ask the user for their favorite school subject. 
//Store their answer in a variable
//Pass the variable as the expression in a switch statement.
//Create 5 different cases for different subjects.  Each case will print the subject chosen and a custom message of your choosing.
//Create a default case to handle any case not handled.
//Save your work:

Console.WriteLine("Hi studious elementary school student, what's your favorite school subject?: ");
string favoriteSubject = Console.ReadLine();

switch (favoriteSubject.ToLower())
{
    case "health":
        Console.WriteLine("Great! You like to stay fit.");
        break;
    case "math":
        Console.WriteLine("That's great, math is fun!");
        break;
    case "science":
        Console.WriteLine("I love science too!");
        break;
    case "language arts":
        Console.WriteLine("This is my favorite subject too!");
        break;
    case "history":
        Console.WriteLine("Wonderful, learning about our history is important!");
        break;
    case "spelling":
        Console.WriteLine("Terrific! Knowing how to spell is going to get you far in life!");
        break;
    default:
        Console.WriteLine("That's not something a young elementary school student should be learning at your age. Haha! Just kidding.");
        break;
}