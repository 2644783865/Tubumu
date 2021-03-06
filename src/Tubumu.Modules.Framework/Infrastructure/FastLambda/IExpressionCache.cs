﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Tubumu.Modules.Framework.Infrastructure.FastLambda
{
    /// <summary>
    /// IExpressionCache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IExpressionCache<T> where T : class
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="key"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        T Get(Expression key, Func<Expression, T> creator);
    }
}
