//���� ����
//�� ���� ���ڿ� str1, str2�� �������� ���еǾ� �Է����� �־����ϴ�.
//����� ���� ���� str1�� str2�� �̾ ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//1 �� str1, str2�� ���� �� 10
//����� ��
//�Է� #1

//apple pen
//��� #1

//applepen
//�Է� #2

//Hello World!
//��� #2

//HelloWorld!

using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];

        Console.WriteLine($"{s1}{s2}");
    }
}