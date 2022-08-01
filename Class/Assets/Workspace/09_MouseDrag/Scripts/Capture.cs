using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class Capture : MonoBehaviour
{
    public void ScreenShot()
    {
        ScreenCapture.CaptureScreenshot("Assets/Workspace/09_MouseDrag/Capture/" 
            + DateTime.Now.Second + DateTime.Now.Millisecond + ".png");
        EditorApplication.ExecuteMenuItem("Assets/Refresh");
    }
}
