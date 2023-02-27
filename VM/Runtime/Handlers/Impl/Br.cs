namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Br : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.Position = operand.Unbox();
        }
    }
}