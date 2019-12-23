using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop()
        {
            WriteLine("Defualt implementation of Stop.");
        }
    }
}