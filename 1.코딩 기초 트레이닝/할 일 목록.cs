//���� ����
//���� �ؾ� �� ���� ��� ���ڿ� �迭 todo_list�� ������ ���� ���� ���ƴ����� ��Ÿ���� boolean �迭 finished�� �Ű������� �־��� ��, todo_list���� ���� ��ġ�� ���� �ϵ��� ������� ���� ���ڿ� �迭�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� todo_list�� ���� 1 �� 100
//2 �� todo_list�� ������ ���� �� 20
//todo_list�� ���Ҵ� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//todo_list�� ���Ҵ� ��� ���� �ٸ��ϴ�.
//finished[i]�� true �Ǵ� false�̰� true�� todo_list[i]�� ��������, false�� ���� ��ġ�� �������� ��Ÿ���ϴ�.
//���� ��ġ�� ���� ���� ��� �ϳ� �ֽ��ϴ�.
//����� ��
//todo_list	finished	result
//["problemsolving", "practiceguitar", "swim", "studygraph"]	[true, false, true, false]	["practiceguitar", "studygraph"]
//����� �� ����
//����� �� #1

//���� 1���� todo_list �߿��� "problemsolving"�� "swim"�� ���ư�, "practiceguitar"�� "studygraph"�� ���� ��ġ�� �������Ƿ� todo_list���� ���� ������� ���� ���ڿ� �迭 ["practiceguitar", "studygraph"]�� return �մϴ�.���� ����
//���� �ؾ� �� ���� ��� ���ڿ� �迭 todo_list�� ������ ���� ���� ���ƴ����� ��Ÿ���� boolean �迭 finished�� �Ű������� �־��� ��, todo_list���� ���� ��ġ�� ���� �ϵ��� ������� ���� ���ڿ� �迭�� return �ϴ� solution �Լ��� �ۼ��� �ּ���.

//���ѻ���
//1 �� todo_list�� ���� 1 �� 100
//2 �� todo_list�� ������ ���� �� 20
//todo_list�� ���Ҵ� ���ҹ��ڷθ� �̷���� �ֽ��ϴ�.
//todo_list�� ���Ҵ� ��� ���� �ٸ��ϴ�.
//finished[i]�� true �Ǵ� false�̰� true�� todo_list[i]�� ��������, false�� ���� ��ġ�� �������� ��Ÿ���ϴ�.
//���� ��ġ�� ���� ���� ��� �ϳ� �ֽ��ϴ�.
//����� ��
//todo_list	finished	result
//["problemsolving", "practiceguitar", "swim", "studygraph"]	[true, false, true, false]	["practiceguitar", "studygraph"]
//����� �� ����
//����� �� #1

//���� 1���� todo_list �߿��� "problemsolving"�� "swim"�� ���ư�, "practiceguitar"�� "studygraph"�� ���� ��ġ�� �������Ƿ� todo_list���� ���� ������� ���� ���ڿ� �迭 ["practiceguitar", "studygraph"]�� return �մϴ�.

using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < todo_list.GetLength(0); i++)
        {
            if (finished[i] == false)
            {
                list.Add(todo_list[i]);
            }
        }

        return list.ToArray();
    }
}