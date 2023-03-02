namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Not : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            
            ctx.VMStack.Push(vobj.IsBool ? !vobj.Unbox() : ~vobj.Unbox());
            
            ctx.Position++;
        }
    }
}