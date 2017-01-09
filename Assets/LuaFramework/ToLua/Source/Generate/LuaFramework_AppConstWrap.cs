﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_AppConstWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.AppConst), typeof(System.Object));
		L.RegFunction("AppContentPath", AppContentPath);
		L.RegFunction("New", _CreateLuaFramework_AppConst);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("SDKMode", 0);
		L.RegConstant("UpdateMode", 0);
		L.RegConstant("LuaByteMode", 1);
		L.RegConstant("LuaBundleMode", 1);
		L.RegConstant("assetExtract", 0);
		L.RegConstant("TimerInterval", 1);
		L.RegConstant("GameFrameRate", 45);
		L.RegVar("AppName", get_AppName, null);
		L.RegVar("AppPath", get_AppPath, null);
		L.RegVar("AppResName", get_AppResName, null);
		L.RegVar("FrameWorkPath", get_FrameWorkPath, null);
		L.RegVar("AppPrefix", get_AppPrefix, null);
		L.RegVar("ExtName", get_ExtName, null);
		L.RegVar("LuaExtName", get_LuaExtName, null);
		L.RegVar("LuaBundleName", get_LuaBundleName, null);
		L.RegVar("AssetDir", get_AssetDir, null);
		L.RegVar("WebUrl", get_WebUrl, null);
		L.RegVar("LuaTempDir", get_LuaTempDir, null);
		L.RegVar("PublishAssetDir", get_PublishAssetDir, set_PublishAssetDir);
		L.RegVar("UserId", get_UserId, set_UserId);
		L.RegVar("SocketPort", get_SocketPort, set_SocketPort);
		L.RegVar("SocketAddress", get_SocketAddress, set_SocketAddress);
		L.RegVar("EditorBuildsName", get_EditorBuildsName, null);
		L.RegVar("EditorBuilds", get_EditorBuilds, null);
		L.RegVar("EditorBuildResourcePath", get_EditorBuildResourcePath, null);
		L.RegVar("ResourceNameSplit", get_ResourceNameSplit, null);
		L.RegVar("AssetName", get_AssetName, null);
		L.RegVar("FinalSingleFileExt", get_FinalSingleFileExt, set_FinalSingleFileExt);
		L.RegVar("FinalSingleFile", get_FinalSingleFile, set_FinalSingleFile);
		L.RegVar("FinalSingleFileInfoExt", get_FinalSingleFileInfoExt, set_FinalSingleFileInfoExt);
		L.RegVar("FinalSingleFileInfo", get_FinalSingleFileInfo, set_FinalSingleFileInfo);
		L.RegVar("FinalSingleFileInfoMD5", get_FinalSingleFileInfoMD5, set_FinalSingleFileInfoMD5);
		L.RegVar("BuildsName", get_BuildsName, null);
		L.RegVar("Builds", get_Builds, null);
		L.RegVar("ReleasePathRoot", get_ReleasePathRoot, null);
		L.RegVar("PublishAssets", get_PublishAssets, set_PublishAssets);
		L.RegVar("PublishPathRoot", get_PublishPathRoot, null);
		L.RegVar("PublishResourcePath", get_PublishResourcePath, null);
		L.RegVar("ReleaseResourcePath", get_ReleaseResourcePath, null);
		L.RegVar("PatchFileName", get_PatchFileName, null);
		L.RegVar("PatchRecordFile", get_PatchRecordFile, null);
		L.RegVar("PatchTempPath", get_PatchTempPath, null);
		L.RegVar("SimulateAssetBundleInEditor", get_SimulateAssetBundleInEditor, set_SimulateAssetBundleInEditor);
		L.RegVar("FrameworkRoot", get_FrameworkRoot, null);
		L.RegVar("AppRoot", get_AppRoot, null);
		L.RegVar("StreamingAssetsPath", get_StreamingAssetsPath, null);
		L.RegVar("PublishAssetsPath", get_PublishAssetsPath, null);
		L.RegVar("DataPath", get_DataPath, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_AppConst(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				LuaFramework.AppConst obj = new LuaFramework.AppConst();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaFramework.AppConst.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppContentPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = LuaFramework.AppConst.AppContentPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppResName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppResName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FrameWorkPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FrameWorkPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppPrefix(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppPrefix);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ExtName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.ExtName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaExtName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.LuaExtName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaBundleName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.LuaBundleName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AssetDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AssetDir);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WebUrl(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.WebUrl);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaTempDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.LuaTempDir);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PublishAssetDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PublishAssetDir);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UserId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.UserId);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketPort(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, LuaFramework.AppConst.SocketPort);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketAddress(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.SocketAddress);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EditorBuildsName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.EditorBuildsName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EditorBuilds(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.EditorBuilds);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EditorBuildResourcePath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.EditorBuildResourcePath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ResourceNameSplit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.ResourceNameSplit);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AssetName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AssetName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FinalSingleFileExt(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FinalSingleFileExt);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FinalSingleFile(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FinalSingleFile);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FinalSingleFileInfoExt(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FinalSingleFileInfoExt);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FinalSingleFileInfo(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FinalSingleFileInfo);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FinalSingleFileInfoMD5(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FinalSingleFileInfoMD5);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BuildsName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.BuildsName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Builds(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.Builds);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReleasePathRoot(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.ReleasePathRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PublishAssets(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PublishAssets);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PublishPathRoot(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PublishPathRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PublishResourcePath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PublishResourcePath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReleaseResourcePath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.ReleaseResourcePath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PatchFileName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PatchFileName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PatchRecordFile(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PatchRecordFile);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PatchTempPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PatchTempPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SimulateAssetBundleInEditor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, LuaFramework.AppConst.SimulateAssetBundleInEditor);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FrameworkRoot(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FrameworkRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppRoot(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppRoot);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.StreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PublishAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.PublishAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.AppConst.DataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PublishAssetDir(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.PublishAssetDir = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UserId(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.UserId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketPort(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			LuaFramework.AppConst.SocketPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketAddress(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.SocketAddress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FinalSingleFileExt(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.FinalSingleFileExt = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FinalSingleFile(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.FinalSingleFile = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FinalSingleFileInfoExt(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.FinalSingleFileInfoExt = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FinalSingleFileInfo(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.FinalSingleFileInfo = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FinalSingleFileInfoMD5(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.FinalSingleFileInfoMD5 = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PublishAssets(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.PublishAssets = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SimulateAssetBundleInEditor(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			LuaFramework.AppConst.SimulateAssetBundleInEditor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
