namespace Challenges
{
    /*
     * Challenge name: isomorphic-strings
        Description: 
        Given two strings s and t, determine if they are isomorphic. Two strings are isomor- phic 
        if the characters in s can be replaced to get t.						
        For example,"egg" and "add" are isomorphic, "foo" and "bar" are not. 		

        Example 1:
        Input: s= “egg”   t= “add”
        Output:  true
        Explanation= e->a   g->d  g->d

        Example 2:
        Input: s= “foo”   t= “bar”
        Output:  false
        Explanation= f->b  o->a  o≠a


        Example 1:
        Input: s= “cola”   t= “hola
        Output:  true
        Explanation= c->h  o->o  l->l  a->a

     */
    public static class IsomorphicStrings
    {
        public static bool AreIsomorphic(string string1, string string2)
        {

            if (string.IsNullOrWhiteSpace(string1) || string.IsNullOrWhiteSpace(string2))
                return false;

            var chars = new List<string>();
            var isRepeat = false;

            for (int i = 0; i < string1.Length; i++)
            {
                var isLast = string1.Length - 1 == i;

                if (!isLast && string1[i] == string1[isLast ? i : i + 1])
                {
                    chars.Add(string1[1].ToString());
                    isRepeat = true;
                    continue;
                }

                else if (isRepeat && string2[i] != string2[i - 1])
                    return false;

                else
                    chars.Add(string1[1].ToString());
            }
            return true;
        }
    }
}
