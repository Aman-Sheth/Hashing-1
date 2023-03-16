public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        Dictionary<char, char> sd = new Dictionary<char, char>();
        Dictionary<char, char> pd = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++){
            char sChar = s[i];
            char pChar = t[i];
            if(!sd.ContainsKey(sChar)){
                sd.Add(sChar, pChar);
            } else {
                if(sd[sChar] != pChar) return false;
            }
            if(!pd.ContainsKey(pChar)){
                pd.Add(pChar, sChar);
            } else {
                if(pd[pChar] != sChar) return false;
            }
        }
        return true;
    }
}