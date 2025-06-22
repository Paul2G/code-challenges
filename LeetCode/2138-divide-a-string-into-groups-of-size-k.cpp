/* https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/description/ */

class Solution {
public:
    vector<string> divideString(string s, int k, char fill) {
        vector<string> result;
        
        for(int i = 0; i < s.length(); i+=k){
            result.push_back(s.substr(i, k));
        }

        if(result.back().length() != k){
            result.back() += string(k - result.back().length(), fill);
        }

        return result;
    }
};