namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Conv : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            ctx.VMStack.Push(vobj.ChangeType(operand.Unbox()));
            
            ctx.Position++;
        }
    }
}