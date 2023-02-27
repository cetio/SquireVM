namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Stloc : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            ctx.Locals[operand.Unbox()] = vobj;
            
            ctx.Position++;
        }
    }
}