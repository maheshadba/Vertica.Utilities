﻿using System;

namespace Vertica.Utilities_v4.Extensions.ObjectExt
{
	public static class ObjectExtensions
	{
		public static string SafeToString<T>(this T instance, string @default = null) where T : class
		{
			return instance == null ? @default : instance.ToString();
		}

		public static T NullOrAction<T>(this T argument, Func<T> func) where T : class
		{
			T result = null;
			if (argument != null)
			{
				result = func();
			}
			return result;
		}

		public static bool IsNotDefault<T>(this T instance)
		{
			return !IsDefault(instance);
		}

		// ReSharper disable RedundantCast
		public static bool IsDefault<T>(this T instance)
		{
			bool result = true;

			if ((object)instance != null)
			{
				result = instance.Equals(default(T));
			}
			return result;
		}
	}
}
