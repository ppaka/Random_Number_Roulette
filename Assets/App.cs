using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    public InputField numberField;
    private int? _input;
    private int _output;
    public Text outputText;
    public Text versionText;

    private void Start()
    {
        AddVersionNumber();
    }

    private void AddVersionNumber()
    {
        Debug.Log("Application Version : " + Application.version);
        versionText.text += $" v.{ Application.version }";
    }

    public void Enter()
    {
        try
        {
            _input = int.Parse(numberField.text);

            _output = Random.Range(1, (int)_input);
            outputText.text = _output.ToString();
        }
        catch
        {
            outputText.text = "공백 또는 너무 큰 수를 입력하지 말아주세요!";
        }
    }
}
