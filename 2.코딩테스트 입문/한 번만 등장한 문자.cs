//// https://school.programmers.co.kr/learn/courses/30/lessons/120896

//문제 설명
//문자열 s가 매개변수로 주어집니다. s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을 return 하도록 solution 함수를 완성해보세요. 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.

//제한사항
//0 < s의 길이 < 1,000
//s는 소문자로만 이루어져 있습니다.
//입출력 예
//s	result
//"abcabcadc"	"d"
//"abdc"	"abcd"
//"hello"	"eho"
//입출력 예 설명
//입출력 예 #1

//"abcabcadc"에서 하나만 등장하는 문자는 "d"입니다.
//입출력 예 #2

//"abdc"에서 모든 문자가 한 번씩 등장하므로 사전 순으로 정렬한 "abcd"를 return 합니다.
//입출력 예 #3

//"hello"에서 한 번씩 등장한 문자는 "heo"이고 이를 사전 순으로 정렬한 "eho"를 return 합니다.

using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        List<char> listChar = new List<char>();
        List<int> listCount = new List<int>();
        List<char> list = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (listChar.Contains(s[i]))
            {
                listCount[listChar.IndexOf(s[i])]++;
            }
            else
            {
                listChar.Add(s[i]);
                listCount.Add(1);
            }
        }

        for (int i = 0; i < listCount.Count; i++)
        {
            if (listCount[i] == 1)
            {
                list.Add(listChar[i]);
            }
        }

        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i];
        }

        return answer;
    }
}