﻿//------------------------------------------------------------
// Game Framework v2.x
// Copyright © 2014-2016 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Transform 变量类。
    /// </summary>
    public class VarTransform : Variable<Transform>
    {
        /// <summary>
        /// 初始化 Transform 变量类的新实例。
        /// </summary>
        public VarTransform()
        {

        }

        /// <summary>
        /// 初始化 Transform 变量类的新实例。
        /// </summary>
        /// <param name="value">值。</param>
        public VarTransform(Transform value)
            : base(value)
        {

        }

        /// <summary>
        /// 从 Transform 到 Transform 变量类的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        public static implicit operator VarTransform(Transform value)
        {
            return new VarTransform(value);
        }

        /// <summary>
        /// 从 Transform 变量类到 Transform 的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        public static implicit operator Transform(VarTransform value)
        {
            return value.Value;
        }
    }
}