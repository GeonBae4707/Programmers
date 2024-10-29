//문제 설명
//문자열 my_string과 이차원 정수 배열 queries가 매개변수로 주어집니다.
//queries의 원소는 [s, e] 형태로, my_string의 인덱스 s부터 인덱스 e까지를 뒤집으라는 의미입니다.
//my_string에 queries의 명령을 순서대로 처리한 후의 문자열을 return 하는 solution 함수를 작성해 주세요.

//제한사항
//my_string은 영소문자로만 이루어져 있습니다.
//1 ≤ my_string의 길이 ≤ 1,000
//queries의 원소는 [s, e]의 형태로 0 ≤ s ≤ e < my_string의 길이를 만족합니다.
//1 ≤ queries의 길이 ≤ 1,000
//입출력 예
//my_string	queries	result
//"rermgorpsam"	[[2, 3], [0, 7], [5, 9], [6, 10]]	"programmers"
//입출력 예 설명
//예제 1번의 my_string은 "rermgorpsam"이고 주어진 queries를 순서대로 처리하면 다음과 같습니다.
//|queries|my_string|

//|---|---|

//||"rermgorpsam"|

//|[2, 3]|"remrgorpsam"|

//|[0, 7]|"progrmersam"|

//|[5, 9]|"prograsremm"|

//|[6, 10]|"programmers"|

//따라서 "programmers"를 return 합니다.문제 설명
//문자열 my_string과 이차원 정수 배열 queries가 매개변수로 주어집니다.
//queries의 원소는 [s, e] 형태로, my_string의 인덱스 s부터 인덱스 e까지를 뒤집으라는 의미입니다.
//my_string에 queries의 명령을 순서대로 처리한 후의 문자열을 return 하는 solution 함수를 작성해 주세요.

//제한사항
//my_string은 영소문자로만 이루어져 있습니다.
//1 ≤ my_string의 길이 ≤ 1,000
//queries의 원소는 [s, e]의 형태로 0 ≤ s ≤ e < my_string의 길이를 만족합니다.
//1 ≤ queries의 길이 ≤ 1,000
//입출력 예
//my_string	queries	result
//"rermgorpsam"	[[2, 3], [0, 7], [5, 9], [6, 10]]	"programmers"
//입출력 예 설명
//예제 1번의 my_string은 "rermgorpsam"이고 주어진 queries를 순서대로 처리하면 다음과 같습니다.
//|queries|my_string|

//|---|---|

//||"rermgorpsam"|

//|[2, 3]|"remrgorpsam"|

//|[0, 7]|"progrmersam"|

//|[5, 9]|"prograsremm"|

//|[6, 10]|"programmers"|

//따라서 "programmers"를 return 합니다.


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