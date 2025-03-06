using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeComputer
{
#nullable disable

    internal class Computer
    {
        string originalProgram = "";
        List<int> program = new List<int>();

        List<int> outputBuffer = new List<int>();
        List<int> inputBuffer = new List<int>();

        int currentCode;
        public int currentValue
        {
            get
            {
                return program[currentCode];
            }
        }

        public enum State { Ready, WairingForInput, Halted }
        public State state { get; private set; }

        const int ADD_OP = 1;
        const int MULT_OP = 2;
        const int INPUT_OP = 3;
        const int OUTPUT_OP = 4;
        const int HALT_OP = 99;

        public Computer(string programString)
        {

            originalProgram = programString;
            Reset();

        }

        public void Run()
        {
            while (currentValue != HALT_OP)
            {
                executeInstruction();
            }
        }

        void executeInstruction()
        {
            
            int op = GetValue(currentCode);
            int a = GetValue(currentCode + 1);
            int b = GetValue(currentCode + 2);
            int c = GetValue(currentCode + 3);

            switch (op)
            {
                
                case ADD_OP:
                    Add(a, b, c);
                    break;
                case MULT_OP:
                    Mult(a, b, c);
                    break;
                case HALT_OP:
                    return;

            }

            currentCode += 4;

        }

        public int GetValue(int position)
        {
            return program[position];
        }

        public void Reset()
        {

            program.Clear();
            string[] codes = originalProgram.Split(",");

            foreach (string code in codes)
            {
                
                program.Add(int.Parse(code));

            }

            for (int i = 0; i < 4; i++) program.Add(0);

            inputBuffer.Clear();
            outputBuffer.Clear();

            currentCode = 0;
        
            state = State.Ready;

        }

        void Add (int a, int b, int dest)
        {
            program[dest] = GetValue(a) + GetValue(b);
        }

        void Mult(int a, int b, int dest)
        {
            program[dest] = GetValue(a) * GetValue(b);
        }
    
    }

}