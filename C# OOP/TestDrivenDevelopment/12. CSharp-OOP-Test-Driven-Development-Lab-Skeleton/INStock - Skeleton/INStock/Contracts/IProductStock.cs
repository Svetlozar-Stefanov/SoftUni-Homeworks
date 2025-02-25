﻿namespace INStock.Contracts
{
    using System.Collections.Generic;

    public interface IProductStock : IEnumerable<IProduct>
    {
        int Count { get; }

        IProduct this[int index] { get; }

        bool Contains(IProduct product);

        void Add(IProduct product);

        bool Remove(IProduct product);

        IProduct Find(int index);

        IProduct FindByLabel(string label);

        IProduct FindMostExpensiveProduct();

        IEnumerable<IProduct> FindAllInRange(decimal lo, decimal hi);

        IEnumerable<IProduct> FindAllByPrice(decimal price);

        IEnumerable<IProduct> FindAllByQuantity(int quantity);
    }
}
