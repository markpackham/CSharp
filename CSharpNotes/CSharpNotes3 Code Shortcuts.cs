// Code writing shortcuts

// Expression-bodied definitions
// Lazy way to do this
bool IsEven(int num)
{
    return num % 2 == 0;
}
// Is this
bool isEven(int num) => num % 2 == 0;

// Works with void returns
void Shout(string x) => Console.WriteLine(x.ToUpper());

// Lambda Expressions
// lambda expression is a convenient way of defining an anonymous (unnamed) function
// lambda expressions, are great for situations when you need to pass a method as an argument.
bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0);
/*
lambda expressions with one expression (like the above example) take this form. They use the fat arrow, no curly braces, and no semicolon (;):
(input-parameters) => expression
 */

/*
Lambda expressions with more than one expression use curly braces and semicolon:
(input-parameters) => { statement; }
*/
bool hasBigDozen = Array.Exists(numbers, (int num) =>
{
    bool isDozenMultiple = num % 12 == 0;
    bool greaterThan20 = num > 20;
    return isDozenMultiple && greaterThan20;
});

// If you want to be super lazy HOWEVER REMEMBER you spend more time reading code than writing
// We can remove the parameter type if can be inferred
// We can remove the parentheses if there is one parameter
// in the example below we don't need to state that num is an int since  % modulous can only handle numbers
bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0);

// Summary
//
// Expression-bodied definitions can be used for one-line method bodies.

bool isEven(int num) => num % 2 == 0;
// Lambda expressions can be used to create an anonymous method:

bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0);
// You learned two “sub-shortcuts” within lambda expressions:
// You can remove the parameter type if it can be inferred:
bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0);
// You can remove the parentheses if there is one parameter:

bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0);