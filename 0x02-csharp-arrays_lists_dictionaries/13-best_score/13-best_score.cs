using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0 || myList == null)
            return "None";
        string best_score_key = "Adam";
        int best_score_value = 0;
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (best_score_value <= pair.Value)
            {
                best_score_key = pair.Key;
                best_score_value = pair.Value;
            }
        }
        return best_score_key;
    }
}
