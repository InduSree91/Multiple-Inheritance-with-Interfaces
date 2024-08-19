using System;

namespace MIWInterfaces
{
    public interface IEngine
    {
        void StartEngine();
        void StopEngine();
    }

    public interface ITransmission
    {
        void ChangeGare(int gear);
    }

    public interface IEntertainment
    {
        void PlayMusic(string music1);
        void ChangeMusic(string music2);
        void StopMusic();
    }

    public class Car : IEngine, ITransmission, IEntertainment
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }

        public void ChangeGare(int gear)
        {
            Console.WriteLine($"Gear is changed to {gear}");
        }

        public void PlayMusic(string music1)
        {
            Console.WriteLine($"Playing song {music1}");
        }

        public void ChangeMusic(string music2)
        {
            Console.WriteLine($"Chanding the song to {music2}");
        }

        public void StopMusic()
        {
            Console.WriteLine("Stopped playing music");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car myCar = new Car();

            myCar.StartEngine();
            myCar.PlayMusic("Seven");
            myCar.ChangeGare(2);
            myCar.ChangeMusic("3D");
            myCar.ChangeGare(4);
            myCar.ChangeMusic("Hate You");
            myCar.ChangeGare(2);
            myCar.ChangeGare(1);
            myCar.StopMusic();
            myCar.StopEngine();

        }
    }
}