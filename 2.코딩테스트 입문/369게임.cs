//// https://school.programmers.co.kr/learn/courses/30/lessons/120891

//문제 설명
//머쓱이는 친구들과 369게임을 하고 있습니다. 369게임은 1부터 숫자를 하나씩 대며 3, 6, 9가 들어가는 숫자는 숫자 대신 3, 6, 9의 개수만큼 박수를 치는 게임입니다. 머쓱이가 말해야하는 숫자 order가 매개변수로 주어질 때, 머쓱이가 쳐야할 박수 횟수를 return 하도록 solution 함수를 완성해보세요.

//제한사항
//1 ≤ order ≤ 1,000,000
//입출력 예
//order	result
//3	1
//29423	2
//입출력 예 설명
//입출력 예 #1

//3은 3이 1개 있으므로 1을 출력합니다.
//입출력 예 #2

//29423은 3이 1개, 9가 1개 있으므로 2를 출력합니다.
//※ 공지 - 2023년 03월 24일 테스트 케이스가 추가되었습니다. 기존에 제출한 코드가 통과하지 못할 수도 있습니다.

using System;

public class Solution
{
    public int solution(int order)
    {
        int answer = 0;
        string str = order.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '3' || str[i] == '6' || str[i] == '9')
            {
                answer++;
            }
        }
        return answer;
    }
}