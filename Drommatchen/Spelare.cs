
public class Spelare
    {
        public string __namn{get;private set;}
        public int __nummer{get;private set;}
        public string __possition{get;private set;} 


    public Spelare(string namn, int nummer, string possition)
        {
            this.__namn = namn;
            this.__nummer = nummer;
            this.__possition=possition;
        }
    }