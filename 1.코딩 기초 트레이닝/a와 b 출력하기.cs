//���� ����
//���� a�� b�� �־����ϴ�. �� ���� �Է¹޾� ����� ���� ���� �������� ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//-100,000 �� a, b �� 100,000
//����� ��
//�Է� #1

//4 5
//��� #1

//a = 4
//b = 5

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

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}