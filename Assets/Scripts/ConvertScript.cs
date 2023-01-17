using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

// Задание 3
public class ConvertScript : MonoBehaviour
{
    public GameObject ConvertByteToSbyteInputText;
    public GameObject ConvertByteToSbyteResultText;
    public GameObject ConvertIntToShortInputText;
    public GameObject ConvertIntToShortResultText;
    public GameObject ConvertIntToFloatInputText;
    public GameObject ConvertIntToFloatResultText;
    public GameObject ConvertDoubleToFloatInputText;
    public GameObject ConvertDoubleToFloatResultText;

    public void ConvertByteToSbyte()
    {
        string resultText;
        string inputTextUI = ConvertByteToSbyteInputText.GetComponent<TextMeshProUGUI>().text;
        byte inputTextUIValue;
        sbyte resultValue;

        try
        {
            inputTextUIValue = Convert.ToByte(Regex.Replace(inputTextUI, "[^\\da-zA-Zа-яёА-ЯЁ,]", ""));
            resultValue = ((sbyte)inputTextUIValue);
            if (inputTextUIValue > sbyte.MaxValue)
            {
                resultText = $"Значение с потерей данных: {resultValue}";
            }
            else
            {
                resultText = $"Результат совпадает с введенным значением: {resultValue}";
            }
        } catch
        {
            resultText = "Не корректно введены данные. Возможно вы ввели буквы или вышли за границы типа byte";
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
            inputTextUIValue = Convert.ToInt32(Regex.Replace(inputTextUI, "[^\\da-zA-Zа-яёА-ЯЁ,]", ""));
            resultValue = ((short)inputTextUIValue);
            if (inputTextUIValue > short.MaxValue)
            {
                resultText = $"Значение с потерей данных: {resultValue}";
            }
            else
            {
                resultText = $"Результат совпадает с введенным значением: {resultValue}";
            }
        }
        catch
        {
            resultText = "Не корректно введены данные. Возможно вы ввели буквы или вышли за границы типа int";
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
            inputTextUIValue = Convert.ToInt32(Regex.Replace(inputTextUI, "[^\\da-zA-Zа-яёА-ЯЁ,]", ""));
            resultValue = ((float)inputTextUIValue);
            resultText = $"Результат число с плавающей запятой: {String.Format("{0:F2}", resultValue)}";
        }
        catch
        {
            resultText = "Не корректно введены данные. Возможно вы ввели буквы или вышли за границы типа int";
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
            inputTextUIValue = double.Parse(Regex.Replace(inputTextUI, "[^\\da-zA-Zа-яёА-ЯЁ,]", ""));
            resultValue = ((float)inputTextUIValue);
            if (inputTextUIValue > float.MaxValue)
            {
                resultText = $"Значение с потерей данных: {resultValue}";
            }
            else
            {
                resultText = $"Результат число с плавающей запятой: {String.Format("{0:F2}", resultValue)}";
            }
        }
        catch
        {
            resultText = "Не корректно введены данные. Возможно вы ввели буквы или вышли за границы типа double???";
        }

        ConvertDoubleToFloatResultText.GetComponent<TextMeshProUGUI>().text = resultText;
    }
}
