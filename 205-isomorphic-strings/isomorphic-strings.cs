public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> map1 = new ();
        Dictionary<char, char> map2 = new ();
        for(int i = 0 ; i < s.Length ; i++)
        {
            var ch1 = s[i];
            var ch2 = t[i];
            if(map1.ContainsKey(ch1) && map1[ch1] != ch2)
                return false;
            if(map2.ContainsKey(ch2) && map2[ch2] != ch1)
                return false;
            map1[ch1] = ch2;
            map2[ch2] = ch1;
        }
        return true;
    }
}