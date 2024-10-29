//�� ���� q, r�� ���ڿ� code�� �־��� ��, code�� �� �ε����� q�� �������� �� �������� r�� ��ġ�� ���ڸ� �տ������� ������� �̾� ���� ���ڿ��� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//0 �� r < q �� 20
//r < code�� ���� �� 1,000
//code�� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//����� ��
//q	r	code	result
//3	1	"qjnwezgrpirldywt"	"jerry"
//1	0	"programmers"	"programmers"
//����� �� ����
//����� �� #1

//���� 1���� q�� r�� ���� 3, 1�̰� �ε����� �� ���� q�� ���� �������� �� ���̵��� ǥ�� ����� ������ �����ϴ�.

//code	q	j	n	w	e	z	g	r	p	i	r	l	d	y	w	t
//index	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15
//q�� ���� ������	0	1	2	0	1	2	0	1	2	0	1	2	0	1	2	0
//q�� ���� �������� 1�� �ε����� ���ڵ��� �տ������� ������� �̾� ���̸� "jerry"�� �ǹǷ� �̸� return �մϴ�.

//����� �� #2

//���� 2���� q�� r�� ���� 1, 0�̰� �ε����� �� ���� q�� ���� �������� �� ���̵��� ǥ�� ����� ������ �����ϴ�.

//code	p	r	o	g	r	a	m	m	e	r	s
//index	0	1	2	3	4	5	6	7	8	9	10
//q�� ���� ������	0	0	0	0	0	0	0	0	0	0	0
//q�� ���� �������� 1�� �ε����� ���ڵ��� �տ������� ������� �̾� ���̸� "programmers"�� �ǹǷ� �̸� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(int q, int r, string code)
    {
        string answer = "";
        List<string> list = new List<string>();

        for (int i = 0; i < code.Length; i = i + q)
        {
            list.Add(code.Substring(i, q));
        }

        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i][r - 1];
        }

        return answer;
    }
}