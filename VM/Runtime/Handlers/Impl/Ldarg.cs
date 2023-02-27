namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldarg : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.Arguments[operand.Unbox()]);
            ctx.Position++;
        }
    }
}