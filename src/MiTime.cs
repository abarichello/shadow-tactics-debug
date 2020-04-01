using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiTime : MiSingletonSaveLazyMortal<MiTime>
{
    // ...

    void changeTimeBase()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.bPaused = !MiTime.s_bPaused;
        }
        if (MiTime.s_bFrozen || MiTime.s_bPaused || MiDisplayDiagnostics.bOn)
        {
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.m_fTimeBase = 1f;
            this.setTime(this.m_fTimeBase);
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.m_fTimeBase = 0.5f;
            this.setTime(this.m_fTimeBase);
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.m_fTimeBase = 0.1f;
            this.setTime(this.m_fTimeBase);
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.m_fTimeBase = 1.5f;
            this.setTime(this.m_fTimeBase);
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.m_fTimeBase = 2f;
            this.setTime(this.m_fTimeBase);
            return;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.m_fTimeBase = 4f;
            this.setTime(this.m_fTimeBase);
        }
    }

    // lol
    void dropFrameRate()
    {
        for (int i = 0; i < this.m_iFrameDrop; i++)
        {
            float num = 0f;
            num += Mathf.Sqrt(42f);
            num += Mathf.Pow(10f, 23f);
        }
    }

    // ...
}