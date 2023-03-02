namespace Squire.VM.Runtime.Frame
{
    public class VMState
    {
        public VMStack VMStack { get; }
        public VMObject[] Locals { get; }
        public VMObject[] Arguments { get; }
        public Stack<Exception> ExStack { get; }

        public List<Instruction> Instructions { get; set; }
        public int Position { get; set; }
        
        public VMState(object[] parameters)
        {
            VMStack = new VMStack();
            Locals = new VMObject[50];
            Arguments = new VMObject[parameters.Length];
            ExStack = new Stack<Exception>();
            Instructions = new List<Instruction>();
            Position = 0;

            foreach (object param in parameters)
                Arguments[parameters.Indexof(param)] = (new VMObject(param));
        }

        public object? Run()
        {
            bool doCatch = false;
            bool doFinally = false;
            
            foreach (Instruction inst in Instructions)
            {
                if (inst.OpCode == OpCodes.Begincatch)
                    doCatch = true;
                else if (inst.OpCode == OpCodes.Endcatch)
                    doCatch = false;
                else if (inst.OpCode == OpCodes.Beginfinally)
                    doFinally = true;
                else if (inst.OpCode == OpCodes.Endfinally)
                    doFinally = false;

                if (doCatch)
                    inst.ExceptionHandler = ExceptionHandler.Catch;
                else if (doFinally)
                    inst.ExceptionHandler = ExceptionHandler.Finally;
            }

            while (true)
            {
                Instruction instr = Instructions[Position];

                try
                {
                    if (instr.ExceptionHandler == ExceptionHandler.Overflow)
                    {
                        unchecked
                        {
                            instr.Run(this);
                        }
                    }
                    else
                    {
                        instr.Run(this);
                    }
                }
                catch (Exception ex)
                {
                    if (inst.ExceptionHandler == ExceptionHandler.None)
                        throw ex;
                    else if (instr.ExceptionHandler == ExceptionHandler.Catch)
                        ExStack.Push(ex);
                    else
                        throw ex;
                }

                if (instr.OpCode == OpCodes.Ret)
                    return VMStack.Pop().Box();
            }
        }
    }
}