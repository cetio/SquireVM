namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldelem : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int index = operand.IsVoid ? ctx.VMStack.Pop().Unbox() : operand.Unbox();
            Array arr = ctx.VMStack.Pop().Unbox();
            
            ctx.VMStack.Push(arr.GetValue(index));

            ctx.Position++;
        }
    }
}