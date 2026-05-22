public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();

        // Count characters from s
        for (int i = 0; i < s.Length; i++) {
            if (dict.ContainsKey(s[i])) {
                dict[s[i]]++;
            } else {
                dict[s[i]] = 1;
            }
        }

        // Reduce counts using t
        for (int i = 0; i < t.Length; i++) {
            if (dict.ContainsKey(t[i])) {
                dict[t[i]]--;
            } else {
                return false;
            }
        }

        // Check all counts are zero
        foreach (var pair in dict) {
            if (pair.Value != 0) {
                return false;
            }
        }

        return true;
    }
}