using System;
using System.Linq;
using System.Text;

public class Anagram
{
    private (char letter, int count)[] wordCharArr;
    private string word;
    public Anagram(string baseWord)
    {
        var charArr = baseWord.ToLower().ToCharArray();
        wordCharArr = charArr.Select(x => (x, countLetters(charArr, x))).ToArray();
        word = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches.Where(isAnagram).ToArray();
    }
    private bool isAnagram(string potentialAnagram)
    {
        if (potentialAnagram.ToLower().Equals(word) || potentialAnagram.Length!=word.Length)
            return false;
        var charArr = potentialAnagram.ToLower().ToCharArray();
        (char letter, int count)[] potCharArr = charArr.Select(x => (x, countLetters(charArr, x))).ToArray(); ;

        return !potCharArr.Except(wordCharArr).Any()
            && !wordCharArr.Except(potCharArr).Any();
    }

    private int countLetters(char[] w, char c)
    {
        return w.Count(x=>x.Equals(c));
    }
}