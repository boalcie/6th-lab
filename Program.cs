void second() // 2nd variant
{
    List<int> randomNumbers = new List<int>();
    
    for (int i = 0; i < 100; i++)
    {
        Random rnd = new Random();
        randomNumbers.Add(rnd.Next(-100, 100));
    }
    for (int i = 0; i < 5; i++)
    {
        randomNumbers.Sort();
        Console.WriteLine(randomNumbers[i]);
    } 
}

void third() // 2nd variant
{
    string[] words = { "Bold", "Apple", "Friend", "Interesting", "Cute", "Shy", "Funny", "Gorgeous", "Word", "A_bit_longer_word" };
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length > 5)
        {
            Console.WriteLine(words[i]);
        }
    }
}

third();