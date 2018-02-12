﻿using Interpose.Core.Handlers;
using Interpose.Core.Proxies;
using System;

namespace Interpose.Core.Interceptors
{
	public sealed class DynamicInterceptor : IInstanceInterceptor
	{
		public static readonly IInstanceInterceptor Instance = new DynamicInterceptor();

		public object Intercept(object target, Type typeToIntercept, IInterceptionHandler handler)
		{
			return new DynamicProxy(this, target, handler);
		}

		public bool CanIntercept(object instance)
		{
			return instance != null;
		}
	}
}