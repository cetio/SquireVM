namespace Squire.VM.Runtime.Handlers
{
    public interface OpCode
    {
        ExceptionHandler ExceptionHandler = ExceptionHandler.None;
        void Run(Context ctx, VMObject operand);
    }
}