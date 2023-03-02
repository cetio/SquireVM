namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Break : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            Debugger.Break();
            
            ctx.Position++;
        }
    }
}