//// https://school.programmers.co.kr/learn/courses/30/lessons/84512

//���� ����
//������ ���ĺ� ���� 'A', 'E', 'I', 'O', 'U'���� ����Ͽ� ���� �� �ִ�, ���� 5 ������ ��� �ܾ ���ϵǾ� �ֽ��ϴ�. �������� ù ��° �ܾ�� "A"�̰�, �״����� "AA"�̸�, ������ �ܾ�� "UUUUU"�Դϴ�.

//�ܾ� �ϳ� word�� �Ű������� �־��� ��, �� �ܾ �������� �� ��° �ܾ����� return �ϵ��� solution �Լ��� �ϼ����ּ���.

//���ѻ���
//word�� ���̴� 1 �̻� 5 �����Դϴ�.
//word�� ���ĺ� �빮�� 'A', 'E', 'I', 'O', 'U'�θ� �̷���� �ֽ��ϴ�.
//����� ��
//word	result
//"AAAAE"	6
//"AAAE"	10
//"I"	1563
//"EIO"	1189
//����� �� ����
//����� �� #1

//�������� ù ��° �ܾ�� "A"�̰�, �״����� "AA", "AAA", "AAAA", "AAAAA", "AAAAE", ... �� �����ϴ�. "AAAAE"�� �������� 6��° �ܾ��Դϴ�.

//����� �� #2

//"AAAE"�� "A", "AA", "AAA", "AAAA", "AAAAA", "AAAAE", "AAAAI", "AAAAO", "AAAAU"�� ������ 10��° �ܾ��Դϴ�.

//����� �� #3

//"I"�� 1563��° �ܾ��Դϴ�.

//����� �� #4

//"EIO"�� 1189��° �ܾ��Դϴ�.

using System;

public class Solution
{
    int maxlength = 5;
    bool bFind = false;
    public int solution(string word)
    {
        int answer = DFS(word, "", 0);

        return answer;
    }

    private int DFS(string word, string str, int count)
    {
        if (bFind) // ã������ ����
        {
            return count;
        }        
        if (word == str) // �ܾ�� ��ġ
        {
            bFind = true;
            return count;
        }
        count++;
        if (str.Length == maxlength) // �ִ���� ����
        {
            return count;
        }

        count = DFS(word, str + "A", count);
        count = DFS(word, str + "E", count);
        count = DFS(word, str + "I", count);
        count = DFS(word, str + "O", count);
        count = DFS(word, str + "U", count);
        return count;
    }
}