namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Stind : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            void* source = (void*)ctx.VMStack.Pop().Unbox();
            void* dest = (void*)ctx.VMStack.Pop().Unbox();

            Unsafe.InitBlock(dest, 0, Marshal.SizeOf(type));
            Unsafe.CopyBlock(dest, source, Marshal.SizeOf(type));

            ctx.Position++;
        }
    }
}