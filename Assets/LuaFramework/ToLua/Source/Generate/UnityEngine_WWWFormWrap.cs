﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_WWWFormWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.WWWForm), typeof(System.Object));
		L.RegFunction("AddField", AddField);
		L.RegFunction("AddBinaryData", AddBinaryData);
		L.RegFunction("New", _CreateUnityEngine_WWWForm);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("headers", get_headers, null);
		L.RegVar("data", get_data, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_WWWForm(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.WWWForm obj = new UnityEngine.WWWForm();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.WWWForm.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddField(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(int)))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.AddField(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(string)))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				obj.AddField(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(string), typeof(System.Text.Encoding)))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				System.Text.Encoding arg2 = (System.Text.Encoding)ToLua.ToObject(L, 4);
				obj.AddField(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.WWWForm.AddField");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddBinaryData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(byte[])))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				obj.AddBinaryData(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(byte[]), typeof(string)))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				obj.AddBinaryData(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.WWWForm), typeof(string), typeof(byte[]), typeof(string), typeof(string)))
			{
				UnityEngine.WWWForm obj = (UnityEngine.WWWForm)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				string arg3 = ToLua.ToString(L, 5);
				obj.AddBinaryData(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.WWWForm.AddBinaryData");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_headers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.WWWForm obj = (UnityEngine.WWWForm)o;
			System.Collections.Generic.Dictionary<string,string> ret = obj.headers;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index headers on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_data(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.WWWForm obj = (UnityEngine.WWWForm)o;
			byte[] ret = obj.data;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index data on a nil value" : e.Message);
		}
	}
}

