string text = "We’re updating the cards and ranking all the time, "
+ "so check back regularly. At first, you might need to follow some "
+ "people or star some repositories to get started";

string replace(string s, char oldf, char newbe)
{
    string result = string.Empty;
    int t = text.Length;
    for (int i = 0; i < t; i++)
    {
        if (text[i] == oldf)
            result = result + $"{newbe}";
        else
            result = result + $"{text[i]}";

    }
    return result;
}

string type = replace(text, ' ', '_');
Console.WriteLine(type);
