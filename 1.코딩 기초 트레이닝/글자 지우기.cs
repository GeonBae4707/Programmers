//���� ����
//���ڿ� my_string�� ���� �迭 indices�� �־��� ��, my_string���� indices�� ���ҿ� �ش��ϴ� �ε����� ���ڸ� ����� �̾� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� indices�� ���� < my_string�� ���� �� 100
//my_string�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�
//0 �� indices�� ���� < my_string�� ����
//indices�� ���Ҵ� ��� ���� �ٸ��ϴ�.
//����� ��
//my_string	indices	result
//"apporoograpemmemprs"	[1, 16, 6, 15, 0, 10, 11, 3]	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� my_string�� �ε����� �� ���̵��� ǥ�� ����� ������ �����ϴ�.
//|index|0|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|

//|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|

//|my_string|a|p|p|o|r|o|o|g|r|a|p|e|m|m|e|m|p|r|s|

//`indices`�� �ִ� �ε����� ���ڵ��� ����� �̾���̸� "programmers"�� �ǹǷ� �̸� return �մϴ�.���� ����
//���ڿ� my_string�� ���� �迭 indices�� �־��� ��, my_string���� indices�� ���ҿ� �ش��ϴ� �ε����� ���ڸ� ����� �̾� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� indices�� ���� < my_string�� ���� �� 100
//my_string�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�
//0 �� indices�� ���� < my_string�� ����
//indices�� ���Ҵ� ��� ���� �ٸ��ϴ�.
//����� ��
//my_string	indices	result
//"apporoograpemmemprs"	[1, 16, 6, 15, 0, 10, 11, 3]	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� my_string�� �ε����� �� ���̵��� ǥ�� ����� ������ �����ϴ�.
//|index|0|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|

//|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|

//|my_string|a|p|p|o|r|o|o|g|r|a|p|e|m|m|e|m|p|r|s|

//`indices`�� �ִ� �ε����� ���ڵ��� ����� �̾���̸� "programmers"�� �ǹǷ� �̸� return �մϴ�.

using System;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        string answer = "";

        char[] charArray = my_string.ToCharArray();

        for (int i = 0; i < indices.Length; i++)
        {
            charArray[indices[i]] = ' ';
        }

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] != ' ')
            {
                answer += charArray[i];
            }
        }

        return answer;
    }
}