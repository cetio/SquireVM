namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Arglist : OpCode
    {
        public unsafe override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(VMObject.GetPointer(ref ctx.Arguments[0])));
            ctx.Position++;
        }
    }
}