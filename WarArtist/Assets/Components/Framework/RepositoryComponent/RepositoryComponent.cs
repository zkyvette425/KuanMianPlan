
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Component
{

    /// <summary>
    /// 仓储组件(用于存储数据)
    /// </summary>
    /// <typeparam name="TKey">存储键</typeparam>
    /// <typeparam name="TValue">存储值</typeparam>
    public class RepositoryComponent<TKey,TValue> : BaseComponent
    {
        #region private fields
        private Dictionary<TKey, TValue> _cache;                //缓存
        #endregion

        #region ctor

        /// <summary>
        /// 构造仓储组件
        /// </summary>
        public RepositoryComponent()
        {
            _cache = new Dictionary<TKey, TValue>();
        }

        #endregion

        #region public funcs

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="isCover">是否覆盖原有数据</param>
        public void Set(TKey key, TValue value, bool isCover = true)
        {
            if (_cache.ContainsKey(key))
            {
                if (isCover)
                {
                    _cache[key] = value;
                }
            }
            else
            {
                _cache.Add(key, value);
            }
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="key">需要获取的键</param>
        /// <returns></returns>
        public TValue Get(TKey key)
        {
            return _cache[key];
        }

        /// <summary>
        /// 获取所有指定条件的键
        /// </summary>
        /// <param name="match">指定条件</param>
        /// <returns>Key集合</returns>
        public List<TKey> FindKeys(Func<TKey, bool> match)
        {
            return _cache.Keys.ToList().FindAll(t => match(t));
        }

        /// <summary>
        /// 获取所有的键
        /// </summary>
        /// <returns>Key集合</returns>
        public List<TKey> FindKeys()
        {
            return _cache.Keys.ToList();
        }

        /// <summary>
        /// 获取所有指定条件的值
        /// </summary>
        /// <param name="match">指定条件</param>
        /// <returns>Value集合</returns>
        public List<TValue> FindValues(Func<TKey, bool> match)
        {
            var key = FindKeys(match);
            return key.Select(p => _cache[p]).ToList();
        }

        /// <summary>
        /// 获取所有的值
        /// </summary>
        /// <returns>Value集合</returns>
        public List<TValue> FindValues()
        {
            return _cache.Values.ToList();
        }

        public List<>
        #endregion

    }
}

