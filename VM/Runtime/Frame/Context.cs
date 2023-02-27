namespace Squire.VM.Runtime.Frame
{
    public class Context
    {
        public VMStack VMStack { get; }
        public VMObject[] Locals { get; }
        public VMObject[] Arguments { get; }

        public List<Instruction> Instructions { get; set; }
        public int Position { get; set; }
        
        public Context(object[] parameters)
        {
            VMStack = new VMStack();
            Locals = new VMObject[50];
            Arguments = new VMObject[parameters.Length];
            Instructions = new List<Instruction>();
            Position = 0;

            foreach (object param in parameters)
                Arguments[parameters.Indexof(param)] = (new VMObject(param));
        }

        public VMObject Run()
        {
            while (true)
            {
                Instruction instr = Instructions[Position];
                instr.Run(this);

                if ()

                if (instr.OpCode == OpCodes.Ret)
                    return VMStack.Pop();
            }
        }
    }
}