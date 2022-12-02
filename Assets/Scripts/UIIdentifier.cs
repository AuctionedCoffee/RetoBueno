using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIdentifier : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    //public TMPro.TMP_Text text;

    public void SetText(string text)
    {
        this.text.text = text;
    }

    private void Update()
    {
        transform.LookAt(Camera.main.transform, Vector3.up);
        transform.Rotate(0, 180, 0);
    }
}
