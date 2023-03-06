


using ReizTech_Assignment;

// This assignment does not ask for user input validation, so lets hope users can read the instructions :)

Console.Write("Enter the hour (1-12): ");
int hour = int.Parse(Console.ReadLine());

Console.Write("Enter the minute (0-59): ");
int minute = int.Parse(Console.ReadLine());

// hour hand
// There are 12 hours ona a clock and 360 degrees in a full circle, we need to know how many degress the hour handle moves per hour
double fullCircleDegrees = 360.0;
double hoursInADay = 12.0;
double hourDegreesPerHour = fullCircleDegrees / hoursInADay;

// 60 minutes in one hour, we need to find how many degress it moves per one minute
double minutesInOneHour = 60.0;
double hourDegreesPerMinute = hourDegreesPerHour / minutesInOneHour;

// User inputs the hour, we need to calculate the degress based on the hour and minute
double hourHandAngle = (hour % hoursInADay) * hourDegreesPerHour + minute * hourDegreesPerMinute;

//Console.WriteLine($"Hour hand angle is {hourHandAngle}");


// The minute handle moves 360 degress in one minute, we can reuse the previous variables,
// as math is the same for counting degress per minute, as in counting degress per hour
// to not confuse myself I instead chose to not use a variable, but just enter the number 60
double minuteHandDegreesPerMinute = fullCircleDegrees / 60.0;

// User inputs minutes and it calculates the degress of the minute handle
double minuteHandAngle = minute * minuteHandDegreesPerMinute;

//Console.WriteLine($"Minute hand angle is {minuteHandAngle}");

// To calculate the angle between the two hands we need to use Math.Abs, as we need a positive value.
double angleBetweenHands = Math.Abs(hourHandAngle - minuteHandAngle);

// To get the lower value we must compare if angleBetweenHands is less than 180.
// In this logic if angleBetweenHands is less than 180, Math.Min will take the first choice, if it is more than 180,
// it will take the "360 - angleBetweenHands"
double lesserAngle = Math.Min(angleBetweenHands, 360 - angleBetweenHands);

Console.WriteLine($"The calculated lesser angle in degrees between hours arrow and minutes arrow is {lesserAngle} degrees.");

//////////////// calculate the depth of provided structure 
///

// create the branches
Branch mainBranch = new Branch();
Branch branch2 = new Branch();
Branch branch3 = new Branch();
Branch branch4 = new Branch();
Branch branch5 = new Branch();
Branch branch6 = new Branch();
Branch branch7 = new Branch();
Branch branch8 = new Branch();
Branch branch9 = new Branch();
Branch branch10 = new Branch();
Branch branch11 = new Branch();

// I decided to number all the bubbles in the picture in number from left to right from top down..
// Meaning the first bubble in the pic is number 1
// Second layer of the structure has two bubbles so it goes 2 and 3
// I hope this makes sense, because I did not know how to duplicate this kind of structure any other way.

// As per provided structure, the first dot has two children, so I replicated that.
mainBranch.branches.Add(branch2);
mainBranch.branches.Add(branch3);


//The left branch on depth level 2 has one children
branch2.branches.Add(branch4);

//The right branch on depth level 2 has 3 children
branch3.branches.Add(branch5);
branch3.branches.Add(branch6);
branch3.branches.Add(branch7);

//branch 5 has one children
branch5.branches.Add(branch8);

//branch 6 has two children
branch6.branches.Add(branch9);
branch6.branches.Add(branch10);

//branch 9 has one children
branch9.branches.Add(branch11);

// call the calculateDepth method to count how deep does the structure go
int depth = mainBranch.CalculateDepth();

// print the depth
Console.WriteLine("The depth of the structure is: " + depth);



