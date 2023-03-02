namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Rethrow : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            throw ctx.ExStack.Pop();

            ctx.Position++;
        }
    }
}