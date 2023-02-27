namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Dup : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.VMStack.Peek());
            ctx.Position++;
        }
    }
}