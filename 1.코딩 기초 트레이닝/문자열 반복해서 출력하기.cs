//���� ����
//���ڿ� str�� ���� n�� �־����ϴ�.
//str�� n�� �ݺ��� ���ڿ��� ����� ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//1 �� str�� ���� �� 10
//1 �� n �� 5
//����� ��
//�Է� #1

//string 5
//��� #1

//stringstringstringstringstring

using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        for (int i = 0; i < a; i++)
        {
            Console.Write(s1);
        }
    }
}