namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldne : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(operand);
            
            ctx.Position++;
        }
    }
}