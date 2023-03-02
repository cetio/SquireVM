namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ret : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.VMStack.Count == 0 ? typeof(void) : ctx.VMStack.Pop());
            
            ctx.Position++;
        }
    }
}