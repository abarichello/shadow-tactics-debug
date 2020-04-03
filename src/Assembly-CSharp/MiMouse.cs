using System;
using System.Collections.Generic;
using UnityEngine;

public static partial class MiMouse
{
    static void setVisInternal(bool _bVis)
    {
        if (MiFreeCam.bOn)
        {
            Cursor.visible = false;
            return;
        }
        Cursor.visible = _bVis;
        MiMouse.s_bVisible = _bVis;
    }
}
