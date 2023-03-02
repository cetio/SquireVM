namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Jmp : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.Position = operand.Unbox();
        }
    }
}