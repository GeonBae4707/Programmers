//���� ����
//���ڿ� my_string, overwrite_string�� ���� s�� �־����ϴ�. ���ڿ� my_string�� �ε��� s���� overwrite_string�� ���̸�ŭ�� ���ڿ� overwrite_string���� �ٲ� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//my_string�� overwrite_string�� ���ڿ� ���ĺ����� �̷���� �ֽ��ϴ�.
//1 �� overwrite_string�� ���� �� my_string�� ���� �� 1,000
//0 �� s �� my_string�� ���� - overwrite_string�� ����
//����� ��
//my_string	overwrite_string	s	result
//"He11oWor1d"	"lloWorl"	2	"HelloWorld"
//"Program29b8UYP"	"merS123"	7	"ProgrammerS123"
//����� �� ����
//����� �� #1

//���� 1���� my_string���� �ε��� 2���� overwrite_string�� ���̸�ŭ�� �ش��ϴ� �κ��� "11oWor1"�̰� �̸� "lloWorl"�� �ٲ� "HelloWorld"�� return �մϴ�.
//����� �� #2

//���� 2���� my_string���� �ε��� 7���� overwrite_string�� ���̸�ŭ�� �ش��ϴ� �κ��� "29b8UYP"�̰� �̸� "merS123"�� �ٲ� "ProgrammerS123"�� return �մϴ�.

using System;

public class Solution
{
    public string solution(string my_string, string overwrite_string, int s)
    {
        string answer = "";

        char[] myChar = my_string.ToCharArray();
        char[] overwriteChar = overwrite_string.ToCharArray();

        for (int i = 0; i < myChar.Length; i++)
        {
            if (i == s)
            {
                for (int j = 0; j < overwriteChar.Length; j++)
                {
                    myChar[i] = overwriteChar[j];
                    i++;
                }
            }
        }

        answer = new string(myChar);
        return answer;
    }
}