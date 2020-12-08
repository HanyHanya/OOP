using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LAB9
{
    public delegate void Language(string message);
    public class Programmer
    {
        
        public string name;
        public int numOfPr = 0;
        public Programmer() { }
        public Programmer(string n) { name = n; }
        public Programmer(string s, int n) { name = s; numOfPr = n; }
        public event Language Renamed;
        public event Language Added;
        public void Rename(string str)
        {
            name = str;
            Renamed?.Invoke($"Переименовано на {name}!");
        }
        public int NewPr()
        {
            numOfPr++;
            Added?.Invoke($"Добавлено свойство! Их теперь {numOfPr}");
            return numOfPr;
        }

    }

    static class StringChanger
    {
        public static void DeletePunctiantion(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' || str[i] == '.' || str[i] == ';' || str[i] == ':' || str[i] == '?' ||
                    str[i] == '!' || str[i] == '-' || str[i] == '(' || str[i] == ')' || str[i] == '\"' || str[i] == '\'')
                    str.Remove(i, 1);
            }
        }
        public static void DeleteSpaces(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    int j = i + 1;
                    while (str[j] == ' ')
                    {
                        str.Remove(j, 1);
                    }
                }
            }
        }
        public static void ToUpperCase(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Char.ToUpper(str[i]);
            }
        }

        public static void ToLowerCase(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Char.ToLower(str[i]);
            }
        }

        public static void InsertString(StringBuilder str)
        {
            str.Insert(23, "! Never gonna let you down! ");
        }
    }

}
