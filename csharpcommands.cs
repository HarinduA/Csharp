Console.WriteLine

Description: Writes the specified data, followed by the current line terminator, to the standard output stream.
Return Type: void
Example: Console.WriteLine("Hello, World!");
Console.ReadLine

Description: Reads the next line of characters from the standard input stream.
Return Type: string
Example: string input = Console.ReadLine();
Math.Sqrt

Description: Returns the square root of a specified number.
Return Type: double
Example: double result = Math.Sqrt(16);
DateTime.Now

Description: Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.
Return Type: DateTime
Example: DateTime currentTime = DateTime.Now;
String.Length

Description: Gets the number of characters in the current String object.
Return Type: int
Example: int length = "Hello".Length;
String.Split

Description: Splits a string into substrings based on the characters in an array.
Return Type: string[]
Example: string[] words = "Hello World".Split(' ');
String.Contains

Description: Determines whether a substring occurs within a string.
Return Type: bool
Example: bool containsHello = "Hello World".Contains("Hello");
List<T>.Add

Description: Adds an object to the end of the List<T>.
Return Type: void
Example: List<int> numbers = new List<int>(); numbers.Add(1);
List<T>.Count

Description: Gets the number of elements contained in the List<T>.
Return Type: int
Example: int count = numbers.Count;
Dictionary<TKey, TValue>.Add

Description: Adds the specified key and value to the Dictionary<TKey, TValue>.
Return Type: void
Example: var dict = new Dictionary<int, string>(); dict.Add(1, "One");
Dictionary<TKey, TValue>.ContainsKey

Description: Determines whether the Dictionary<TKey, TValue> contains the specified key.
Return Type: bool
Example: bool hasKey = dict.ContainsKey(1);
