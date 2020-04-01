using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiDisplayDiagnostics : MiSingletonMonoMortal<MiDisplayDiagnostics>
{
    // ...

    void Update()
    {
        // ...
        this.calcFps();
        this.modUpdate();
    }

    void modUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Alpha0))
        {
            MiAudioMixer.s_bMutePlayerVoice = true;
        }
    }

    // ...
}