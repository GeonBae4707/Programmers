//���� ����
//�ڿ��� n�� �Է����� �־����� �� ���� n�� ¦���̸� "n is even"��, Ȧ���̸� "n is odd"�� ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//1 �� n �� 1,000
//����� ��
//�Է� #1

//100
//��� #1

//100 is even
//�Է� #2

//1
//��� #2

//1 is odd
//�� 2023�� 05�� 15�� ������ �����Ǿ����ϴ�.

using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);

        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
        }
        else
        {
            Console.WriteLine($"{a} is odd");
        }
    }
}