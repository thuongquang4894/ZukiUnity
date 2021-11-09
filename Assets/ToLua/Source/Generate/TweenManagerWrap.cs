﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TweenManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TweenManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Add_Tween_Postion", Add_Tween_Postion);
		L.RegFunction("Add_Tween_Alpha", Add_Tween_Alpha);
		L.RegFunction("Add_Tween_Scale", Add_Tween_Scale);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add_Tween_Postion(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
				UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
				obj.Add_Tween_Postion(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 7)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
				UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
				float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
				obj.Add_Tween_Postion(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TweenManager.Add_Tween_Postion");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add_Tween_Alpha(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
				obj.Add_Tween_Alpha(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 7)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
				float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
				obj.Add_Tween_Alpha(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TweenManager.Add_Tween_Alpha");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add_Tween_Scale(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
				UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
				obj.Add_Tween_Scale(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 7)
			{
				TweenManager obj = (TweenManager)ToLua.CheckObject<TweenManager>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
				UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
				float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
				obj.Add_Tween_Scale(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TweenManager.Add_Tween_Scale");
			}
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
