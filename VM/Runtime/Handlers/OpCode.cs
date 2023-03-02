namespace Squire.VM.Runtime.Handlers
{
    public interface OpCode
    {
        void Run(Context ctx, VMObject operand);
    }
}