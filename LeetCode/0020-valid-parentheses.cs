/* https://leetcode.com/problems/valid-parentheses/description/ */

public class Solution {
    public bool IsValid(string s) {
        Stack<char> parentheses = new Stack<char>([]);

        foreach(char c in s){
            if("{[(".Contains(c)) parentheses.Push(c);
            else if (parentheses.Count == 0) return false;
            else if(parentheses.Peek() == '{' && c == '}') parentheses.Pop();
            else if(parentheses.Peek() == '[' && c == ']') parentheses.Pop();
            else if(parentheses.Peek() == '(' && c == ')') parentheses.Pop();
            else return false;
       }

        return parentheses.Count == 0;
    }
}