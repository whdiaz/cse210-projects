class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Helps you relax by walking you through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Now, let's begin the breathing exercise...");
        for (int i = 0; i < _duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Breathe out...");
            ShowCountDown(2);
        }
        DisplayEndingMessage();
    }
}
