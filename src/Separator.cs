﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Interop;

namespace CoreUI
{
    public class Separator : Control
    {
        public Separator(Orientation orientation = Orientation.Horizontal)
        {
            switch (orientation)
            {
                case Orientation.Horizontal:
                    handle = NativeMethods.NewHorizontalSeparator();
                    break;
                case Orientation.Vertical:
                    handle = NativeMethods.NewVerticalSeparator();
                    break;
            }
        }
    }
}
