using System;
using System.Runtime.InteropServices;

class CallC {
    [DllImport("add.o")]
    public static extern int add(int a, int b);

    public static void Main(string[] args) {
        int result = add(3, 4);
        Console.WriteLine("Result of 3 + 4 is: " + result);
    }
}