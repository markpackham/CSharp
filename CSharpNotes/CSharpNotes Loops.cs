// Loops

/*

while loops are good when you know your stopping condition, 
but not when you know how many times you want a program to loop or if you have a specific collection to loop through.

do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.

for loops are best if you want something to run a specific number of times, rather than given a certain condition.

foreach loops are the best way to loop over an array, or any other collection. THEY ARE HOWEVER SLOWER than For Loops
 */

 // break
 while (playerIsAlive) 
{ 
// this code will keep running

  if (playerIsAlive == false) 
  { 
    // eventually if this stopping condition is true, 
    // it will break out of the while loop
    break; 
   } 
 } 

// rest of the program will continue

// continue
// The continue keyword is used to bypass portions of code. 
// It will ignore whatever comes after it in the loop and then will go back to the top and start the loop again.
int bats = 10;

for (int i = 0; i <= 10; i++)
{
  if (i< 9)
  {  
    continue;
  }
  // this will be skipped until i is no longer less than 9
  Console.WriteLine(i);
}


//
// Summary
/*
A loop is a structure in programming where the instructions are written once, but a computer can execute them multiple times
Each execution of those instructions is called an iteration
while loops repeat until a condition changes
do...while loops execute once, and then repeat until a condition changes
for loops repeat for a specified number of times
foreach loops repeat for each item in a collection
jump statements, like break, continue, and return are used to add additional control flow to loops
*/