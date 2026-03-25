public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1 == s2)
            return true;
        int swaps = 0;
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        for(int i = 0 ; i < s1.Length ; i++)
        {
            freq1[s1[i] - 'a']++;
            freq2[s2[i] - 'a']++;
            if(s1[i] != s2[i])
                swaps++;
            if(swaps > 2)
                return false;
        }
        for(int i = 0 ; i < 26 ; i++)
            if(freq1[i] != freq2[i])
                return false;
        return true;
    }
}