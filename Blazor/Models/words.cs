using System;

namespace Blazor.Models;

public class Word
{
    public string Korean { get; set; }
    public string Dutch { get; set; }
}

public static class WordData
{
    public static List<Word> Words = new List<Word>
    {
        new Word { Korean = "Charyeot", Dutch = "Aandacht" },
        new Word { Korean = "Kyongrye", Dutch = "Buigen" },
        new Word { Korean = "Junbi", Dutch = "Klaar staan" },
        new Word { Korean = "Sijak", Dutch = "Begin" },
        new Word { Korean = "Hosinsul", Dutch = "zelfverdediging technieken" },
        new Word { Korean = "Jireugi", Dutch = "Stoot" },
        new Word { Korean = "Makki", Dutch = "Blok" },
        new Word { Korean = "Chagi", Dutch = "Trap" },
        new Word { Korean = "Poomsae", Dutch = "4hoeks training" },
        new Word { Korean = "Dobok", Dutch = "Uniform" }
    };
}
