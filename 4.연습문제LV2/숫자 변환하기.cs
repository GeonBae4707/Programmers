//// https://school.programmers.co.kr/learn/courses/30/lessons/154538

//문제 설명
//자연수 x를 y로 변환하려고 합니다. 사용할 수 있는 연산은 다음과 같습니다.

//x에 n을 더합니다
//x에 2를 곱합니다.
//x에 3을 곱합니다.
//자연수 x, y, n이 매개변수로 주어질 때, x를 y로 변환하기 위해 필요한 최소 연산 횟수를 return하도록 solution 함수를 완성해주세요. 이때 x를 y로 만들 수 없다면 -1을 return 해주세요.

//제한사항
//1 ≤ x ≤ y ≤ 1,000,000
//1 ≤ n < y
//입출력 예
//x	y	n	result
//10	40	5	2
//10	40	30	1
//2	5	4	-1
//입출력 예 설명
//입출력 예 #1
//x에 2를 2번 곱하면 40이 되고 이때가 최소 횟수입니다.

//입출력 예 #2
//x에 n인 30을 1번 더하면 40이 되고 이때가 최소 횟수입니다.

//입출력 예 #3
//x를 y로 변환할 수 없기 때문에 -1을 return합니다.

using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int x, int y, int n)
    {
        int answer = 0;
        Queue<int> queue = new Queue<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        queue.Enqueue(x);

        while (queue.Count > 0 && queue.Peek() <= y)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int temp = queue.Dequeue();
                if (dict.ContainsKey(temp))
                {
                    continue;
                }
                else
                {
                    dict.Add(temp, 1);
                }

                if (temp == y)
                {
                    return answer;
                }

                int k = temp + n;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
                k = temp * 2;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
                k = temp * 3;
                if (k <= y)
                {
                    queue.Enqueue(k);
                }
            }
            answer++;
        }

        return -1;
    }
}