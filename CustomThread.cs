using System.Threading;



namespace Bank_Logic
{
    // Abstract class for creating threads
    public abstract class CustomThread
    {
        private Thread _thread;



        // Creating new thread
        protected CustomThread()
        {
            _thread = new Thread(Run);
        }



        // Starts thread
        public void Start() => _thread.Start();

        // Stops thread
        public void Stop() => _thread.Abort();

        // Sleep() method creates delay (in milliseconds)
        public void Sleep(int time) => Thread.Sleep(time);

        // Run() method is the loop function that recalls after its end
        public abstract void Run();
    }
}