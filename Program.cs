// See https://aka.ms/new-console-template for more information
int  LengthOfLongestSubString(string s)
 {
    int n=0;
    if(string.IsNullOrEmpty(s))
    {
        return 0;
    }
    HashSet<char> set = new HashSet<char>();
    int left = 0, maxLength = 0;
    for(int right=0;right<s.Length;right++)
    {
        while (set.Contains(s[right]))
        {
            set.Remove(s[left]);
            left++;
        }
        set.Add(s[right]);
        maxLength = Math.Max(maxLength,right-left+1);

    }

    return maxLength;
 }
int result = 0;
string input = "abcxabcbb";
result = LengthOfLongestSubString(input);
Console.WriteLine("String Passed to Check Length of Long String:"+input);
if (result == 0)
{
    Console.WriteLine("Test failed");
}
else
{
       Console.WriteLine("Length of longest substring is:"+result);
}

Console.ReadLine();
