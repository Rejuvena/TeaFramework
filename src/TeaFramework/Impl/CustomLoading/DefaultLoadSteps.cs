﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaFramework.API.CustomLoading;
using Terraria.ModLoader;

namespace TeaFramework.Impl.CustomLoading
{
    /// <summary>
    /// Load steps that every <see cref="TeaMod"/> uses by default.
    /// </summary>
    public static class DefaultLoadSteps
    {
        public static ILoadStep LoadMonoModHooks() => new LoadStep("LoadMonoModHooks", 4f, teaMod => MonoModHooks.RequestNativeAccess());
    }
}
