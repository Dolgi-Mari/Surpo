using System;
Console.WriteLine("Ли Дон Ук - лучший актёр!");


class Actor
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Biography { get; set; }

    public static Actor FindActor(Actor[] actors, string name)
    {
        foreach (Actor actor in actors)
        {
            if (actor.Name.ToLower() == name.ToLower())
            {
                return actor;
            }
        }
        return null;
    }
}

partial class Program
{
    static void Main()
    {
        Actor[] actors = new Actor[3];


        actors[0] = new Actor
        {
            Name = "Ли Дон Ук",
            DateOfBirth = new DateTime(1981, 11, 6),
            Biography = "Корейский актер Ли Дон Ук не считает себя счастливчиком, успешной карьере он обязан своей исключительной работоспособности. К неудачам артист относится спокойно, поскольку убежден, что они подталкивают к дальнейшему профессиональному росту. Актер любит играть разноплановые роли и верит, что его лучшая работа еще впереди."
        };

        actors[1] = new Actor
        {
            Name = "Гон Ю",
            DateOfBirth = new DateTime(1979, 7, 10),
            Biography = "Корейский актер Гон Ю начал карьеру с роли ведущего различных программ на кабельном телевидении и со съемок в эпизодах сериалов и фильмов. Дверь в мир шоу-бизнеса распахнулась после того, как он появился в нескольких кинопроектах и записал пару песен. Артист прекрасно вживается в любой образ. Сейчас в копилке его кинематографических перевоплощений есть и полицейский под прикрытием, и очаровательный школьник, и даже 30-летний бездельник-миллионер, коллекционирующий мягкие игрушки."
        };

        actors[2] = new Actor
        {
            Name = "Ким Сан Бом",
            DateOfBirth = new DateTime(1989, 7, 7),
            Biography = "Поклонницы Кима Бома называют своего фаворита самым красивым корейским актером. Его любят за талант и фирменную улыбку. Местная пресса восхищается трудолюбием Кима, называя его кинотрудоголиком. Корейские дорамы принесли Бому мировую известность и звездный статус."
        };


        string actorName = "Ли Дон Ук";
        Actor foundActor = Actor.FindActor(actors, actorName);
        if (foundActor != null)
        {
            Console.WriteLine("Name: " + foundActor.Name);
            Console.WriteLine("Date of Birth: " + foundActor.DateOfBirth.ToString("MM/dd/yyyy"));
            Console.WriteLine("Biography: " + foundActor.Biography);
        }
        else
        {
            Console.WriteLine("Actor not found.");
        }
    }
}
