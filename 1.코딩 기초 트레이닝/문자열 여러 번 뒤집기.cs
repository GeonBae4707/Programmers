//���� ����
//���ڿ� my_string�� ������ ���� �迭 queries�� �Ű������� �־����ϴ�.
//queries�� ���Ҵ� [s, e] ���·�, my_string�� �ε��� s���� �ε��� e������ ��������� �ǹ��Դϴ�.
//my_string�� queries�� ����� ������� ó���� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//1 �� my_string�� ���� �� 1,000
//queries�� ���Ҵ� [s, e]�� ���·� 0 �� s �� e < my_string�� ���̸� �����մϴ�.
//1 �� queries�� ���� �� 1,000
//����� ��
//my_string	queries	result
//"rermgorpsam"	[[2, 3], [0, 7], [5, 9], [6, 10]]	"programmers"
//����� �� ����
//���� 1���� my_string�� "rermgorpsam"�̰� �־��� queries�� ������� ó���ϸ� ������ �����ϴ�.
//|queries|my_string|

//|---|---|

//||"rermgorpsam"|

//|[2, 3]|"remrgorpsam"|

//|[0, 7]|"progrmersam"|

//|[5, 9]|"prograsremm"|

//|[6, 10]|"programmers"|

//���� "programmers"�� return �մϴ�.���� ����
//���ڿ� my_string�� ������ ���� �迭 queries�� �Ű������� �־����ϴ�.
//queries�� ���Ҵ� [s, e] ���·�, my_string�� �ε��� s���� �ε��� e������ ��������� �ǹ��Դϴ�.
//my_string�� queries�� ����� ������� ó���� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//1 �� my_string�� ���� �� 1,000
//queries�� ���Ҵ� [s, e]�� ���·� 0 �� s �� e < my_string�� ���̸� �����մϴ�.
//1 �� queries�� ���� �� 1,000
//����� ��
//my_string	queries	result
//"rermgorpsam"	[[2, 3], [0, 7], [5, 9], [6, 10]]	"programmers"
//����� �� ����
//���� 1���� my_string�� "rermgorpsam"�̰� �־��� queries�� ������� ó���ϸ� ������ �����ϴ�.
//|queries|my_string|

//|---|---|

//||"rermgorpsam"|

//|[2, 3]|"remrgorpsam"|

//|[0, 7]|"progrmersam"|

//|[5, 9]|"prograsremm"|

//|[6, 10]|"programmers"|

//���� "programmers"�� return �մϴ�.


using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        char[] charArray = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            char[] temp = new char[queries[i, 1] - queries[i, 0] + 1];
            int nCount = 0;

            for (int j = queries[i, 0]; j <= queries[i, 1]; j++)
            {
                temp[nCount] = charArray[j];
                nCount++;
            }

            for (int j = 0; j < nCount; j++)
            {
                charArray[queries[i, 0] + j] = temp[nCount - j - 1];
            }
        }

        return new string(charArray);
    }
}

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        char[] charArray = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            string temp = (new string(charArray)).Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1);

            for (int j = 0; j < temp.Length; j++)
            {
                charArray[queries[i, 0] + j] = temp[temp.Length - j - 1];
            }
        }

        return new string(charArray);
    }
}