
Page FirstPage = new Page("Maja");

Page Second = new Page("Er");

Page Third = new Page("Mega");

Page Fourth = new Page("Emo");

FirstPage.Read();



Chapter Kapitel = new Chapter("variabler");

Kapitel.Pages.Add(FirstPage);
Kapitel.Pages.Add(Second);
Kapitel.Pages.Add(Third);
Kapitel.Pages.Add(Fourth);

Kapitel.Read();


Book mybook = new Book("Goth girls");
mybook.Chapters.Add(Kapitel);
mybook.Start();

Console.ReadLine();