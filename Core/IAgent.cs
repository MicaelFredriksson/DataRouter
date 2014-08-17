﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xintric.DataRouter.Core
{
    public interface IAgent
    {
        string Id { get; }
        string Name { get; }

        byte[] ToArray();

    }
}