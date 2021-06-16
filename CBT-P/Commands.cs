﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CBT_P
{
    /// <summary>
    /// The available commands for CBT-P.
    /// </summary>
    public enum Commands
    {
        #region Movement Start

        /// <summary>
        /// Begins to move the camera up.
        /// </summary>
        Up,

        /// <summary>
        /// Begins to move the camera down.
        /// </summary>
        Down,

        /// <summary>
        /// Begins to move the camera to the left.
        /// </summary>
        Left,

        /// <summary>
        /// Begins to move the camera to the right.
        /// </summary>
        Right,

        #endregion Movement Start


        #region Movement End

        /// <summary>
        /// Stops the camera from moving up.
        /// </summary>
        StopUp,

        /// <summary>
        /// Stops the camera from moving down.
        /// </summary>
        StopDown,

        /// <summary>
        /// Stops the camera from moving left.
        /// </summary>
        StopLeft,

        /// <summary>
        /// Stops the camera from moving right.
        /// </summary>
        StopRight

        #endregion Movement End
    }
}
