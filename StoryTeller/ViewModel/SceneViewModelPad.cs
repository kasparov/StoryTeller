﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryTeller.ViewModel
{
    public class SceneViewModelPad : SceneViewModel
    {
        public SceneViewModelPad()
            : base(new DummyScene())
        {
        }
    }
}
