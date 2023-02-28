namespace Squire.VM.Runtime
{
    public class FrameInterop
    {
        public static VMState CreateState(List<Instruction> instructions, object[] params)
        {
            VMState state = new VMState(params);
            state.Instructions = instructions;

            return state;
        }
    }
}