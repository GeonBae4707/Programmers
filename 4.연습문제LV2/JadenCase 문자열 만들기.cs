//// https://school.programmers.co.kr/learn/courses/30/lessons/12951

//���� ����
//JadenCase�� ��� �ܾ��� ù ���ڰ� �빮���̰�, �� ���� ���ĺ��� �ҹ����� ���ڿ��Դϴ�. ��, ù ���ڰ� ���ĺ��� �ƴ� ������ �̾����� ���ĺ��� �ҹ��ڷ� ���� �˴ϴ�. (ù ��° ����� �� ����)
//���ڿ� s�� �־����� ��, s�� JadenCase�� �ٲ� ���ڿ��� �����ϴ� �Լ�, solution�� �ϼ����ּ���.

//���� ����
//s�� ���� 1 �̻� 200 ������ ���ڿ��Դϴ�.
//s�� ���ĺ��� ����, ���鹮��(" ")�� �̷���� �ֽ��ϴ�.
//���ڴ� �ܾ��� ù ���ڷθ� ���ɴϴ�.
//���ڷθ� �̷���� �ܾ�� �����ϴ�.
//���鹮�ڰ� �����ؼ� ���� �� �ֽ��ϴ�.
//����� ��
//s	return
//"3people unFollowed me"	"3people Unfollowed Me"
//"for the last week"	"For The Last Week"
//�� ���� - 2022�� 1�� 14�� ���� ���ǰ� �׽�Ʈ ���̽��� �߰��Ǿ����ϴ�.

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        bool b = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                b = true;
                answer += " ";
            }
            else if (b)
            {
                answer += s[i].ToString().ToUpper();
                b = false;
            }
            else
            {
                answer += s[i].ToString().ToLower();
            }
        }

        return answer;
    }
}