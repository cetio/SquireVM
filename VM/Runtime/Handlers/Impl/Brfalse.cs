namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Brfalse : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();

            if (vobj.IsBool ? vobj.Unbox() == false : vobj.IsNumeric && vobj.Unbox() == 0)
                ctx.Position = operand.Unbox();
            else
                ctx.Position++;
        }
    }
}