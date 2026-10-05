using System.Net.Http.Headers;

byte smallNumber = 2;
short mediumNumber = 6;
int normalNumber = 42;
long largeNumber = 1000;
float singlePrecision = 2.1f;
double doublePrecision = 2.0;
decimal highPrecision = 3.14m;
char singleCharacter = 'a';
bool isTrue = true;
string s = "3.14";
string convertedInt = normalNumber.ToString();
double convertedstring = Convert.ToDouble(s);

Console.WriteLine($"int: {normalNumber}");
Console.WriteLine($"string: {s}");