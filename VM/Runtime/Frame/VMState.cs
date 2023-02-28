namespace Squire.VM.Runtime.Frame
{
    public class VMState
    {
        public VMStack VMStack { get; }
        public VMExStack VMExStack { get; }
        public VMObject[] Locals { get; }
        public VMObject[] Arguments { get; }

        public List<Instruction> Instructions { get; set; }
        public List<ExceptionHandler> ExceptionHandlers { get; set; }
        public int Position { get; set; }
        
        public VMState(object[] parameters)
        {
            VMStack = new VMStack();
            VMExStack = new VMExStack();
            Locals = new VMObject[50];
            Arguments = new VMObject[parameters.Length];
            Instructions = new List<Instruction>();
            ExceptionHandlers = new List<ExceptionHandler>();
            Position = 0;

            foreach (object param in parameters)
                Arguments[parameters.Indexof(param)] = (new VMObject(param));
        }

        public VMObject Run()
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
                    ExceptionHandlers.Add(ExceptionHandlers.Catch);
                else if (doFinally)
                    ExceptionHandlers.Add(ExceptionHandlers.Finally);
                else
                    ExceptionHandlers.Add(ExceptionHandlers.None);
            }

            while (true)
            {
                Instruction instr = Instructions[Position];

                try
                {
                    instr.Run(this);
                }
                catch (Exception ex)
                {
                    ExceptionHandler exHandler = ExceptionHandlers[Position - 1];

                    if (exHandler == ExceptionHandler.None)
                        throw ex;
                    else if (exHandler == ExceptionHandler.Catch)
                        VMExStack.Push(ex);
                    else
                        throw ex;
                }

                if (instr.OpCode == OpCodes.Ret)
                    return VMStack.Pop();
            }
        }
    }
}