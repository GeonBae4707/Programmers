//���� ����
//���� n�� ���ڿ� control�� �־����ϴ�. control�� "w", "a", "s", "d"�� 4���� ���ڷ� �̷���� ������, control�� �տ������� ������� ���ڿ� ���� n�� ���� �ٲߴϴ�.

//"w" : n�� 1 Ŀ���ϴ�.
//"s" : n�� 1 �۾����ϴ�.
//"d" : n�� 10 Ŀ���ϴ�.
//"a" : n�� 10 �۾����ϴ�.
//�� ��Ģ�� ���� n�� �ٲ��� �� ���� �������� ������ n�� ���� return �ϴ� solution �Լ��� �ϼ��� �ּ���.

//���ѻ���
//-100,000 �� n �� 100,000
//1 �� control�� ���� �� 100,000
//control�� ���ĺ� �ҹ��� "w", "a", "s", "d"�� �̷���� ���ڿ��Դϴ�.
//����� ��
//n	control	result
//0	"wsdawsdassw"	-1
//����� �� ����
//����� �� #1

//�� n�� control�� ���� ������ ���� ������ ���ϰ� �˴ϴ�.
//0 �� 1 �� 0 �� 10 �� 0 �� 1 �� 0 �� 10 �� 0 �� -1 �� -2 �� -1
//���� -1�� return �մϴ�.

using System;

public class Solution
{
    public int solution(int n, string control)
    {
        for (int i = 0; i < control.Length; i++)
        {
            switch (control[i])
            {
                case 'w':
                    n += 1;
                    break;
                case 's':
                    n -= 1;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
            }
        }
        return n;
    }
}