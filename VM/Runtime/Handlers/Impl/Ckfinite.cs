namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ckfinite : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            
            if (!vobj.IsNumeric || Double.IsInfinity(vobj.Unbox()))
                throw new NotFiniteNumberException();

            ctx.VMStack.Push(vobj);

            ctx.Position++;
        }
    }
}