//���� ����
//���̰� ���� ���ڿ� �迭 my_strings�� ������ ���� �迭 parts�� �Ű������� �־����ϴ�. parts[i]�� [s, e] ���·�, my_string[i]�� �ε��� s���� �ε��� e������ �κ� ���ڿ��� �ǹ��մϴ�.
//�� my_strings�� ������ parts�� �ش��ϴ� �κ� ���ڿ��� ������� �̾� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� my_strings�� ���� = parts�� ���� �� 100
//1 �� my_strings�� ������ ���� �� 100
//parts[i]�� [s, e]�� �� ��, ������ �����մϴ�.
//0 �� s �� e < my_strings[i]�� ����
//����� ��
//my_strings	parts	result
//["progressive", "hamburger", "hammer", "ahocorasick"]	[[0, 4], [1, 2], [3, 5], [7, 7]]	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� �Է��� ���� ���� ǥ�� ��Ÿ���� ������ �����ϴ�.
//|i|my_strings[i]|parts[i]|�κ� ���ڿ�|

//|-|-------------|--------|--------|

//|0|"progressive"|[0, 4]|"progr"|

//|1|"hamburger"|[1, 2]|"am"|

//|2|"hammer"|[3, 5]|"mer"|

//|3|"ahocorasick"|[7, 7]|"s"|

//�� �κ� ���ڿ��� ������� �̾� ���� ���ڿ��� "programmers"�Դϴ�. ���� "programmers"�� return �մϴ�.���� ����
//���̰� ���� ���ڿ� �迭 my_strings�� ������ ���� �迭 parts�� �Ű������� �־����ϴ�. parts[i]�� [s, e] ���·�, my_string[i]�� �ε��� s���� �ε��� e������ �κ� ���ڿ��� �ǹ��մϴ�.
//�� my_strings�� ������ parts�� �ش��ϴ� �κ� ���ڿ��� ������� �̾� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� my_strings�� ���� = parts�� ���� �� 100
//1 �� my_strings�� ������ ���� �� 100
//parts[i]�� [s, e]�� �� ��, ������ �����մϴ�.
//0 �� s �� e < my_strings[i]�� ����
//����� ��
//my_strings	parts	result
//["progressive", "hamburger", "hammer", "ahocorasick"]	[[0, 4], [1, 2], [3, 5], [7, 7]]	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� �Է��� ���� ���� ǥ�� ��Ÿ���� ������ �����ϴ�.
//|i|my_strings[i]|parts[i]|�κ� ���ڿ�|

//|-|-------------|--------|--------|

//|0|"progressive"|[0, 4]|"progr"|

//|1|"hamburger"|[1, 2]|"am"|

//|2|"hammer"|[3, 5]|"mer"|

//|3|"ahocorasick"|[7, 7]|"s"|

//�� �κ� ���ڿ��� ������� �̾� ���� ���ڿ��� "programmers"�Դϴ�. ���� "programmers"�� return �մϴ�.

using System;

public class Solution
{
    public string solution(string[] my_strings, int[,] parts)
    {
        string answer = "";
        for (int i = 0; i < my_strings.GetLength(0); i++)
        {
            for (int j = parts[i, 0]; j <= parts[i, 1]; j++)
            {
                answer += my_strings[i][j];
            }
        }
        return answer;
    }
}