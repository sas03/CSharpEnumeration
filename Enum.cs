﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum Color
    {
        [Description("Rouge")]
        ROUGE,
        [Description("Bleu")]
        BLEU,
        [Description("Vert")]
        VERT,
        [Description("Jaune")]
        JAUNE
    }
}
