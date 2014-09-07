﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.DataModel.Model
{
    public sealed class PointerScene : Scene
    {
        public override SceneType Type
        {
            get
            {
                return SceneType.Pointer;
            }
            set
            {
            }
        } 
    }
}
