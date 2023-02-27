namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Pop : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Pop();
            ctx.Position++;
        }
    }
}