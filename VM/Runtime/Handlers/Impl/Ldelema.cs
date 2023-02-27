namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldelema : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int index = operand.IsVoid ? ctx.VMStack.Pop().Unbox() : operand.Unbox();
            Array arr = ctx.VMStack.Pop().Unbox();
            ctx.VMStack.Push(VMObject.GetPointer(ref arr.GetValue(index)));

            ctx.Position++;
        }
    }
}