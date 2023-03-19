using System;

/*створити два інтерфейси Iplayable and IRecodable. В кожному інтерфейсі створити потри методи void Play()/ void Pause()/void Stop() and /void Record ()/void Pause()/void Stop(). 
Створити похідний клас Player від базових інтерфейсів. Написати програму яка виконує програвання та запис*/


interface IPlayable

{
    void Play();
    void Pause();
    void Stop();
}

interface IRecodable

{
    void Record();
    void Pause();
    void Stop();
}

public class Player : IPlayable, IRecodable
{
    public void Play()
    {
        Console.WriteLine("Play melody");
    }

    public void Pause()
    {
        Console.WriteLine("Pause melody");
    }

    public void Stop()
    {
        Console.WriteLine("Stop melody");
    }
    public void Record()
    {
        Console.WriteLine("Record melody");
    }
}

public class Program
{
    public static void Main()

    {
        Player player = new Player();

        player.Play();

        (player as IPlayable).Stop();


        player.Record();

        (player as IRecodable).Stop();


    }
}
