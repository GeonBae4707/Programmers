//���� ����
//�� ���� a, b�� �־��� �� ������ ���� ������ ������ ����ϴ� �ڵ带 �ۼ��� ������.

//a + b = c
//���ѻ���
//1 �� a, b �� 100
//����� ��
//�Է� #1

//4 5
//��� #1

//4 + 5 = 9

using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}