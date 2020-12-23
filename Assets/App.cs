using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Squirrel;

public class App : MonoBehaviour
{
    public InputField numberField;
    private int? input = null;
    private int output;
    public Text output_text;
    public Text VersionText;

    private void Start()
    {
        AddVersionNumber();
    }

    private void AddVersionNumber()
    {
        Debug.Log("Application Version : " + Application.version);
        VersionText.text += $" v.{ Application.version }";
    }

    public void Enter()
    {
        try
        {
            input = int.Parse(numberField.text);

            output = (int)UnityEngine.Random.Range(1, (int)input);
            output_text.text = output.ToString();
        }
        catch
        {
            output_text.text = "공백 또는 너무 큰 수를 입력하지 말아주세요!";
        }
    }
}
