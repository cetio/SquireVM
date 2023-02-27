namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldloc : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.Locals[operand.Unbox()]);
            ctx.Position++;
        }
    }
}