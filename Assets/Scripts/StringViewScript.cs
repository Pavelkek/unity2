using UnityEngine;
using TMPro;
using System.IO;

public class StringViewScript : MonoBehaviour
{
    // Задание 2 - переменные на каждый чисельный тип данных
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
    public GameObject resultString;

    // Задание 4
    public void StringView()
    {
        string stringViewParams;

        stringViewParams = $"{byteValue}:{(sbyte)byteValue}, {shortValue}:{(byte)shortValue}, {ushortValue}:{(short)ushortValue}, {intValue}:{(ushort)intValue}, " +
            $"{uintValue}:{(int)uintValue}, {longValue}:{(uint)longValue}, {ulongValue}:{(long)ulongValue}, {nintValue}:{(ulong)nintValue}, {nuintValue}:{(nint)nuintValue}, " +
            $"{floatValue}:{(nuint)floatValue}, {doubleValue}:{(float)doubleValue}, {decimalValue}:{(double)decimalValue}, {sbyteValue}:{(decimal)sbyteValue}";

        resultString.GetComponent<TextMeshProUGUI>().text = stringViewParams;
    }

    // Задание 5
    public void SaveToFile()
    {
        string stringViewParams = resultString.GetComponent<TextMeshProUGUI>().text;
        string filePath = "Assets/outputFile.txt";

        using (StreamWriter w = new StreamWriter(filePath, false))
        {
            w.Write(sbyteValue);
            w.Write(byteValue);
            w.Write(shortValue);
            w.Write(ushortValue);
            w.Write(intValue);
            w.Write(uintValue);
            w.Write(longValue);
            w.Write(ulongValue);
            w.Write(nintValue);
            w.Write(nuintValue);
            w.Write(floatValue);
            w.Write(doubleValue);
            w.Write(decimalValue);
            w.Write(stringViewParams);
        }
    }
}
