//���� ����
//���ڿ� str�� �־����ϴ�.
//���ڿ��� �ð�������� 90�� ������ �Ʒ� ����� ���� ���� ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//1 �� str�� ���� �� 10

//����� ��
//�Է� #1

//abcde
//��� #1

//a
//b
//c
//d
//e

using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        char[] charArray = s.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            Console.WriteLine(charArray[i]);
        }
    }
}