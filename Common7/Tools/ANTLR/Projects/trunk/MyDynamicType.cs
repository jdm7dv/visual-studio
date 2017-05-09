using AJScript.ScriptingClasses;
using System;

public class MyDynamicType : JSGlobalContext
{
    private static JSDebugFunctionDef[] fnclist;

    static MyDynamicType()
    {
        JSDebugFunctionDef[] defArray = new JSDebugFunctionDef[1];
        JSDebugFunctionDef def = new JSDebugFunctionDef();
        def.param_names = new string[0];
        def.del = new Func<JSContext, JSValue>(MyDynamicType.__func_0);
        defArray[0] = def;
        fnclist = defArray;
    }

    public static JSValue __func_0(JSContext context)
    {
        return JSUndefined.Instance;
    }

    public JSValue __Run()
    {
        JSValue value2;
        JSContext context = new MyDynamicType();
        JSContext.PushContext(context);
        try
        {
            value2 = GlobalCode(context);
        }
        finally
        {
            JSContext.PopContext();
        }
        return value2;
    }

    public override JSValue GetFunctionReference(int key, JSEnvRec r)
    {
        return new JSDebugFunction(fnclist[key], r);
    }

    public static JSValue GlobalCode(JSContext context)
    {
        context.ReturnValue = JSUndefined.Instance;
        context.CreateMutableBinding("__func");
        context.SetVarBinding("__func", context.GetFunctionReference(0));
        context.ReturnValue = JSValue.JSEqualsExact(context.GetBindingValue("__func")["prototype"]["constructor"], context.GetBindingValue("__func"));
        return context.ReturnValue;
    }
}

