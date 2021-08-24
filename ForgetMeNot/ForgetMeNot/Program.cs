using System;

namespace ForgetMeNot
{
    class Program
    {

        static string m_Hello = "Hello Jess"; 

        static void Main(string[] args)
        {
            WriteConsole(m_Hello);
        }

        static void WriteConsole(string txt)
        {
            Console.WriteLine(txt);
        }

    }
}
 