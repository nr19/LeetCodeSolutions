public class Solution {
    public bool CheckOnesSegment(string s) {
        if(s.Length == 1 && s[0] == '1')
            return true;
        int oneSegCount = 0;
        var strArray = s.Split('0');
        foreach(var str in strArray)
        {
            if(str.Length >= 1)
                oneSegCount++;
        }
        return (oneSegCount == 1) ? true : false;
    }
}