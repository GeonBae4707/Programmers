//영어 알파벳으로 이루어진 문자열 str이 주어집니다. 각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.

//제한사항
//1 ≤ str의 길이 ≤ 20
//str은 알파벳으로 이루어진 문자열입니다.
//입출력 예
//입력 #1

//aBcDeFg
//출력 #1

//AbCdEfG
//※2023년 05월 03일 제한사항이 수정되었습니다.

using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        char[] charArray = s.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }

        string reuslt = new string(charArray);
        Console.WriteLine(reuslt);
    }
}