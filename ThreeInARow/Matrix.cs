using System;

namespace TreeInARow;

public class Matrix
{
    private int _columns { get; set; }
    private int _rows { get; set; }
    private List<List<int>> _matrix { get; set; }

    public void Show()
    {
        for (int j = _columns - 1; j >= 0; j--)
        {
            for (int i = 0; i < _matrix[i].Count; i++)
            {
                Console.Write(_matrix[i][j]); Console.Write(" ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public void Vertical(ref int flag2)
    {
        Random rand = new Random();
        int count = 1;
        for (int j = 0; j < _columns; j++)
        {
            for (int i = 1; i < _matrix[j].Count; i++)
            {
                if (_matrix[j][i] == _matrix[j][i - 1])
                {
                    count++;
                }
                else
                {
                    if (count >= 3)
                    {
                        flag2++;
                        var newMas = new List<int>();
                        for (int k = 1; k <= count; k++)
                        {
                            _matrix[j].RemoveAt(i - k);
                            newMas.Add(rand.Next(0, 4));
                        }

                        _matrix[j].AddRange(newMas);
                    }

                    count = 1;
                }

                if (i == _matrix[j].Count - 1)
                {
                    if (count >= 3)
                    {
                        flag2++;
                        var newMas = new List<int>();

                        for (int k = 1; k <= count; k++)
                        {
                            _matrix[j].RemoveAt(i - k + 1);
                            newMas.Add(rand.Next(0, 4));
                        }

                        _matrix[j].AddRange(newMas);
                    }

                    count = 1;
                }
            }

            count = 1;
        }
    }

    public void Horisontal(ref int flag2)
    {
        int count = 1;
        Random rand = new Random();
        for (int j = 0; j < _rows; j++)
        {
            for (int i = 1; i < _matrix[j].Count; i++)
            {
                if (_matrix[i][j] == _matrix[i - 1][j])
                {
                    count++;
                }
                else
                {
                    if (count >= 3)
                    {
                        flag2++;
                        for (int k = 1; k <= count; k++)
                        {
                            _matrix[i - k].RemoveAt(j);
                            _matrix[i - k].Add(rand.Next(0, 4));
                        }

                    }

                    count = 1;
                }

                if (i == _matrix[j].Count - 1)
                {
                    if (count >= 3)
                    {
                        flag2++;
                        for (int k = 1; k <= count; k++)
                        {
                            _matrix[i - k].RemoveAt(j);
                            _matrix[i - k].Add(rand.Next(0, 4));
                        }

                    }

                    count = 1;
                }
            }

            count = 1;
        }
    }

    public void Fill()
    {
        Random rand = new Random();
        for (int j = 0; j < _columns; j++)
        {
            for (int i = 0; i < _rows; i++)
            {
                _matrix.Add(new List<int>());
                _matrix[j].Add(rand.Next(0, 4));
            }
        }
    }

    public void Create(int columns, int rows)
    {
        _columns = columns;
        _rows = rows;
        _matrix = new List<List<int>>();
    }

}
