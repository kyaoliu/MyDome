namespace Repository.Cached
{
    /// <summary>
    /// 缓存接口
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// 加入缓存项
        /// </summary>
        /// <param name="key">缓存项标识</param>
        /// <param name="value">缓存项</param>
        /// <param name="timeSpan">缓存失效时间</param>
        /// <remarks></remarks>
        void Add(string key, object value, System.TimeSpan timeSpan);
        /// <summary>
        /// 加入依赖物理文件的缓存项
        /// </summary>
        /// <param name="key">缓存项标识</param>
        /// <param name="value">缓存项</param>
        /// <param name="fullFileNameOfFileDependency">依赖的文件全路径</param>
        /// <remarks>主要应用于配置文件或配置项</remarks>
        /// <remarks></remarks>
        void Add(string key, object value, string fullFileNameOfFileDependency);
        /// <summary>
        /// 如果不存在缓存项则添加，否则更新
        /// </summary>
        /// <param name="key">缓存项标识</param>
        /// <param name="value">缓存项</param>
        /// <param name="timeSpan">缓存失效时间</param>
        /// <remarks></remarks>
        void Set(string key, object value, System.TimeSpan timeSpan);
        /// <summary>
        /// 获取缓存项
        /// </summary>
        /// <param name="cacheKey">缓存项标识</param>
        /// <returns>返回cacheKey对应的缓存项，如果不存在则返回null</returns>
        /// <remarks></remarks>
        object Get(string cacheKey);

        /// <summary>
        /// 从缓存获取
        /// </summary>
        /// <typeparam name="T">缓存项类型</typeparam>
        /// <param name="cacheKey">缓存项标识</param>
        /// <returns>返回cacheKey对应的缓存项，如果不存在则返回null</returns>
        /// <remarks></remarks>
        T Get<T>(string cacheKey);
        /// <summary>
        /// 移除缓存项
        /// </summary>
        /// <param name="cacheKey">缓存项标识</param>
        /// <remarks></remarks>
        bool Remove(string cacheKey);
        /// <summary>
        /// 清空缓存
        /// </summary>
        /// <remarks></remarks>
        void Clear();
    }
}
