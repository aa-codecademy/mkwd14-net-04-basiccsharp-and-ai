string[] words = new string[5];
words[0] = "Hello";
words[1] = "World";
words[2] = "C#";
words[3] = "Programming";
words[4] = "Language";

decimal[] decimals = { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m };

char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E' };
char[] characters1 = new[] { 'A', 'B', 'C', 'D', 'E' };

int[][] ints = new int[5][];
ints[0] = new int[3] { 1, 2, 3 };
ints[1] = new int[4] { 4, 5, 6, 7 };
ints[2] = new int[5] { 8, 9, 10, 11, 12 };
ints[3] = new int[2] { 13, 14 };
ints[4] = new int[1] { 15 };

Console.WriteLine(ints[2][1]);

// Array that holds arrays with two integers - Copilot example
int[][] pairs = new int[3][];
pairs[0] = new int[] { 1, 2 };
pairs[1] = new int[] { 3, 4 };
pairs[2] = new int[] { 5, 6 };