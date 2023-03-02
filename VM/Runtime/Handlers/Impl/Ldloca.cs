namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldloca : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            ctx.VMStack.Push(ctx.Locals[operand.Unbox()].GetPointer());
            
            ctx.Position++;
        }
    }
}