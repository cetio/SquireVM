namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Endcatch : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.Position++;
        }
    }
}