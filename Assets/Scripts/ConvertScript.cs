using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

public class ConvertScript : MonoBehaviour
{
    // ������� 2 - ���������� �� ������ ��������� ��� ������
    public sbyte sbyteValue;
    public byte byteValue;
    public short shortValue;
    public ushort ushortValue;
    public int intValue;
    public uint uintValue;
    public long longValue;
    public ulong ulongValue;
    public nint nintValue;
    public nuint nuintValue;
    public float floatValue;
    public double doubleValue;
    public decimal decimalValue;
    public GameObject ConvertByteToSbyteInputText;
    public GameObject ConvertByteToSbyteResultText;
    public GameObject ConvertIntToShortInputText;
    public GameObject ConvertIntToShortResultText;
    public GameObject ConvertIntToFloatInputText;
    public GameObject ConvertIntToFloatResultText;
    public GameObject ConvertDoubleToFloatInputText;
    public GameObject ConvertDoubleToFloatResultText;

    void logger<T>(T text)
    {
        Debug.Log(text);
    }

    public void ConvertByteToSbyte()
    {
        string resultText;
        string inputTextUI = ConvertByteToSbyteInputText.GetComponent<TextMeshProUGUI>().text;
        byte inputTextUIValue;
        sbyte resultValue;

        try
        {
            inputTextUIValue = Convert.ToByte(Regex.Replace(inputTextUI, "[^\\da-zA-Z�-���-ߨ,]", ""));
            resultValue = ((sbyte)inputTextUIValue);
            if (inputTextUIValue > sbyte.MaxValue)
            {
                resultText = $"�������� � ������� ������: {resultValue}";
            }
            else
            {
                resultText = $"��������� ��������� � ��������� ���������: {resultValue}";
            }
        } catch
        {
            resultText = "�� ��������� ������� ������. �������� �� ����� ����� ��� ����� �� ������� ���� byte";
        }

        ConvertByteToSbyteResultText.GetComponent<TextMeshProUGUI>().text = resultText;
    }

    public void ConvertIntToShort()
    {
        string resultText;
        string inputTextUI = ConvertIntToShortInputText.GetComponent<TextMeshProUGUI>().text;
        int inputTextUIValue;
        short resultValue;

        try
        {
            inputTextUIValue = Convert.ToInt32(Regex.Replace(inputTextUI, "[^\\da-zA-Z�-���-ߨ,]", ""));
            resultValue = ((short)inputTextUIValue);
            if (inputTextUIValue > short.MaxValue)
            {
                resultText = $"�������� � ������� ������: {resultValue}";
            }
            else
            {
                resultText = $"��������� ��������� � ��������� ���������: {resultValue}";
            }
        }
        catch
        {
            resultText = "�� ��������� ������� ������. �������� �� ����� ����� ��� ����� �� ������� ���� int";
        }

        ConvertIntToShortResultText.GetComponent<TextMeshProUGUI>().text = resultText;
    }

    public void ConvertIntToFloat()
    {
        string resultText;
        string inputTextUI = ConvertIntToFloatInputText.GetComponent<TextMeshProUGUI>().text;
        int inputTextUIValue;
        float resultValue;

        try
        {
            inputTextUIValue = Convert.ToInt32(Regex.Replace(inputTextUI, "[^\\da-zA-Z�-���-ߨ,]", ""));
            resultValue = ((float)inputTextUIValue);
            resultText = $"��������� ����� � ��������� �������: {String.Format("{0:F2}", resultValue)}";
        }
        catch
        {
            resultText = "�� ��������� ������� ������. �������� �� ����� ����� ��� ����� �� ������� ���� int";
        }

        ConvertIntToFloatResultText.GetComponent<TextMeshProUGUI>().text = resultText;
    }

    public void ConvertDoubleToFloat()
    {
        string resultText;
        string inputTextUI = ConvertDoubleToFloatInputText.GetComponent<TextMeshProUGUI>().text;
        double inputTextUIValue;
        float resultValue;

        try
        {
            inputTextUIValue = double.Parse(Regex.Replace(inputTextUI, "[^\\da-zA-Z�-���-ߨ,]", ""));
            resultValue = ((float)inputTextUIValue);
            if (inputTextUIValue > float.MaxValue)
            {
                resultText = $"�������� � ������� ������: {resultValue}";
            }
            else
            {
                resultText = $"��������� ����� � ��������� �������: {String.Format("{0:F2}", resultValue)}";
            }
        }
        catch
        {
            resultText = "�� ��������� ������� ������. �������� �� ����� ����� ��� ����� �� ������� ���� double???";
        }

        ConvertDoubleToFloatResultText.GetComponent<TextMeshProUGUI>().text = resultText;
    }
}
