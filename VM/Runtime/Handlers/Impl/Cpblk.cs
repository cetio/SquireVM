namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Cpblk : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int len = ctx.VMStack.Pop().Unbox();
            void* source = (void*)ctx.VMStack.Pop().Unbox();
            void* dest = (void*)ctx.VMStack.Pop().Unbox();

            Unsafe.InitBlock(dest, 0, Marshal.SizeOf(type));
            Unsafe.CopyBlock(dest, source, len);

            ctx.Position++;
        }
    }
}