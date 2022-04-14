
int MostWordsFound(string[] sentences) 
{
    var maxWord = 0;

    var currentSentenceWord = 0;

    foreach(var sentence in sentences)
    {
        for (var i = 0; i < sentence.Length; i++)
        {
            if (sentence[i].Equals(' '))
            {
                currentSentenceWord += 1;
            }
        }

        if (!String.IsNullOrEmpty(sentence))
        {
            currentSentenceWord += 1;
        }

        if (currentSentenceWord > maxWord)
        {
            maxWord = currentSentenceWord;
        }

        currentSentenceWord = 0;
    }

    return maxWord;
}


int MostWordsFound2(string[] sentences) 
{
    var maxWord = 0;

    foreach (var sentence in sentences) 
    {
        var words = sentence.Split(' ');

        if (words.Length > maxWord)
        {
            maxWord = words.Length;
        }
    }

    return maxWord;
}

var sentences = new string[] {"alice and bob love leetcode", "i think so too", "this is great thanks very much"};
System.Console.WriteLine(MostWordsFound2(sentences));