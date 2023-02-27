namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Initblk : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int len = ctx.VMStack.Pop().Unbox();
            byte initValue = ctx.VMStack.Pop().Unbox();
            void* dest = (void*)ctx.VMStack.Pop().Unbox();

            Unsafe.InitBlock(dest, initValue, len);

            ctx.Position++;
        }
    }
}