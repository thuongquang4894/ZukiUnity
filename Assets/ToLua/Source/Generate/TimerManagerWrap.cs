﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TimerManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TimerManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("AddTimer", AddTimer);
		L.RegFunction("RemoveTimer", RemoveTimer);
		L.RegFunction("AddRepeatTimer", AddRepeatTimer);
		L.RegFunction("RemoveRepeatTimer", RemoveRepeatTimer);
		L.RegFunction("set_server_time", set_server_time);
		L.RegFunction("dtnow", dtnow);
		L.RegFunction("now", now);
		L.RegFunction("now_string", now_string);
		L.RegFunction("native_now", native_now);
		L.RegFunction("time2dt", time2dt);
		L.RegFunction("get_time_show", get_time_show);
		L.RegFunction("GetTime", GetTime);
		L.RegFunction("last_time_today", last_time_today);
		L.RegFunction("trigger_time", trigger_time);
		L.RegFunction("trigger_week_time", trigger_week_time);
		L.RegFunction("trigger_month_time", trigger_month_time);
		L.RegFunction("run_day", run_day);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("start_time_", get_start_time_, set_start_time_);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes<System.Action, float>(L, 3))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action arg1 = (System.Action)ToLua.ToObject(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.AddTimer(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<LuaInterface.LuaFunction, float>(L, 3))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.AddTimer(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TimerManager.AddTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveTimer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddRepeatTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5 && TypeChecker.CheckTypes<LuaInterface.LuaFunction, float, float>(L, 3))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
				obj.AddRepeatTimer(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<System.Action, float, float>(L, 3))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action arg1 = (System.Action)ToLua.ToObject(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				float arg3 = (float)LuaDLL.lua_tonumber(L, 5);
				obj.AddRepeatTimer(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TimerManager.AddRepeatTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRepeatTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveRepeatTimer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_server_time(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<ulong>(L, 2))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				ulong arg0 = LuaDLL.tolua_touint64(L, 2);
				obj.set_server_time(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.set_server_time(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TimerManager.set_server_time");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dtnow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			System.DateTime o = obj.dtnow();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int now(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong o = obj.now();
			LuaDLL.tolua_pushuint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int now_string(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			string o = obj.now_string();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int native_now(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong o = obj.native_now();
			LuaDLL.tolua_pushuint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int time2dt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			System.DateTime o = obj.time2dt(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time_show(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.DateTime o = obj.get_time_show(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.DateTime o = obj.GetTime(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int last_time_today(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			int o = obj.last_time_today();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int trigger_time(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			bool o = obj.trigger_time(arg0, arg1, arg2);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int trigger_week_time(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			bool o = obj.trigger_week_time(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int trigger_month_time(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			bool o = obj.trigger_month_time(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int run_day(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TimerManager obj = (TimerManager)ToLua.CheckObject<TimerManager>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			int o = obj.run_day(arg0);
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_start_time_(IntPtr L)
	{
		try
		{
			LuaDLL.tolua_pushuint64(L, TimerManager.start_time_);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_start_time_(IntPtr L)
	{
		try
		{
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			TimerManager.start_time_ = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

