//// https://school.programmers.co.kr/learn/courses/30/lessons/120890

//문제 설명
//정수 배열 array와 정수 n이 매개변수로 주어질 때, array에 들어있는 정수 중 n과 가장 가까운 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ array의 길이 ≤ 100
//1 ≤ array의 원소 ≤ 100
//1 ≤ n ≤ 100
//가장 가까운 수가 여러 개일 경우 더 작은 수를 return 합니다.
//입출력 예
//array	n	result
//[3, 10, 28]	20	28
//[10, 11, 12]	13	12
//입출력 예 설명
//입출력 예 #1

//3, 10, 28 중 20과 가장 가까운 수는 28입니다.
//입출력 예 #2

//10, 11, 12 중 13과 가장 가까운 수는 12입니다.
//※ 공지 - 2023년 3월 29일 테스트 케이스가 추가되었습니다. 기존에 제출한 코드가 통과하지 못할 수도 있습니다.문제 설명
//정수 배열 array와 정수 n이 매개변수로 주어질 때, array에 들어있는 정수 중 n과 가장 가까운 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ array의 길이 ≤ 100
//1 ≤ array의 원소 ≤ 100
//1 ≤ n ≤ 100
//가장 가까운 수가 여러 개일 경우 더 작은 수를 return 합니다.
//입출력 예
//array	n	result
//[3, 10, 28]	20	28
//[10, 11, 12]	13	12
//입출력 예 설명
//입출력 예 #1

//3, 10, 28 중 20과 가장 가까운 수는 28입니다.
//입출력 예 #2

//10, 11, 12 중 13과 가장 가까운 수는 12입니다.
//※ 공지 - 2023년 3월 29일 테스트 케이스가 추가되었습니다. 기존에 제출한 코드가 통과하지 못할 수도 있습니다.

using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int answer = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - n) < Math.Abs(answer - n))
            {
                answer = array[i];
            }
            else if (Math.Abs(array[i] - n) == Math.Abs(answer - n))
            {
                answer = Math.Min(answer, array[i]);
            }
        }

        return answer;
    }
}