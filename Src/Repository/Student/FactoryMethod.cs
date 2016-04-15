using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Student
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    interface IFactory
    {
        /// <summary>
        /// 通过参数获取 IProduct 接口 的实例
        /// </summary>
        /// <param name="paramType">类型参数</param>
        /// <returns></returns>
        IProduct GetProductInstance(string paramType);
    }

    /// <summary>
    /// 具体工厂A
    /// </summary>
    class FactoryA : IFactory
    {
        public IProduct GetProductInstance(string paramType)
        {
            IProduct instance;
            switch (paramType)
            {
                case "a1": instance = new ProductA1();
                    break;
                case "a2": instance = new ProductA2();
                    break;
                default: throw new ArgumentOutOfRangeException("paramType", "FactoryB中未定义" + paramType);
            }
            return instance;
        }
    }

    /// <summary>
    /// 具体工厂B
    /// </summary>
    class FactoryB : IFactory
    {
        public IProduct GetProductInstance(string paramType)
        {
            IProduct instance;
            switch (paramType)
            {
                case "b1": instance = new ProductB1();
                    break;
                case "b2": instance = new ProductB2();
                    break;
                default: throw new ArgumentOutOfRangeException("paramType", "FactoryB中未定义" + paramType);
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
    /// 产品类A1
    /// </summary>
    class ProductA1 : IProduct
    {
        public string Name
        {
            get
            {
                return "a1";
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
    /// 产品类A2
    /// </summary>
    class ProductA2 : IProduct
    {
        public string Name
        {
            get
            {
                return "a2";
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
    /// 产品类B1
    /// </summary>
    class ProductB1 : IProduct
    {
        public string Name
        {
            get
            {
                return "b1";
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
    /// 产品类B2
    /// </summary>
    class ProductB2 : IProduct
    {
        public string Name
        {
            get
            {
                return "b2";
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