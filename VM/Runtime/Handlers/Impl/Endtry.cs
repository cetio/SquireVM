namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Endtry : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.Position++;
        }
    }
}