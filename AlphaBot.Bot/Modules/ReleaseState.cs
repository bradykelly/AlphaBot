using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaBot.Core.Modules
{
    public enum ReleaseState
    {
        /// <summary>
        ///     Developer use only. Not in production build yet.
        /// </summary>
        Canary,

        /// <summary>
        ///     In production build, but not quite ready yet. Modules in this state should have a whitelist.
        /// </summary>
        Beta,

        /// <summary>
        ///     In production, ready for widespread use.
        /// </summary>
        Stable
    }
}
