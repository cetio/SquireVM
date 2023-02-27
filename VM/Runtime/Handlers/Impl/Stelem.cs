namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Stelem : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            object obj = ctx.VMStack.Pop().Unbox();
            int index = int index = operand.IsVoid ? ctx.VMStack.Pop().Unbox() : operand.Unbox();
            Array arr = ctx.VMStack.Pop().Unbox();

            arr.SetValue(obj, index);

            ctx.Position++;
        }
    }
}