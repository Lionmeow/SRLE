﻿#nullable enable
using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace SRLE
{

#pragma warning disable CS8500

    [StructLayout(LayoutKind.Sequential)]
    public struct NullableStruct<T> where T : new()
    {
        private static readonly IntPtr classPtr = Il2CppClassPointerStore<Il2CppSystem.Nullable<T>>.NativeClassPtr;

        public T value;
        public bool has_value;

        public NullableStruct(T value)
        {
            this.has_value = true;
            this.value = value;
        }

        public static implicit operator T?(NullableStruct<T> inst)
        {
            if (inst.has_value) { return inst.value; }
            return default;
        }

        public static implicit operator NullableStruct<T>(T? inst)
        {
            if (inst != null) { return new NullableStruct<T>(inst); }
            return default;
        }

        public static unsafe implicit operator NullableStruct<T>(Il2CppSystem.Nullable<T> boxed)
        {
            return *(NullableStruct<T>*)IL2CPP.il2cpp_object_unbox(boxed.Pointer);
        }

        public static unsafe implicit operator Il2CppSystem.Nullable<T>(NullableStruct<T> toBox)
        {
            IntPtr boxed;
            if (toBox.has_value == false) { boxed = toBox.ForceBox(); }
            else { boxed = IL2CPP.il2cpp_value_box(classPtr, (IntPtr)(&toBox)); }
            return new Il2CppSystem.Nullable<T>(boxed);
        }

        private unsafe IntPtr ForceBox()
        {
            IntPtr obj = IL2CPP.il2cpp_object_new(classPtr);
            NullableStruct<T>* boxedValPtr = (NullableStruct<T>*)IL2CPP.il2cpp_object_unbox(obj);
            *boxedValPtr = this;
            return obj;
        }
    }
}
#pragma warning restore CS8500