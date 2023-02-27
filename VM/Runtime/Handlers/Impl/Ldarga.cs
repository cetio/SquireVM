namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldarga : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.Arguments[operand.Unbox()].GetPointer());
            ctx.Position++;
        }
    }
}