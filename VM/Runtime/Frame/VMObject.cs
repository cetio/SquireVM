namespace Squire.VM.Runtime.Frame
{
    public partial class VMObject
    {
        protected object? Value;

        public VMObject(object? obj)
            Value = obj;

        public VMObject(Type type)
            Value = default(type);

        public unsafe object? ToParameter(ParameterInfo derived)
            => Convert.ChangeType(Value, derived.ParameterType);

        public VMObject GetPointer()
        {
            GCHandle handle = GCHandle.Alloc(Value, GCHandleType.Pinned);
            return new VMObject((nint)Unsafe.AsPointer(ref obj));
        }

        public static VMObject GetPointer(ref object? obj)
        {
            GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
            return new VMObject((nint)Unsafe.AsPointer(ref obj));
        }

        public dynamic Unbox()
            => Convert.ChangeType(Value, Value.GetType());

        public object Box()   
            => Value;

        public VMObject ChangeType(Type type)
        {
            Value = Convert.ChangeType(Value, operand);
            return this;
        }

        public bool IsType(Type type)
            => Value.GetType() == type;
        
        public bool IsVoid
            => Value == typeof(void);

        public bool IsPointer
            => IsNint || Value.GetType().IsPointer;

        public bool IsNint
            => IsType(typeof(nuint));

        public bool IsByte
            => IsType(typeof(byte));

        public bool IsShort 
            => IsType(typeof(short));

        public bool IsInt 
            => IsType(typeof(int));

        public bool IsLong
            => IsType(typeof(long));

        public bool IsNUint
            => IsType(typeof(nuint));

        public bool IsSByte
            => IsType(typeof(sbyte));

        public bool IsUShort
            => IsType(typeof(ushort));

        public bool IsUInt
            => IsType(typeof(uint));

        public bool IsULong
            => IsType(typeof(ulong));

        public bool IsDouble
            => IsType(typeof(double));

        public bool IsFloat
            => IsType(typeof(float));

        public bool IsDecimal 
            => IsType(typeof(decimal));

        public bool IsString
            => IsType(typeof(string));

        public bool IsBool
            => IsType(typeof(bool)) || (IsInt && (Value == 0 || Value == 1));

        public bool IsNumeric 
            => !IsVoid && (IsByte || IsShort || IsInt || IsLong || IsSByte || IsUShort || IsUInt || IsULong || IsDouble || IsFloat || IsDecimal);
    }
}