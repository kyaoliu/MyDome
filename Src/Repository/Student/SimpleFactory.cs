using System;

namespace Repository.Student.SimpleFactory
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    class SimpleFactory
    {
        /// <summary>
        /// 通过参数获取 IProduct 接口 的实例
        /// </summary>
        /// <param name="paramType">类型参数</param>
        /// <returns></returns>
        public static IProduct GetProductInstance(string paramType)
        {
            IProduct instance;
            switch (paramType)
            {
                case "a": instance = new ProductA();
                    break;
                case "b": instance = new ProductB();
                    break;
                default: throw new ArgumentOutOfRangeException("paramType", "ProductFactory中未定义" + paramType);
            }
            return instance;
        }
    }

    /// <summary>
    /// 抽象产品基类
    /// </summary>
    interface IProduct
    {
        string Name { get; }
        void ShowName();
    }

    /// <summary>
    /// 产品类A
    /// </summary>
    class ProductA : IProduct
    {
        public string Name
        {
            get
            {
                return "a";
            }
        }

        public void ShowName()
        {
            {
                Console.Write("My name is " + Name);
            }
        }
    }

    /// <summary>
    /// 产品类B
    /// </summary>
    class ProductB : IProduct
    {
        public string Name
        {
            get
            {
                return "b";
            }
        }

        public void ShowName()
        {
            {
                Console.Write("My name is " + Name);
            }
        }
    }
}