﻿// FUND - Climate Framework for Uncertainty, Negotiation and Distribution
// Copyright (C) 2012 David Anthoff and Richard S.J. Tol
// http://www.fund-model.org
// Licensed under the MIT license
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esmf
{
    public static class Funcifier
    {
        public static Func<T, TResult> Funcify<T, TResult>(Func<T, TResult> f)
        { return f; }
    }
}
