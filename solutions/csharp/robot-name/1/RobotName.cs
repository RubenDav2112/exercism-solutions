using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private static readonly HashSet<string> _allNames = new HashSet<string>();
    private static readonly Random _rand = new Random();
    private string _name;

    public string Name
    {
        get
        {
            if (_name == null)
            {
                GenerateUniqueName();
            }
            return _name;
        }
    }

    private void GenerateUniqueName()
    {
        StringBuilder sb = new StringBuilder();
        do
        {
            sb.Clear();
            sb.Append((char)_rand.Next(65, 91)); // Letra 1
            sb.Append((char)_rand.Next(65, 91)); // Letra 2
            sb.Append(_rand.Next(100, 1000).ToString("D3")); // Asegura 3 dígitos
            
            _name = sb.ToString();
            
            // Si Add devuelve true, el nombre es único y salimos del bucle
        } while (!_allNames.Add(_name));
    }

    public void Reset()
    {
        _name = null;
    }
}