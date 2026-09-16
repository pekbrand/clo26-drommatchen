
Spelare spelare1 = new Spelare("zlatan",10,"forward");
Spelare spelare2 = new Spelare("Messi",10,"forward");

Match Match1 = new Match("IFK","Gais", "2026-09-15");

Match1.Presentera();
Match1.AnnounceraMålskytt(spelare1);
Match1.AnnounceraMålskytt(spelare2);
Match1.AnnounceraMålskytt(spelare1);
Match1.AnnounceraMålskytt(spelare1);

Match1.MVP();