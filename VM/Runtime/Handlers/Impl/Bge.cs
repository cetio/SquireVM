namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Bge : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject y = ctx.VMStack.Pop();
            VMObject x = ctx.VMStack.Pop();

            ctx.Position = (x >= y ? operand.Unbox() : ctx.Position + 1);
        }
    }
}