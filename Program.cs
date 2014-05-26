using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Character newCharacter = new Character();
            Console.WriteLine(newCharacter.characterSummary());

            Console.ReadLine();
        }
    }
}
