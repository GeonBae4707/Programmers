//���� ���ĺ����� �̷���� ���ڿ� str�� �־����ϴ�. �� ���ĺ��� �빮�ڴ� �ҹ��ڷ� �ҹ��ڴ� �빮�ڷ� ��ȯ�ؼ� ����ϴ� �ڵ带 �ۼ��� ������.

//���ѻ���
//1 �� str�� ���� �� 20
//str�� ���ĺ����� �̷���� ���ڿ��Դϴ�.
//����� ��
//�Է� #1

//aBcDeFg
//��� #1

//AbCdEfG
//��2023�� 05�� 03�� ���ѻ����� �����Ǿ����ϴ�.

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
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }

        string reuslt = new string(charArray);
        Console.WriteLine(reuslt);
    }
}