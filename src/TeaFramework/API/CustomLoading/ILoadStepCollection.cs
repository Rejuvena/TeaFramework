﻿using System.Collections.Generic;

namespace TeaFramework.API.CustomLoading
{
    /// <summary>
    ///     Represents a collection of <see cref="ILoadStep"/>s.
    /// </summary>
    public interface ILoadStepCollection : IEnumerable<ILoadStep>
    {
        void Add(ILoadStep step);
        ILoadStep Get(string name);
        bool TryGet(string name, out ILoadStep? step);

        public ILoadStep this[string name] => Get(name);
    }
}
