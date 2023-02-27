namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Neg : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            ctx.VMStack.Push(vobj.Unbox() * -1);
            
            ctx.Position++;
        }
    }
}