public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
         // get och privat set för Hemmalag 
        get { return _hemmalag; }
        private set { _hemmalag = value; } 
       
    }

    public string Bortalag
    {
        // get och privat set för Bortalag
        get { return _bortalag; }
        private set { _bortalag = value; }
    }

    public string Datum
    {
        // get och privat set för Datum
        get { return _datum; }
        private set { _datum = value; }
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        this._hemmalag = hemmalag;
        this._bortalag = bortalag;
        this._datum= datum;
    }


    Dictionary<Spelare, int> goal_static = new Dictionary<Spelare, int>();

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        // TODO
        Console.WriteLine(
            $"Hej och Välkommnar till dagens match\n Den {_datum} Spelar {_hemmalag} mot {_bortalag}");
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO
        Console.WriteLine(
            $"Nr:{spelare.__nummer} - {spelare.__namn}({spelare.__possition}) Gör mål!");
            if (goal_static.ContainsKey(spelare))
               {
                    goal_static[spelare]++;
                    Console.WriteLine($"{spelare.__namn} gör mål nr:{goal_static[spelare]}");
                }
            else
            {
                goal_static[spelare] =  1;
            }
            
        
    }

    public void MVP()
    {
        var mvp_list = new List<(string name, int goals)>();
        int goal = 0;
        string mvp = "";
        foreach (var item in goal_static)
            {
                if (goal < item.Value)
                { 
                    goal = item.Value;
                    mvp = item.Key.__namn;
                    mvp_list.Clear();
                    mvp_list.Add((item.Key.__namn, item.Value));
                }
                else if (goal == item.Value)
                {
                    mvp_list.Add((item.Key.__namn, item.Value));
                }
            }
        if(goal == 0)
        {
            Console.WriteLine("Tyvärr slutade matchen 0-0 idag");
        }
        else if (mvp_list.Count > 1)
        {
            Console.WriteLine("Matchens MVPS:");
            for (int i = 0; i < mvp_list.Count; i++)
            {
                Console.WriteLine($"{mvp_list[i].name} med {mvp_list[i].goals} mål");
            }
        }
        else
        {
            Console.WriteLine($"Matchens mest värdefulla spelare var {mvp}");
            Console.WriteLine($"Det blev hela {goal} st för honom/henne.");
        }
        
    }
}