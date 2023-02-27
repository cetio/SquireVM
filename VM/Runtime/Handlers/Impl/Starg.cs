namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Starg : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            ctx.Arguments[operand.Unbox()] = vobj;
            
            ctx.Position++;
        }
    }
}