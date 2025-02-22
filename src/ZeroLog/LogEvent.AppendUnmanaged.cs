﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using ZeroLog.Utils;

namespace ZeroLog
{
    partial interface ILogEvent
    {
        ILogEvent AppendUnmanaged<T>(T value)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(T value, string format)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(ref T value)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(ref T value, string format)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(T? value)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(T? value, string format)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(ref T? value)
            where T : unmanaged;

        ILogEvent AppendUnmanaged<T>(ref T? value, string format)
            where T : unmanaged;

    }

    unsafe partial class LogEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(T value)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            AppendArgumentType(ArgumentType.Unmanaged);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value;
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(T value, string format)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Unmanaged);
            AppendString(format);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value;
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(ref T value)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            AppendArgumentType(ArgumentType.Unmanaged);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value;
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(ref T value, string format)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Unmanaged);
            AppendString(format);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value;
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(T? value)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Unmanaged);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(T? value, string format)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Unmanaged);
            AppendString(format);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(ref T? value)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Unmanaged);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(T);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent AppendUnmanaged<T>(ref T? value, string format)
            where T : unmanaged
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(UnmanagedArgHeader) + sizeof(T)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Unmanaged);
            AppendString(format);
            *(UnmanagedArgHeader*)_dataPointer = new UnmanagedArgHeader(TypeUtil<T>.TypeHandle, sizeof(T));
            _dataPointer += sizeof(UnmanagedArgHeader);
            *(T*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(T);
            return this;
        }

    }

    partial class NoopLogEvent
    {
        public ILogEvent AppendUnmanaged<T>(T value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T? value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T? value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T? value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T? value, string format)
            where T : unmanaged
            => this;

    }

    partial class ForwardingLogEvent
    {
        public ILogEvent AppendUnmanaged<T>(T value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T? value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(T? value, string format)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T? value)
            where T : unmanaged
            => this;

        public ILogEvent AppendUnmanaged<T>(ref T? value, string format)
            where T : unmanaged
            => this;

    }
}
