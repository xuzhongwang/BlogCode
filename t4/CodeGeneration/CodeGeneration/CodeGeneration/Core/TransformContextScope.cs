﻿using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artech.CodeGeneration
{
public class TransformContextScope: IDisposable
{
    public TransformContextScope(TextTransformation transformation, ITextTemplatingEngineHost host)
    {
        TransformContext.Current = new TransformContext(transformation, host);
    }

    public void Dispose()
    {
        TransformContext.Current = null;
    }
}
}
