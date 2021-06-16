using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CBT_P
{
    /// <summary>
    /// The available responses for CBT-P.
    /// </summary>
    public enum Response
    {
        /// <summary>
        /// When a movement command was received and commenced.
        /// </summary>
        Ok,

        /// <summary>
        /// When an unkown command was received.
        /// </summary>
        Bad
    }
}
