// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int n = 1;

void Words(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
    Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        Words(alphabet, word, length + 1);
    }
}
Words("аисв", new char[5]);