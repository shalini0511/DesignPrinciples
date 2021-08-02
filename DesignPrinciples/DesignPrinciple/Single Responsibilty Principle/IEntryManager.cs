﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    //Interface
    public class IEntryManager<T>
    {
        public void AddEntry(T entry) { }
        public void RemoveEntryAt(int index) { }
    }
}
