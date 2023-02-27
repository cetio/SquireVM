namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldlen : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            Array arr = ctx.VMStack.Pop().Unbox();
            ctx.VMStack.Push(arr.Length);

            ctx.Position++;
        }
    }
}