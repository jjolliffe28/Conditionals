// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var isSunny = true;
var isRaining = false;
var isCold = false;
var temp = 75;

if (isSunny && temp > 65)
{
    Console.WriteLine("It's sunny outside!");
}
else if (isSunny && temp >= 65)
{
    Console.WriteLine("Its a lovely day!");
}
else
{
    Console.WriteLine("It's not sunny outside!");
}

// How do we expand this to include more conditions?
// Else if block allows us as a user to check for an additional condition in the event that the first one is false

// What if we dont want to do anything in the else block
// Else If and the Else blocks are both optional

if(isSunny)
{
    Console.WriteLine("example");
}
else if (isSunny || true)
{
    Console.WriteLine("WOW!");
}

//Switch Case Statement
// We can use Switch/Case with many other values instead of just booleans
// int, bool, enums, floats, strings, characters....
// You provide a value you want to 'switch' on, and the code falls into a 'case' where the values mactch
// Essentially... a switch case is just a bunch of equality checks

var errorCode = 404;
switch(errorCode)
{
    case 404:
        Console.WriteLine("Page not found.");
        break;
    case 203:
        Console.WriteLine("Incorrect Value");
        goto case 404;
    case 502:
        Console.WriteLine("API error");
        break;
    default:
        Console.WriteLine("Unknown error occured");
        break;


}

// break ends the switch case
// goto case X -> jumps over to another case
// goto default -> jumps to default
// we can put case lables next to each other without code inbetweeb if we want them to perform the same action

// Ternary Statements
// Ternary is split into 3 parts
// Part 1: Question (condition)
// Pt. 2: Value if true
// Pt 3: Value if false
// One of the main uses for ternary statements is shorthand for assigning values of some kind

var moodRating = 0;
var isHappy = false;
var isGlad = true;

if(isHappy)
{
    moodRating = 100;
}
else
{
    moodRating = -100;
}

// this is same as the above lines of code
moodRating = isHappy ? 100 : -100;

// asks the question if we are happy - if so value 100 - if not value -100

// Increment/Compound Operators
// Shorthand for repeated operations/actions
// How do we change the value of moodRating by 1?

moodRating = moodRating + 1; //increases the value of moodRating by 1
moodRating += 1; // (slightly different from =+), but for now just use +=
// generalized: variable += X -> increases variable by X

//shorthand for increasing a variable by 1:
moodRating++; // -- decreases a variable by 1

moodRating *= 100; // times the value of moodRating by 100 and stores the new value