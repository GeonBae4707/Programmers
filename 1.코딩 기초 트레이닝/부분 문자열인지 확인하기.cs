//���� ����
//�κ� ���ڿ��̶� ���ڿ����� ���ӵ� �Ϻκп� �ش��ϴ� ���ڿ��� �ǹ��մϴ�. ���� ���, ���ڿ� "ana", "ban", "anana", "banana", "n"�� ��� ���ڿ� "banana"�� �κ� ���ڿ�������, "aaa", "bnana", "wxyz"�� ��� "banana"�� �κ� ���ڿ��� �ƴմϴ�.

//���ڿ� my_string�� target�� �Ű������� �־��� ��, target�� ���ڿ� my_string�� �κ� ���ڿ��̶�� 1��, �ƴ϶�� 0�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� my_string�� ���� �� 100
//my_string�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//1 �� target�� ���� �� 100
//target�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//my_string	target	result
//"banana"	"ana"	1
//"banana"	"wxyz"	0
//����� �� ����
//����� �� #1

//���� ����� �����ϴ�.
//����� �� #2

//���� ����� �����ϴ�.

using System;

public class Solution
{
    public int solution(string my_string, string target)
    {
        if (my_string.Contains(target))
        {
            return 1;
        }
        return 0;
    }
}