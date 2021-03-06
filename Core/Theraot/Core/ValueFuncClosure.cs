﻿// <auto-generated />

using Theraot.Core.System;

namespace Theraot.Core.Theraot.Core
{

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<TReturn>
    {
        private readonly Func<TReturn> _target;
        private TReturn _result;
        

        public ValueFuncClosure(Func<TReturn> target)
        {
            
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke();
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke();
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T, TReturn>
    {
        private readonly Func<T, TReturn> _target;
        private TReturn _result;
        private readonly T _obj;

        public ValueFuncClosure(Func<T, TReturn> target, T obj)
        {
            _obj = obj;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_obj);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_obj);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, TReturn>
    {
        private readonly Func<T1, T2, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;

        public ValueFuncClosure(Func<T1, T2, TReturn> target, T1 arg1, T2 arg2)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, TReturn>
    {
        private readonly Func<T1, T2, T3, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;

        public ValueFuncClosure(Func<T1, T2, T3, TReturn> target, T1 arg1, T2 arg2, T3 arg3)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;

        public ValueFuncClosure(Func<T1, T2, T3, T4, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;
        private readonly T12 _arg12;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _arg12 = arg12;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;
        private readonly T12 _arg12;
        private readonly T13 _arg13;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _arg12 = arg12;
            _arg13 = arg13;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;
        private readonly T12 _arg12;
        private readonly T13 _arg13;
        private readonly T14 _arg14;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _arg12 = arg12;
            _arg13 = arg13;
            _arg14 = arg14;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;
        private readonly T12 _arg12;
        private readonly T13 _arg13;
        private readonly T14 _arg14;
        private readonly T15 _arg15;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _arg12 = arg12;
            _arg13 = arg13;
            _arg14 = arg14;
            _arg15 = arg15;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public class ValueFuncClosure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> _target;
        private TReturn _result;
        private readonly T1 _arg1;
        private readonly T2 _arg2;
        private readonly T3 _arg3;
        private readonly T4 _arg4;
        private readonly T5 _arg5;
        private readonly T6 _arg6;
        private readonly T7 _arg7;
        private readonly T8 _arg8;
        private readonly T9 _arg9;
        private readonly T10 _arg10;
        private readonly T11 _arg11;
        private readonly T12 _arg12;
        private readonly T13 _arg13;
        private readonly T14 _arg14;
        private readonly T15 _arg15;
        private readonly T16 _arg16;

        public ValueFuncClosure(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
            _arg6 = arg6;
            _arg7 = arg7;
            _arg8 = arg8;
            _arg9 = arg9;
            _arg10 = arg10;
            _arg11 = arg11;
            _arg12 = arg12;
            _arg13 = arg13;
            _arg14 = arg14;
            _arg15 = arg15;
            _arg16 = arg16;
            _result = default(TReturn);
            _target = target ?? FuncHelper.GetDefaultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn>();
        }

        public TReturn Result
        {
            get
            {
                return _result;
            }
        }

        public Action InvokeAction()
        {
            return new Action(Invoke);
        }

        public void Invoke()
        {
            _result = _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15, _arg16);
        }

        public TReturn InvokeReturn()
        {
            return _target.Invoke(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15, _arg16);
        }

        public Func<TReturn> InvokeFunc()
        {
            return new Func<TReturn>(InvokeReturn);
        }
    }
}
