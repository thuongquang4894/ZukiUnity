﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ToolManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ToolManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("create_notify", create_notify);
		L.RegFunction("cancel_notify", cancel_notify);
		L.RegFunction("copy", copy);
		L.RegFunction("save_kc", save_kc);
		L.RegFunction("load_kc", load_kc);
		L.RegFunction("save_photo", save_photo);
		L.RegFunction("load_file", load_file);
		L.RegFunction("load_url", load_url);
		L.RegFunction("load_http", load_http);
		L.RegFunction("unload_http", unload_http);
		L.RegFunction("CountVerInf", CountVerInf);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int create_notify(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5 && TypeChecker.CheckTypes<int, int>(L, 4))
			{
				ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				obj.create_notify(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<string, int>(L, 4))
			{
				ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				obj.create_notify(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ToolManager.create_notify");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int cancel_notify(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			obj.cancel_notify();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int copy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.copy(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int save_kc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.save_kc(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int load_kc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			obj.load_kc();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int save_photo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.save_photo(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int load_file(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.load_file(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int load_url(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes<LuaInterface.LuaFunction>(L, 3))
			{
				ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				obj.load_url(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<System.Action<UnityEngine.WWW>>(L, 3))
			{
				ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action<UnityEngine.WWW> arg1 = (System.Action<UnityEngine.WWW>)ToLua.ToObject(L, 3);
				obj.load_url(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ToolManager.load_url");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int load_http(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.WWWForm arg1 = (UnityEngine.WWWForm)ToLua.CheckObject<UnityEngine.WWWForm>(L, 3);
			LuaFunction arg2 = ToLua.CheckLuaFunction(L, 4);
			LuaFunction arg3 = ToLua.CheckLuaFunction(L, 5);
			obj.load_http(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int unload_http(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToolManager obj = (ToolManager)ToLua.CheckObject<ToolManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.unload_http(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CountVerInf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			int o = ToolManager.CountVerInf(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
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
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
