﻿using ShapeLibrary;
using System;
using System.Collections.Generic;

namespace ControllerLibrary
{
    [Serializable]
    public class Group
    {
        List<Shape> mGroup;

        internal bool Contains(Shape shape)
        {
            throw new NotImplementedException();
        }
    }
}