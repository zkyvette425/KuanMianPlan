
using System;

namespace App.Component
{
    /// <summary>
    /// 组件基类
    /// </summary>
    public class BaseComponent
    {
        #region private fields

        private string _tag;              //组件标识
        private string _id;               //组件ID

        #endregion

        #region ctor

        /// <summary>
        /// 构造组件基类
        /// </summary>
        public BaseComponent()
        {
            _id = Guid.NewGuid().ToString();
        }

        #endregion

        #region public properties

        /// <summary>
        /// 获取组件ID
        /// </summary>
        public string Id => _id;

        #endregion

        #region Public funcs

        /// <summary>
        /// 设置组件标识
        /// </summary>
        /// <param name="tag"></param>
        public void SetTag(string tag)
        {
            _tag = tag;
        }

        #endregion
    }
}
