﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_LuaBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.LuaBehaviour), typeof(View));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("setLuaScript", setLuaScript);
		L.RegFunction("getLuaScript", getLuaScript);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("initialize", get_initialize, set_initialize);
		L.RegVar("luaTableObject", get_luaTableObject, set_luaTableObject);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.OnInit(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			obj.ClearClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setLuaScript(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.setLuaScript(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLuaScript(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			LuaInterface.LuaTable o = obj.getLuaScript();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_initialize(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, LuaFramework.LuaBehaviour.initialize);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaTableObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			LuaInterface.LuaTable ret = obj.luaTableObject;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaTableObject on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_initialize(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			LuaFramework.LuaBehaviour.initialize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaTableObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.luaTableObject = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaTableObject on a nil value" : e.Message);
		}
	}
}
