using System;
using System.Collections;
using UnityEngine;

public class MiFreeCam : MonoBehaviour
{
    // ...

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Insert))
        {
            this.bShowSettings = !this.bShowSettings;
            MiDisplayDiagnostics.bOn = this.bShowSettings;
        }

        if (MiFreeCam.s_bOn)
        {
            if (this.m_bMoveCam)
            {
                // ...
            }
            else
            {
                Vector3 vector = Vector3.zero;
                if (Input.GetKey(KeyCode.Keypad8))
                {
                    vector += Vector3.forward * MiFreeCam.m_fSpeedCurrent * num;
                }
                else if (Input.GetKey(KeyCode.Keypad5))
                {
                    vector += Vector3.back * MiFreeCam.m_fSpeedCurrent * num;
                }
                if (Input.GetKey(KeyCode.Keypad4))
                {
                    vector += Vector3.left * MiFreeCam.m_fSpeedCurrent * num;
                }
                else if (Input.GetKey(KeyCode.Keypad6))
                {
                    vector += Vector3.right * MiFreeCam.m_fSpeedCurrent * num;
                }
                if (Input.GetKey(KeyCode.Keypad7))
                {
                    vector += this.m_transMove.InverseTransformDirection(Vector3.up) * MiFreeCam.m_fSpeedCurrent * num;
                }
                else if (Input.GetKey(KeyCode.Keypad9))
                {
                    vector += this.m_transMove.InverseTransformDirection(Vector3.down) * MiFreeCam.m_fSpeedCurrent * num;
                }
                this.m_v3TransLast = Vector3.Lerp(this.m_v3TransLast, vector, MiFreeCam.m_arSettings[1].fValue());
                this.m_transMove.Translate(this.m_v3TransLast, Space.Self);
            }
        }
        this.changeSettings(fDeltaTimeSettings);
        this.modUpdate();
    }

    void modUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Quote))
        {
            this.m_cam.fov = 60f;
        }
    }

    void OnGUI()
    {
        checked
        {
            if (this.bShowSettings)
            {
                GUIStyle guistyle = new GUIStyle(GUI.skin.GetStyle("TextArea"));
                guistyle.normal.textColor = ((!MiFreeCam.s_bOn) ? Color.red : Color.green);
                GUILayout.Space(40f);
                GUILayout.BeginVertical(new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "Free Cam Active ",
                    MiFreeCam.s_bOn,
                    " locked: ",
                    !this.m_bMoveCam
                }), guistyle, new GUILayoutOption[0]);
                string text = string.Empty;
                for (int i = 0; i < MiFreeCam.m_arSettings.Length; i++)
                {
                    MiFreeCam.EnumSetting enumSetting = (MiFreeCam.EnumSetting)i;
                    string text2 = enumSetting.ToString() + ": " + MiFreeCam.m_arSettings[i].strValue();
                    if (i != 0)
                    {
                        text += "\n";
                    }
                    if (i == (int)this.m_eSetting)
                    {
                        text = text + "---> " + text2;
                    }
                    else
                    {
                        text += text2;
                    }
                }
                GUILayout.TextArea("Camera Settings:", new GUILayoutOption[0]);
                GUILayout.TextArea(text, new GUILayoutOption[0]);
                GUILayout.TextArea("shadow-warrior-debug Controls:", new GUILayoutOption[0]);
                GUILayout.EndVertical();
                GUILayout.BeginHorizontal(new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "FOV: ",
                    this.m_cam.fieldOfView,
                    "\nSet FOV to 60: ",
                    "\nReset Position: ",
                    "\nNext Frame: ",
                    "\nLock Camera: ",
                    !this.m_bMoveCam,
                    "\nHide debug UI: ",
                    "\nHide game UI: ",
                    "\nControl time speed: ",
                    "\nDisable character voices: ",
                    "\nMove: ",
                    "\nFaster camera/fov change: "
                }), new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "Keypad1/3",
                    "\nShift + '",
                    "\n0",
                    "\nKeypadPlus",
                    "\nKeypad \\",
                    "\nInsert",
                    "\n,",
                    "\nShift+[1 to 5]",
                    "\nShift + 0",
                    "\nKeypad 8456",
                    "\nShift"
                }), new GUILayoutOption[0]);
                GUILayout.EndHorizontal();
                GUILayout.BeginVertical(new GUILayoutOption[0]);
                GUILayout.TextArea("Cheats: (choose target with left click)", new GUILayoutOption[0]);
                GUILayout.EndVertical();
                GUILayout.BeginHorizontal(new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "Indetectability - PageUp/PageDown",
                    "\nInvincibility - Home/End"
                }), new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "PageUp/PageDown",
                    "\nHome/End"
                }), new GUILayoutOption[0]);
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal(new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "Camera settings control",
                    "\nMove cursor up/down",
                    "\nIncrease/Decrease"
                }), new GUILayoutOption[0]);
                GUILayout.TextArea(string.Concat(new object[] {
                    "(needs Numpad0 active)",
                    "\nPageUp/PageDown",
                    "\nHome/End"
                }), new GUILayoutOption[0]);
                GUILayout.EndHorizontal();
            }
        }
    }

    // ...

    static float m_fSpeedCurrent = 3f;

    static float m_fov = 80f;

    static float m_farPlane = 2000f;

    public Camera m_cam;

    public GameObject m_goCamParent;

    bool bShowSettings = true;

    // ...

}