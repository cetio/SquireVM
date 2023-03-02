namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ceq : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject y = ctx.VMStack.Pop();
            VMObject x = ctx.VMStack.Pop();
            
            ctx.VMStack.Push(x == y);
            
            ctx.Position++;
        }
    }
}