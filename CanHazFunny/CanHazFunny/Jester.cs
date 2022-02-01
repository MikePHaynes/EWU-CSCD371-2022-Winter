namespace CanHazFunny
{
    public class Jester
    {
        private JokeOutput _jokeOutput;
        private JokeService _jokeService;

        public Jester(JokeOutput jokeOutput, JokeService jokeService)
        {
            _jokeOutput = jokeOutput;
            _jokeService = jokeService;
        }

        public void TellJoke()
        {
            string joke = _jokeService.GetJoke();
            while (joke.Contains("Chuck Norris")) joke = _jokeService.GetJoke();
            _jokeOutput.PrintJoke(joke);
        }
    }
}
