
public class Spelare
    {
        public string Name{get;private set;}
        public int Number{get;private set;}
        public string Position{get;private set;} 


    public Spelare(string namn, int nummer, string possition)
        {
            Name = namn;
            Number = nummer;
            Position=possition;
        }
    }

