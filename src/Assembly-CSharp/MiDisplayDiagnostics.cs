using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiDisplayDiagnostics : MiSingletonMonoMortal<MiDisplayDiagnostics>
{
    // ...

    void handleFreeCam()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            MiFreeCam.bToggle();
        }
    }

    void Update()
    {

        if (MiDisplayDiagnostics.s_bScreenshotMode)
        {
            this.screenshotMode();
        }
        if (MiSingletonScriptableObject<GlobalSettings>.instance.bShowDevOptions)
        {
            this.takeScreenshot();
        }
        if (MiSingletonScriptableObject<GlobalSettings>.instance.bDevOptionsExtra)
        {
            this.handleFreeCam();
            this.checkToggleActive();
        }

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

    const bool c_bShowMemory = false;
}