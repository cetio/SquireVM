namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Brtrue : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();

            if (vobj.IsBool ? vobj.Unbox() == true : vobj.IsNumeric && vobj.Unbox() == 1)
                ctx.Position = operand.Unbox();
            else
                ctx.Position++;
        }
    }
}