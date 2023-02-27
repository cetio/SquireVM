namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Throw : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            Exception ex = ctx.VMStack.Pop().Unbox();
            throw ex;

            ctx.Position++;
        }
    }
}