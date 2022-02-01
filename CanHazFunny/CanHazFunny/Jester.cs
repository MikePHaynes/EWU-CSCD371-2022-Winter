namespace CanHazFunny
{
    public class Jester
    {
        public Jester()
        {

        }

        public void TellJoke()
        {
            JokeService jokeService = new();
            string joke = jokeService.GetJoke();
            while (joke.Contains("Chuck Norris")) joke = jokeService.GetJoke();
        }
    }
}
